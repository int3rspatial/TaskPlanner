using DataAccessLayer.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITaskRepository Task { get; private set; }
        public IEmployeeRepository Employee { get; private set; }

        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Task = new TaskRepository(_db);
            Employee = new EmployeeRepository(_db);
        }
        
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
