using AutoMapper;
using BusinessLogicLevel.Interfaces;
using BusinessLogicLevel.Models;
using DataAccessLayer.Repository.IRepository;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel.Services
{
    public class EmployeeService : IEmployeeService
    {
        private Mapper _mapper;
        private IUnitOfWork _database;
        public EmployeeService(Mapper mapper, IUnitOfWork database)
        {
            _mapper = mapper;
            _database = database;
        }
        public void AddEmployee(EmployeeModel employeeModel)
        {
            if(employeeModel.Name != String.Empty)
            {
                _database.Employees.Add(_mapper.Map<Employee>(employeeModel));
                _database.SaveChanges();
            }
        }

        public EmployeeModel GetEmployeeById(int employeeId)
        {
            Employee employee = _database.Employees.GetFirstOrDefault(x => x.Id == employeeId);
            return _mapper.Map<EmployeeModel>(employee);
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            IEnumerable<Employee> employees = _database.Employees.GetAll();
            return _mapper.Map<IEnumerable<EmployeeModel>>(employees);
        }

        public void RemoveEmployee(int employeeId)
        {
            Employee employee = _database.Employees.GetFirstOrDefault(x => x.Id == employeeId);
            foreach (var item in employee.Tasks)
            {
                if(item.TaskStatus == DataAccessLayer.Enums.TaskStatus.InProgress)
                {
                    item.TaskStatus = DataAccessLayer.Enums.TaskStatus.ToDo;
                }
            }
            _database.Employees.Remove(employee);
            _database.SaveChanges();
        }
    }
}
