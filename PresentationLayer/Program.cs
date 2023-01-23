using BusinessLogicLevel;
using BusinessLogicLevel.Models;
using SharedTypes.Enums;

namespace PresentationLayer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ServiceModule serviceModule = new ServiceModule();
            serviceModule.TaskService.DeleteTask(3);
            EmployeeModel employeeModel = serviceModule.EmployeeService.GetEmployeeById(1);
            serviceModule.TaskService.ChangeTaskStatus(4, SharedTypes.Enums.TaskStatus.InProgress);
            serviceModule.TaskService.ChangeTaskPriority(4, TaskPriority.High); 

            Console.WriteLine("\nHello, World!");
        }
    }
}