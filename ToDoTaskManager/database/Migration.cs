using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTaskManager
{
    public class Migration
    {
        private readonly string dbPath;
        private readonly string connectionPath; 

        public Migration(string directory, string dbName)
        {
            dbPath = Path.Combine(directory, dbName);
            connectionPath = $"Data Source={dbPath};";
        }

        public void Migrate()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                using (SQLiteConnection conn = new SQLiteConnection(connectionPath))
                {
                    conn.Open();
                    string createTableQuery = @"
                        CREATE TABLE Tasks (
                            Id TEXT NOT NULL PRIMARY KEY,
                            Description TEXT NOT NULL,
                            StartTime TEXT NOT NULL,
                            EndTime TEXT NOT NULL
                        )";
                    using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Database migrate successfully.");
            }
            else
            {
                Console.WriteLine("Database already exists.");
            }
        }
    }
}