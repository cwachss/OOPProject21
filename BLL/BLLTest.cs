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



            /*CustomerBLL mister = new CustomerBLL();
            //mister.Create("joe", 111, 1231232312, 2021, 12);

            Console.WriteLine(mister.Read(11111));

            Console.WriteLine(mister);*/
            ProductBLL productBLL = new ProductBLL();
            OrderBLL orderBLL = new OrderBLL();
            Console.WriteLine(productBLL.Read(78889));
            
            orderBLL.Create(222, 78889, 10); //correct format
            Console.WriteLine(productBLL.Read(78889));

            orderBLL.Create(123, 78889, 10); //wrong customer id
            orderBLL.Create(222, 78889, 10); //wrong product id
            orderBLL.Create(222, 78889, 101); //ordered too many
            Console.WriteLine(productBLL.Read(78889));

        }
    }
}
