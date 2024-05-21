using System;
using System.Threading.Tasks;

namespace ToDoTaskManager
{
    public class AddTaskHandler
    {
        public async Task AddTaskAsync(string description, DateTime endTime, TasksList tasksList)
        {
            DateTime startTime = DateTime.Now;
            Tasks newTask;

            try
            {
                newTask = new Tasks
                {
                    Id = Guid.NewGuid(),
                    Description = description,
                    StartTime = startTime,
                    EndTime = endTime,
                    Status = TaskStatus.InProgress
                };

                await tasksList.AddTaskAsync(newTask);
            }
            catch
            {
                Console.WriteLine("Ошибка добавления Задачи");
            }
        }

        public async Task AddTaskAsync(string description, DateTime endTime, TasksList tasksList, Tasks existingTask)
        {
            Tasks newTask;

            try
            {
                newTask = new Tasks
                {
                    Id = existingTask.Id,
                    Description = description,
                    StartTime = existingTask.StartTime,
                    EndTime = endTime,
                    Status = existingTask.Status
                };

                await tasksList.UpdateTaskAsync(newTask);
            }
            catch
            {
                Console.WriteLine("Ошибка добавления Задачи");
            }
        }
    }
}
