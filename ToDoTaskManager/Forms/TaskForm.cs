using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager
{
    public partial class TaskForm : MaterialForm
    {
        private MainForm _mainForm;
        private TasksList _tasksList;
        public TaskForm(MainForm MainForm, TasksList TasksList)
        {
            InitializeComponent();
            _mainForm = MainForm;
            _tasksList = TasksList;
        }

        private void mainFormLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void taskCreaterDateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void TaskCreater_Load(object sender, System.EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, System.EventArgs e)
        {

        }

        private void taskCreaterTextBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(taskCreaterTextBox2.Text))
                {
                    MessageBox.Show("Описание задачи не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string description = taskCreaterTextBox2.Text;
                DateTime startTime = DateTime.Now;
                DateTime endTime = taskCreaterDateTimePicker1.Value;

                if ((endTime - startTime).TotalMinutes < 5)
                {
                    MessageBox.Show("Время на завершения задачи должно быть не меньше 5 минут.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Tasks newTask = new Tasks
                {
                    Id = Guid.NewGuid(),
                    Description = description,
                    StartTime = startTime,
                    EndTime = endTime,
                    Status = 1
                };

                _tasksList.AddTask(newTask);

                MessageBox.Show("Задача добавлена.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
