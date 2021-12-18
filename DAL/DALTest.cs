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


            //CustomerDAL try1 = new CustomerDAL();

            //try1.Create("Miss Arr", 28392047, 22232123990904, 1997, 12);
            //Console.WriteLine(try1.customerList[0]);

            //try1.Update("joe shmo", 28392047, 22232123990904, 1989, 11);
            //Console.WriteLine($"{try1.customerList[0]}" + try1.customerList[1]);

            //Console.WriteLine(try1.Read(1)); 

            //CustomerDAL asdf = new CustomerDAL();
            //asdf.Create("asdf", 2141, 41324, 1992, 30);

            OrderDAL tester = new OrderDAL();

            tester.Create(1234, 1234);
            Console.WriteLine(tester.orderList[0]);
            Console.WriteLine();

            tester.Create(1234, 1234);
            Console.WriteLine(tester.orderList[1]);
            Console.WriteLine();

            tester.Update(100, 1223, 1112);
            Console.WriteLine(tester.orderList[1]);
            Console.WriteLine();

            tester.Delete(100);
            Console.WriteLine(tester.orderList[1]);

        }
    }
}
