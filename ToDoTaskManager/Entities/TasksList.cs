using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoTaskManager
{
    public class TasksList
    {
        private List<Tasks> tasks;
        private readonly Repository _repo;

        public TasksList(Repository repo)
        {
            _repo = repo;
            tasks = new List<Tasks>();
        }

        public async Task InitializeTasksAsync()
        {
            tasks = await _repo.GetAllAsync();
        }

        public async Task AddTaskAsync(Tasks newTask)
        {
            tasks.Add(newTask);
            await _repo.AddTaskAsync(newTask);
        }

        public async Task RemoveTaskAsync(Guid taskId)
        {
            tasks.RemoveAll(t => t.Id == taskId);
            await _repo.DeleteTaskAsync(taskId);
        }

        public async Task UpdateTaskAsync(Tasks task)
        {
            tasks.RemoveAll(t => t.Id == task.Id);
            tasks.Add(task);
            await _repo.UpdateTaskAsync(task);
        }

        public List<Tasks> GetAllTasks()
        {
            return tasks;
        }

        public Task<List<Tasks>> GetAllTasksAsync()
        {
            return Task.FromResult(tasks);
        }
    }
}










//using System;
//using System.Collections.Generic;

//namespace ToDoTaskManager
//{
//    public class TasksList
//    {
//        private List<Tasks> tasks;
//        private readonly Repository _repo;

//        public TasksList(Repository repo)
//        {
//            _repo = repo;
//            tasks = _repo.GetAll();
//        }

//        public void AddTask(Tasks newTask)
//        {
//            tasks.Add(newTask);
//            _repo.AddTask(newTask);
//        }

//        public void RemoveTask(Guid taskId)
//        {
//            tasks.RemoveAll(t => t.Id == taskId);
//            _repo.DeleteTask(taskId);
//        }

//        public void UpdateTask(Tasks task)
//        {
//            tasks.RemoveAll(t => t.Id == task.Id);
//            tasks.Add(task);
//            _repo.UpdateTask(task);
//        }

//        public List<Tasks> GetAllTasks()
//        {
//            return tasks;
//        }
//    }
//}
