using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Manager : Employee
    {
        public int Experience { get; set; }

        public Manager(int experience, decimal salary, string first_name, string last_name, int id) :base(salary, first_name, last_name, id)
        {
            Experience = experience;
        }
    }
}
