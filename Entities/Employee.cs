//Chani Wachsstock and Shira Laury

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
        public string Password { get; set; }

        public Employee(decimal salary, string first_name, string last_name, int id, string password) :base(first_name, last_name, id)
        {
            Salary = salary;
            Password = password;
        }

        public override String ToString()
        {
            return $"{FirstName} {LastName} (Password: {Password})";
        }
    }
}
