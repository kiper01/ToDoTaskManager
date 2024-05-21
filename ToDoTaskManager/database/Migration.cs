using System;
using System.Data.SQLite;
using System.IO;

namespace ToDoTaskManager
{
    public class Migration
    {
        private readonly string _dbPath;
        private readonly string connectionPath; 

        public Migration(string directory, string dbName)
        {
            _dbPath = Path.Combine(directory, dbName);
            connectionPath = $"Data Source={_dbPath};";
        }

        public void Migrate()
        {
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
                using (SQLiteConnection conn = new SQLiteConnection(connectionPath))
                {
                    conn.Open();
                    string createTableQuery = @"
                        CREATE TABLE Tasks (
                            Id TEXT NOT NULL PRIMARY KEY,
                            Description TEXT NOT NULL,
                            StartTime TEXT NOT NULL,
                            EndTime TEXT NOT NULL,
                            Status INTEGER NOT NULL
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