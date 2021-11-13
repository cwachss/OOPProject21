using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLTest
    {
        static void Main(string[] args)
        {
            try
            {
                ProductBLL obj = new ProductBLL();


            }
            catch(ProductNumberOutOfRange numOut)
            {
                Console.WriteLine(numOut.Message);            }
        }
    }
}
