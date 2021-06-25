using System.Linq;
using CSBI.Data.Model;

namespace CSBI.Data.Interface
{
    public interface ITask
    {
        IQueryable<Task> GetTaskCollection();
        IQueryable<Task> GetTaskOfTimeCollection();
        void CreateTask(Task achievement);
        void UpdateTask(Task achievement);
        void DeleteTask(Task achievement);
    }
}
