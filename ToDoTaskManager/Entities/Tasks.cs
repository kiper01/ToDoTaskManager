using System;

namespace ToDoTaskManager
{
    public enum TaskStatus //0 - задача в работе, 1 - дедлайн задачи 5 минут, 2 - задача просрочена, 3 - задача выполнена
    {
        InProgress,
        CloseToCompletion,
        Overdue,
        Completed
    }

    public class Tasks
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TaskStatus Status { get; set; }
    }
}