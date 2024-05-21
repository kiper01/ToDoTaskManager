using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoTaskManager.Entities;

namespace ToDoTaskManager
{
    public partial class TaskForm : MaterialForm
    {
        private readonly MainForm _mainForm;
        private readonly TasksList _tasksList;
        private readonly Tasks _task;
        private readonly bool choiceOption;

        public TaskForm(MainForm mainForm, TasksList tasksList)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _tasksList = tasksList;
            choiceOption = true;
        }

        public TaskForm(MainForm mainForm, TasksList tasksList, Tasks task)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _tasksList = tasksList;
            _task = task;
            mainFormLabel1.Text = "Редактирование задачи";
            mainFormLabel1.Location = new Point(10, 27);
            materialFlatButton1.Text = "Сохранить";
            materialFlatButton1.Location = new Point(145, 450);
            taskCreaterTextBox2.Text = task.Description;
            taskCreaterDateTimePicker1.Value = task.EndTime;
            choiceOption = false;
        }

        private void mainFormLabel1_Click(object sender, EventArgs e)
        {

        }

        private void taskCreaterDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TaskCreater_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void taskCreaterTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void materialFlatButton1_Click(object sender, EventArgs e)
        {
            await AddTaskAsync();
        }

        private async Task AddTaskAsync()
        {
            if (string.IsNullOrWhiteSpace(taskCreaterTextBox2.Text))
            {
                MessageBox.Show("Описание задачи не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string description = taskCreaterTextBox2.Text;
            DateTime endTime = taskCreaterDateTimePicker1.Value;

            if ((endTime - DateTime.Now).TotalMinutes < 5)
            {
                MessageBox.Show("Время на завершение задачи должно быть не меньше 5 минут.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AddTaskHandler taskHandler = new AddTaskHandler();
            try
            {
                if (choiceOption)
                {
                    await taskHandler.AddTaskAsync(description, endTime, _tasksList);
                }
                else
                {
                    await taskHandler.AddTaskAsync(description, endTime, _tasksList, _task);
                }

                MessageBox.Show("Задача " + (choiceOption ? "добавлена." : "обновлена."), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _mainForm.MainFormUpdater();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
