using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CSBI.Data;
using CSBI.Data.Interface;
using CSBI.Data.Model;
using System.Threading.Tasks;

namespace CSBI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITask _task;

        public HomeController(ITask task)
        {
            _task = task;
        }

        public IActionResult Index() => View(_task.GetTaskCollection().ToList());
        public IActionResult TasksOfTime() => View(_task.GetTaskOfTimeCollection().ToList());
    }
}
