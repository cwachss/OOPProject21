using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     class CreditCardNumOutOfRange:Exception
    {
        public CreditCardNumOutOfRange() : base("Whoops! The credit card number entered is not valid")
        {

        }

        public CreditCardNumOutOfRange(string messageValue) : base(messageValue)
        {

        }
        public CreditCardNumOutOfRange(string messageValue, Exception inner) : base(messageValue, inner)
        {

        }
    }
}
