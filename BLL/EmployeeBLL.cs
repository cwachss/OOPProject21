using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class EmployeeBLL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();

        public Employee ReadEmployee(int id)
        {
            return employeeDAL.ReadEmployee(id);
        }

        public List<Employee> ReadAll()
        {
            return employeeDAL.ReadAll();
        }
    }
}
