using BusinessLogicLevel.Interfaces;
using BusinessLogicLevel.Models;
using Microsoft.AspNetCore.Mvc;

namespace TaskPlannerWeb.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            IEnumerable<TaskModel> tasks = _taskService.GetTasks();
            return View(tasks);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
