using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class BLLTest
    {
        static void Main(string[] args)
        {


           
            CustomerBLL mister = new CustomerBLL();
            mister.Create("joe", 111, 1231232312, 2021, 12);

            Console.WriteLine(mister.Read(11111));
        }
    }
}
