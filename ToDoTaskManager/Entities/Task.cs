using System;
using System.Data;

namespace ToDoTaskManager
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Description { get; protected set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; protected set; }
        public DateTime DeadlineTime { get; protected set; }

        public void Update() { }

        public void Delete() { }
    }
}