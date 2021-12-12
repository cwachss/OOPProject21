//Chani Wachsstock and Shira Laury
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SalesRep : Employee
    {
        public double CommissionRate { get; set; }

        public SalesRep(double commission, decimal salary, string first_name, string last_name, int id) : base(salary, first_name,last_name, id)
        {
            CommissionRate = commission;
        }
    }
}
