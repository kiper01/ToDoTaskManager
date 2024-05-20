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

            //db conn
            string conn = $"Data Source={Path.Combine(directory, dbName)}";
            Repository.GetInstance(conn);

            //app start
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
