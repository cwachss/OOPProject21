using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class MonthOutOfRange:Exception
    {
        public MonthOutOfRange():base("Oops! That month is out of range.")
        {

        }
        public MonthOutOfRange(string messageValue) : base(messageValue)
        {

        }
        public MonthOutOfRange(string messageValue, Exception inner):base (messageValue, inner)
        {

        }
    }
}
