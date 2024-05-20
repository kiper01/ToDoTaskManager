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
        public int Status { get; set; } //1 - задача в работе, 2 - дедлайн задачи 5 минут, 3 - задача просрочена, 4 - задача выполнена

        public void Update() { }

        public void Delete() { }

    }
}