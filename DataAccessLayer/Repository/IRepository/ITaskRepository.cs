using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DataAccessLayer.Models.Task;

namespace DataAccessLayer.Repository.IRepository
{
    public interface ITaskRepository : IRepository<Task> 
    {
        void Update(Task task);
    }
}
