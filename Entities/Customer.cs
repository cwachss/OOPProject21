//Chani Wachsstock and Shira Laury

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

        public Customer(string firstName, string lastName, string ccName, int idNum, long creditCardNum, int year, int month) :base(firstName, lastName, idNum)
        {
            expirationDate = new DateTime(year, month, 1);
            myCreditCard = new CreditCard(ccName, creditCardNum, expirationDate);
        }

        public Customer(string first_name,string last_name, int idNum, CreditCard aCreditCard) : base(first_name, last_name, idNum)
        {
           myCreditCard = aCreditCard;
        }
        public Customer(Customer realCustomer) : base(realCustomer.FirstName, realCustomer.LastName, realCustomer.ID)
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
            return $"{myCreditCard.OwnerFirstName}\t{myCreditCard.OwnerLastName}\t{myCreditCard.CardNumber}\t" +
                $"\t{expirationDate.Year}\t{expirationDate.Month}";
        }

    }
}
