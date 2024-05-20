﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTaskManager
{
    public class Repository
    {
        private readonly string connectionPath;
        private static Repository instance;

        private Repository(string connectionPath)
        {
            this.connectionPath = connectionPath;
        }

        public static Repository GetInstance(string connectionPath)
        {
            if (instance == null)
            {
                instance = new Repository(connectionPath);
            }
            return instance;
        }

        public static Repository Instance { get { return instance; } }
        
        public void AddTask(Tasks task)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionPath))
            {
                conn.Open();
                string sql = "INSERT INTO Tasks (Id, Description, StartTime, EndTime) VALUES (@Id, @Description, @StartTime, @EndTime)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", task.Id.ToString());
                    cmd.Parameters.AddWithValue("@Description", task.Description);
                    cmd.Parameters.AddWithValue("@StartTime", task.StartTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@EndTime", task.EndTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void DeleteTask(Guid taskId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionPath))
            {
                conn.Open();
                string sql = "DELETE FROM Tasks WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", taskId.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTask(Tasks task)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionPath))
            {
                conn.Open();
                string sql = "UPDATE Tasks SET Description = @Description, StartTime = @StartTime, EndTime = @EndTime WHERE Id = @Id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", task.Id.ToString());
                    cmd.Parameters.AddWithValue("@Description", task.Description);
                    cmd.Parameters.AddWithValue("@StartTime", task.StartTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@EndTime", task.EndTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Tasks> GetAllTasks()
        {
            List<Tasks> tasks = new List<Tasks>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionPath))
            {
                conn.Open();
                string sql = "SELECT * FROM Tasks";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tasks task = new Tasks
                        {
                            Id = Guid.Parse(reader["Id"].ToString()),
                            Description = reader["Description"].ToString(),
                            StartTime = DateTime.Parse(reader["StartTime"].ToString()),
                            EndTime = DateTime.Parse(reader["EndTime"].ToString())
                        };

                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }
    }
}
