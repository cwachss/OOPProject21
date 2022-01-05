using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class EmployeeDAL
    {
        Employee chani;
        Employee shira;
        Employee mrsparnes;
        List<Employee> employees = new List<Employee>();
        public EmployeeDAL()
        {
            chani = new Employee(120, "Chani", "Wachsstock", 1234, "Chello");
            shira = new Employee(120, "Shira", "Laury", 5678, "Hurray!");
            mrsparnes = new Employee(500, "Mrs.", "Parnes", 9012, "#1Teacher");
            employees.Add(chani);
            employees.Add(shira);
            employees.Add(mrsparnes);

        }

        public Employee ReadEmployee(int id)
        {
            Employee requestedInfo;
            for(int i = 0; i < employees.Count; i++)
            {
                if(employees[i].ID == id)
                {
                    requestedInfo = new Employee(employees[i].Salary, employees[i].FirstName,employees[i].LastName, employees[i].ID, employees[i].Password);
                    return requestedInfo;
                }
               
            }
            throw new Exception("Employee not found");
        }

        public List<Employee> ReadAll()
        {
            List<Employee> copyOfList = employees.ConvertAll(emp => new Employee(emp.Salary, emp.FirstName, emp.LastName, emp.ID, emp.Password)); //send a copy of the list, rather than the actual list

            return copyOfList;
        }
        

        
    }
}
