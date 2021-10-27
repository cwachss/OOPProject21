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

        public SalesRep(double commission, decimal salary, string name, int id) : base(salary, name, id)
        {
            CommissionRate = commission;
        }
    }
}
