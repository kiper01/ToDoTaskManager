using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoTaskManager
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //db migrate
            string directory = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "database");
            string dbName = "tododatabase.db";
            Migration migration = new Migration(directory, dbName);
            migration.Migrate();

            //db conn && tasklist init
            string conn = $"Data Source={Path.Combine(directory, dbName)}";
            Repository repo = new Repository(conn);
            TasksList tasksList = new TasksList(repo);

            //app start
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(tasksList));
        }
    }
}
//MessageBox.Show("Срок выполнения одной из ваших задач близится к концу.", "Дедлайн", MessageBoxButtons.OK, MessageBoxIcon.Information);