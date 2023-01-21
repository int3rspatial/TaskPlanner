using BusinessLogicLevel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployee(EmployeeModel employeeModel);
        EmployeeModel GetEmployeeById(int employeeId);
        IEnumerable<EmployeeModel> GetEmployees();
        void RemoveEmployee(int employeeId);
    }
}
