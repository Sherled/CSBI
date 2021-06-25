using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using CSBI.Data.Interface;
using CSBI.Data.Model;

namespace CSBI.Data.Service
{
    public class TaskService : ITask
    {
        private readonly ApplicationContext appDBContent;

        public TaskService(ApplicationContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public void CreateTask(Task task)
        {
            appDBContent.Add(task);
            appDBContent.SaveChanges();
        }

        public void DeleteTask(Task task)
        {
            appDBContent.Remove(task);
            appDBContent.SaveChanges();
        }

        public IQueryable<Task> GetTaskOfTimeCollection()
        {
            return appDBContent.Tasks.Where(x=>x.End > DateTime.Now);
        }

        public IQueryable<Task> GetTaskCollection()
        {
            var tasks = appDBContent.Tasks.Include("Status");
            return tasks;
        }

        public void UpdateTask(Task task)
        {
            appDBContent.Entry(task).State = EntityState.Modified;
            appDBContent.SaveChanges();
        }
    }
}
