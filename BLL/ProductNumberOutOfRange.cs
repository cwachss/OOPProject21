using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ProductNumberOutOfRange : Exception
    {
        public ProductNumberOutOfRange():base("Whoops! That product ID number is not in our systems.")
        {

        }

        public ProductNumberOutOfRange(string messageValue):base(messageValue)
        {

        }
        public ProductNumberOutOfRange(string messageValue, Exception inner) :base(messageValue, inner)
        {

        }
    }
}
