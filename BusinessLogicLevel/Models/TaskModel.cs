using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int EstimatedTime { get; set; }
        public TaskPriority TaskPriority { get; set; }
        public DataAccessLayer.Enums.TaskStatus TaskStatus { get; set; }
    }
}
