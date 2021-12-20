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
        public CreditCard myCreditCard; //need to set this to private and then create get methods for all its details
        DateTime expirationDate;

        public Customer(string firstName, string lastName,  int idNum, string ccName, string creditCardNum, int year, int month) :base(firstName, lastName, idNum)
        {
            expirationDate = new DateTime(year, month, 1);
            myCreditCard = new CreditCard(ccName, creditCardNum, expirationDate);
        }

        public Customer(string firstName, string lastName, int idNum) : base(firstName, lastName, idNum) { }

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
            return $"{FirstName}\t{LastName}\t" +
                $"{ID}";
        }

    }
}
