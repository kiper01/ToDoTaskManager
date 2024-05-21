using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoTaskManager.Entities.Design;
using ToDoTaskManager.Properties;

namespace ToDoTaskManager
{
    public partial class MainForm : MaterialForm
    {
        private readonly TasksList _tasksList;
        private CancellationTokenSource _cancellationTokenSource;

        public MainForm(TasksList tasksList)
        {
            _tasksList = tasksList;
            InitializeComponent();
            this.Load += async (s, e) => await MainForm_LoadAsync();
        }

        private async Task MainForm_LoadAsync()
        {
            await InitializeTaskBlocksAsync();
            UpdateTimer();
        }

        private async Task InitializeTaskBlocksAsync()
        {
            await UpdateTasksListStatusAsync(_tasksList);
            var tasks = await _tasksList.GetAllTasksAsync();
            foreach (var task in tasks)
            {
                Panel taskPanel = CreateTaskBlock(task);
                mainFormFlowLayoutPanel1.Controls.Add(taskPanel);
            }
        }

        public async void MainFormUpdater()
        {
            mainFormFlowLayoutPanel1.Controls.Clear();
            await InitializeTaskBlocksAsync();
        }

        private MainFormFlowPanel CreateTaskBlock(Tasks task)
        {
            MainFormFlowPanel panel = new MainFormFlowPanel
            {
                Name = $"panel_{task.Id}"
            };

            MainFormFlowTimerLabel timer = new MainFormFlowTimerLabel("00:00:00")
            {
                Name = $"timer_{task.Id}"
            };

            switch (task.Status)
            {
                case TaskStatus.CloseToCompletion:
                    panel.BackColor = Color.Wheat;
                    break;
                case TaskStatus.Overdue:
                    panel.BackColor = Color.IndianRed;
                    timer.Text = "Время вышло";
                    break;
                case TaskStatus.Completed:
                    panel.BackColor = Color.LightGreen;
                    timer.Text = "Выполнено";
                    break;
                default:
                    break;
            }

            MainFormFlowDescriptionLabel descriptionLabel = new MainFormFlowDescriptionLabel(task.Description);
            MainFormFlowCompleteButton completeButton = new MainFormFlowCompleteButton();

            MainFormFlowButton editButton = new MainFormFlowButton
            {
                Location = new Point(159, 261),
                BackgroundImage = Resources.edit
            };

            MainFormFlowButton deleteButton = new MainFormFlowButton
            {
                Location = new Point(200, 261),
                BackgroundImage = Resources.trash
            };

            completeButton.Click += async (sender, e) => await CompleteTaskAsync(task);
            editButton.Click += (sender, e) => EditTask(task);
            deleteButton.Click += async (sender, e) => await DeleteTaskAsync(task);

            panel.Controls.Add(descriptionLabel);
            panel.Controls.Add(timer);
            panel.Controls.Add(completeButton);
            panel.Controls.Add(editButton);
            panel.Controls.Add(deleteButton);

            return panel;
        }

        private string GetTimeInterval(Tasks task)
        {
            TimeSpan timer = task.EndTime - DateTime.Now;
            return timer.ToString(@"hh\:mm\:ss");
        }

        private async Task CompleteTaskAsync(Tasks task)
        {
            task.Status = TaskStatus.Completed;
            await _tasksList.UpdateTaskAsync(task);
            MainFormUpdater();
        }

        private void EditTask(Tasks task)
        {
            OpenTaskForm(this, _tasksList, task);
        }

        private async Task DeleteTaskAsync(Tasks task)
        {
            var confirmResult = MessageBox.Show("Вы точно хотите удалить эту задачу?", "Удаление задачи", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                await _tasksList.RemoveTaskAsync(task.Id);
                MainFormUpdater();
            }
        }

        public void OpenTaskForm(MainForm mainForm, TasksList tasksList)
        {
            if (Application.OpenForms.OfType<TaskForm>().Count() == 0)
            {
                new TaskForm(mainForm, tasksList).Show();
            }
        }

        public void OpenTaskForm(MainForm mainForm, TasksList tasksList, Tasks task)
        {
            if (Application.OpenForms.OfType<TaskForm>().Count() == 0)
            {
                new TaskForm(mainForm, tasksList, task).Show();
            }
        }

        private void mainFormButton1_Click(object sender, EventArgs e)
        {
            OpenTaskForm(this, _tasksList);
        }

        private void mainFormLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mainFormLabel2_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopUpdateTimer();
            base.OnFormClosing(e);
        }

        private void UpdateTimer()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(1000);
                    if (!token.IsCancellationRequested)
                    {
                        this.Invoke(new Action(UpdateTimerLabels));
                    }
                }
            }, token);
        }

        private void StopUpdateTimer()
        {
            _cancellationTokenSource?.Cancel();
        }

        private bool updateScanner = false;
        private void UpdateTimerLabels()
        {
            if (updateScanner) UpdateTaskStatus();
            var tasks = _tasksList.GetAllTasksAsync().Result;
            foreach (var task in tasks)
            {
                var timerLabel = mainFormFlowLayoutPanel1.Controls.Find($"timer_{task.Id}", true).FirstOrDefault() as Label;
                if (timerLabel != null && task.Status != TaskStatus.Overdue && task.Status != TaskStatus.Completed)
                {
                    timerLabel.Text = GetTimeInterval(task);

                    if (task.EndTime < DateTime.Now)
                    {
                        updateScanner = true;
                    }

                    if ((task.EndTime - DateTime.Now).TotalSeconds <= 300 && task.Status == TaskStatus.InProgress)
                    {
                        updateScanner = true;
                        MessageBox.Show("Срок выполнения одной из ваших задач близится к концу.", "Дедлайн", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void UpdateTaskStatus()
        {
            await UpdateTasksListStatusAsync(_tasksList);
            MainFormUpdater();
            updateScanner = false;
        }

        private async Task UpdateTasksListStatusAsync(TasksList tasksList)
        {
            List<Tasks> newListTasks = new List<Tasks>();
            var tasks = await tasksList.GetAllTasksAsync();
            foreach (var task in tasks)
            {
                if (task.Status == TaskStatus.Completed || task.Status == TaskStatus.Overdue) continue;

                TimeSpan remainingTime = task.EndTime - DateTime.Now;

                if (task.EndTime < DateTime.Now)
                {
                    task.Status = TaskStatus.Overdue;
                }
                else if (remainingTime.TotalMinutes <= 5)
                {
                    task.Status = TaskStatus.CloseToCompletion;
                }
                else
                {
                    task.Status = TaskStatus.InProgress;
                }

                newListTasks.Add(task);
            }

            foreach (var task in newListTasks)
            {
                await tasksList.UpdateTaskAsync(task);
            }
        }
    }
}
