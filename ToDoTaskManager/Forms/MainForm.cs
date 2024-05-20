using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager
{
    public partial class MainForm : MaterialForm
    {
        private TasksList _tasksList;
        public MainForm(TasksList TasksList)
        {
            _tasksList = TasksList;
            InitializeComponent();
            M();
        }

        int i = 0;
        async void M()
        {
            while (true)
            {
                i++;
                UpdateLabel(i);
                await Task.Delay(1000);
            }
        }

        private void UpdateLabel(int value)
        {
            if (mainFormLabel2.InvokeRequired)
            {
                mainFormLabel2.Invoke(new Action(() => mainFormLabel2.Text = value.ToString()));
            }
            else
            {
                mainFormLabel2.Text = value.ToString();
            }
        }


        private void mainFormButton1_Click(object sender, EventArgs e) 
        //добавить какое нибудь ограничение на количество существующих форм!!!!!!!!!!
        {
            new TaskForm(this, _tasksList).Show();
        }

        private void mainFormLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
