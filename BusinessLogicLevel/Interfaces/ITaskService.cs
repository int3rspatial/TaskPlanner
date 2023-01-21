using BusinessLogicLevel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(TaskModel taskModel);
        TaskModel GetTaskById(int taskId);
        IEnumerable<TaskModel> GetTasks();
        void DeleteTask(int taskId);

    }
}
