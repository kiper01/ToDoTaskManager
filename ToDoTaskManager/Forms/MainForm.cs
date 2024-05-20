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
        public MainForm()
        {
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
        {
            new TaskForm(this).Show();
        }

        //private void mainFormButton1_Click(object sender, EventArgs e)
        //{
        //    new Thread(() =>
        //    {
        //        //TaskCreater taskcreaterForm = new TaskCreater();
        //        new TaskCreater().Show();
        //    }).Start();
        //}

        //private Task OpenTaskCreaterFormAsync()
        //{
        //    return Task.Run(() =>
        //    {
        //        // Создаем новую форму в UI-потоке
        //        if (this.InvokeRequired)
        //        {
        //            this.Invoke(new Action(() =>
        //            {
        //                TaskCreater taskcreaterForm = new TaskCreater();
        //                taskcreaterForm.Show();
        //            }));
        //        }
        //        else
        //        {
        //            TaskCreater taskcreaterForm = new TaskCreater();
        //            taskcreaterForm.Show();
        //        }
        //    });
        //}

        private void mainFormLabel1_Click(object sender, EventArgs e)
        {
            // Обработчик для mainFormLabel1, если он нужен
        }
    }
}
