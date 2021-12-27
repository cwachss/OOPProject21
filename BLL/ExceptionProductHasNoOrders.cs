using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class ExceptionProductHasNoOrders:Exception
    {
        public ExceptionProductHasNoOrders()
        {

        }
        public ExceptionProductHasNoOrders(string message):base(message)
        {

        }
        public ExceptionProductHasNoOrders(string message, Exception e):base(message, e)
        {

        }
    }
}
