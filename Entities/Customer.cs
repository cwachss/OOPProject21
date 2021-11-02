using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : Person
    {
        //any variables? i don't think so.

        public Customer(string name, int idNum, int creditCardNum, int year, int month) :base(name, idNum)
        {
            DateTime expirationDate = new DateTime(year, month, 1);
            CreditCard myCreditCard = new CreditCard(name, creditCardNum, expirationDate);
        }
    }
}
