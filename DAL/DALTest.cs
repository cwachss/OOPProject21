using Entities;
using System;


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

            //OrderDAL tester = new OrderDAL();

            // Console.WriteLine(tester.CheckForCustomer(222));
            //CustomerDAL name = new CustomerDAL();
            //Console.WriteLine(CustomerDAL.customerList[0]);
            //Console.WriteLine("###############");
            //name.Create("asdf", "asdf", 134, "asdfa alskd", "0909090909090909", 2021, 10);
            //Console.WriteLine(CustomerDAL.customerList[1]);
            ////tester.InitilizeList();
            //Order newSale = new Order(1233, 000, 120394);
            //Customer vew = new Customer("me", "last", 342116);
            OrderDAL orderDAL = new OrderDAL();
            orderDAL.Create(342116, 90876);
            Console.WriteLine(orderDAL.ReadOrderViaCustomer(342116));
            Console.WriteLine(orderDAL.ReadOrderViaProduct(90876));
            Console.WriteLine(orderDAL.ReadOrderViaOrder(100));
        }
    }
}
