using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee(decimal salary, string name, int id) :base(name, id)
        {
            Salary = salary;
        }
    }
}
