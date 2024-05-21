using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ToDoTaskManager.Entities.Design;
using ToDoTaskManager.Properties;

namespace ToDoTaskManager
{
    public partial class MainForm : MaterialForm
    {
        private TasksList _tasksList;
        private CancellationTokenSource _cancellationTokenSource;

        public MainForm(TasksList tasksList)
        {
            _tasksList = tasksList;
            InitializeComponent();
            InitializeTaskBlocks();
            UpdateTimer();
        }

        private void InitializeTaskBlocks()
        {
            UpdateTasksListStatus(_tasksList);
            foreach (var task in _tasksList.GetAllTasks())
            {
                Panel taskPanel = CreateTaskBlock(task);
                mainFormFlowLayoutPanel1.Controls.Add(taskPanel);
            }
        }

        public void MainFormUpdater()
        {
            mainFormFlowLayoutPanel1.Controls.Clear();
            InitializeTaskBlocks();
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
                case 1:
                    break;
                case 2:
                    panel.BackColor = Color.Wheat;
                    break;
                case 3:
                    panel.BackColor = Color.IndianRed;
                    timer.Text = "Время вышло";
                    break;
                case 4:
                    panel.BackColor = Color.LightGreen;
                    timer.Text = "Выполнено";
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

            completeButton.Click += (sender, e) => CompleteTask(task);
            editButton.Click += (sender, e) => EditTask(task);
            deleteButton.Click += (sender, e) => DeleteTask(task);

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

        private void CompleteTask(Tasks task)
        {
            task.Status = 4;
            _tasksList.UpdateTask(task);
            MainFormUpdater();
        }

        private void EditTask(Tasks task)
        {
            OpenTaskForm(this, _tasksList, task);
        }

        private void DeleteTask(Tasks task)
        {
            var confirmResult = MessageBox.Show("Вы точно хотите удалить эту задачу?",
                                     "Удаление задачи",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _tasksList.RemoveTask(task.Id);
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

        bool updateScanner = false;
        private void UpdateTimerLabels()
        {
            if (updateScanner) UpdateTaskStatus();
            foreach (var task in _tasksList.GetAllTasks())
            {
                var timerLabel = mainFormFlowLayoutPanel1.Controls.Find($"timer_{task.Id}", true).FirstOrDefault() as Label;
                if (timerLabel != null && task.Status != 3 && task.Status != 4)
                {
                    timerLabel.Text = GetTimeInterval(task);

                    if (task.EndTime < DateTime.Now)
                    {
                        updateScanner = true;
                    }

                    if ((task.EndTime - DateTime.Now).TotalSeconds <= 300 && task.Status == 1)
                    {
                        updateScanner = true;
                        MessageBox.Show("Срок выполнения одной из ваших задач близится к концу.", "Дедлайн", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void UpdateTaskStatus()
        {
            UpdateTasksListStatus(_tasksList);
            MainFormUpdater();
            updateScanner = false;
        }

        private void UpdateTasksListStatus(TasksList _tasksList)
        {
            List<Tasks> newListTasks = new List<Tasks>();
            foreach (var task in _tasksList.GetAllTasks())
            {
                if (task.Status == 4 || task.Status == 3) continue;

                TimeSpan remainingTime = task.EndTime - DateTime.Now;

                if (task.EndTime < DateTime.Now)
                {
                    task.Status = 3;
                }

                else if (remainingTime.TotalMinutes <= 5)
                {
                    task.Status = 2;
                }

                else
                {
                    task.Status = 1;
                }

                newListTasks.Add(task);
            }

            foreach (var task in newListTasks)
            {
                _tasksList.UpdateTask(task);
            }
        }

    }
}
