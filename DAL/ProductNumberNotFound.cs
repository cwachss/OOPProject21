//Chani Wachsstock and Shira Laury
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductNumberNotFound: Exception
    {
        public ProductNumberNotFound() : base("Whoops! That product ID number is not in our systems.")
        {

        }

        public ProductNumberNotFound(string messageValue) : base(messageValue)
        {

        }
        public ProductNumberNotFound(string messageValue, Exception inner) : base(messageValue, inner)
        {

        }
    }
}
