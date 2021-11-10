using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    class DALTest
    {
        static void Main(string[] args)
        {
            ProductDAL products = new ProductDAL();
            products.Create(1234, "food", (decimal)4.99);
            Console.WriteLine(products.Read(1234));
            Console.WriteLine(products.ReadAll());
            Console.WriteLine(products.Read(87234));
            products.Delete(87234);
            Console.WriteLine(products.Read(87234));
        }
    }
}
