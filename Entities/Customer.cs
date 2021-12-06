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

        public Customer(string name, int idNum, long creditCardNum, int year, int month) :base(name, idNum)
        {
            expirationDate = new DateTime(year, month, 1);
            myCreditCard = new CreditCard(name, creditCardNum, expirationDate);
        }

        public Customer(string name, int idNum, CreditCard aCreditCard) : base(name, idNum)
        {
           myCreditCard = aCreditCard;
        }
        public Customer(Customer realCustomer) : base(realCustomer.Name, realCustomer.ID)
        {
            expirationDate = realCustomer.expirationDate;
            myCreditCard = realCustomer.myCreditCard;
        }

        //public Customer(Customer user):base (name, id)
        //{
        //    Name = user.Name;
        //    ID = user.ID;
        //    myCreditCard = user.myCreditCard;

        //}
        public override string ToString()
        {
            return $"{myCreditCard.OwnerName}\t{myCreditCard.CardNumber}\t" +
                $"{expirationDate.Year}\t{expirationDate.Month}\t{expirationDate.Day}" + base.ToString();
        }

    }
}
