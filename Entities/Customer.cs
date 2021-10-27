using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : Person
    {


        public Customer(CreditCard creditCardNum, string name, int idNum) :base(name, idNum)
        {
        }
    }
}
