using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer : Person
    {
        public CreditCard myCreditCard;
        DateTime expirationDate;

        public Customer(string name, int idNum, int creditCardNum, int year, int month) :base(name, idNum)
        {
            expirationDate = new DateTime(year, month, 1);
            myCreditCard = new CreditCard(name, creditCardNum, expirationDate);
        }
    }
}
