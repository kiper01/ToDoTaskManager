using System;
using System.Collections.Generic;

namespace ToDoTaskManager
{
    public class TasksList
    {
        private List<Tasks> tasks;
        private readonly Repository _repo;

        public TasksList(Repository repo)
        {
            _repo = repo;
            tasks = _repo.GetAll();
        }

        public void AddTask(Tasks newTask)
        {
            tasks.Add(newTask);
            _repo.AddTask(newTask);
        }

        public void RemoveTask(Guid taskId)
        {
            tasks.RemoveAll(t => t.Id == taskId);
            _repo.DeleteTask(taskId);
        }

        public void UpdateTask(Tasks task)
        {
            tasks.RemoveAll(t => t.Id == task.Id);
            tasks.Add(task);
            _repo.UpdateTask(task);
        }

        public List<Tasks> GetAllTasks()
        {
            return tasks;
        }
    }
}
