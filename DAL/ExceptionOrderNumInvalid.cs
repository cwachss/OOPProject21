using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExceptionOrderNumInvalid : Exception
    {
        public ExceptionOrderNumInvalid() : base()
        {

        }
        public ExceptionOrderNumInvalid(string message) : base(message)
        {

        }
        public ExceptionOrderNumInvalid(string message, Exception e) : base(message, e)
        {

        }
    }
}
