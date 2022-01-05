using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerNotFound:Exception
    {
        public CustomerNotFound()
        {

        }
        public CustomerNotFound(string message): base(message)
        {

        }
        public CustomerNotFound(string message, Exception ex): base(message,ex)
        {

        }
    }
}
