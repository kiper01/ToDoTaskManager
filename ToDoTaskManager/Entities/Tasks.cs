using System;
using System.Data;

namespace ToDoTaskManager
{
    public class Tasks
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void Update() { }

        public void Delete() { }

    }
}