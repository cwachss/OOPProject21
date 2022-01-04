using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExceptionCustomerHasNoOrders : Exception
    {

        public ExceptionCustomerHasNoOrders() : base()
        {

        }
        public ExceptionCustomerHasNoOrders(string message) : base(message)
        {

        }
        public ExceptionCustomerHasNoOrders(string message, Exception e) : base(message, e)
        {

        }
    }
}
