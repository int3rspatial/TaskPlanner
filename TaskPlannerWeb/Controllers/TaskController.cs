using BusinessLogicLevel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TaskPlannerWeb.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService taskService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
