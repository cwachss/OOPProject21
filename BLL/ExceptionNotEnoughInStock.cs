using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExceptionNotEnoughInStock:Exception
    {
        public ExceptionNotEnoughInStock()
        {

        }
        public ExceptionNotEnoughInStock(string message) : base(message)
        {

        }
        public ExceptionNotEnoughInStock(string message, Exception e) : base(message, e)
        {

        }
    }
}
