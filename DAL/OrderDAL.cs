using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DAL
{
    public class OrderDAL
    {
        internal List<Order> orderList = new List<Order>();
        int orderNumber = 100;

        public OrderDAL()
        {
            InitilizeList();
        }
        public void InitilizeList()
        {
            //StreamReader reader = new StreamReader(@"../../bin/debug/ListOfOrders.txt");
            //string line;
            //using(reader)
            //{
            //    for (int i = 0; (line = reader.ReadLine()) != null; i++)
            //    {
            //        string [] array =line.Split(' ');
            //        Order sale1 = new Order(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
            //        orderList.Add(sale1);
            //        Console.WriteLine(orderNumber);
            //        Console.WriteLine(transaction.customerID);
            //        Console.WriteLine(transaction.productID);
            //    }
            //}
        }

        public void Create(int customerID, int productID)
        {

            Order order = new Order(orderNumber, customerID, productID);
            orderList.Add(order);
            orderNumber += 100;
        }

        public void Delete(int anOrderNumber)
        {
            for (int i = 0; i < orderList.Count; i++) 
            {
                if (anOrderNumber == orderList[i].OrderNumber)//checks if we've found the sought-for product number
                {

                    orderList.Remove(orderList[i]);
                    break;
                }
                if (i == orderList.Count)//if never found product number, it throws an exception.
                {
                    throw new ProductNumberNotFound();
                }
            }
        }

        public void Update(int anOrderNumber, int customerID, int productID)
        {
            Delete(anOrderNumber);
            Order order = new Order(anOrderNumber, customerID, productID);
            orderList.Add(order);
        }

        
        //method that reads out a specific customer's orders
         public Order ReadOrderViaCustomer(int customerID)
         {
            try
            {
                int i;
                for (i = 0; i <orderList.Count; i++)
                {
                    if (orderList[i].customerID == customerID)
                        break;
                }
                   

                Order sale = orderList[i];
                return sale;
            }
             catch
            {
                throw new Exception("No orders for this customer yet");
            }
         }

        //reads out orders of a specific product
        public Order ReadOrderViaProduct(int productID)
        {
           
            try
            {
                int i;
                for (i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].productID == productID)
                        break;
                }


                Order sale = orderList[i];
                return sale;
            }
            catch
            {
                throw new Exception("No orders for this Product yet");
            }
        }


        //Checks for order by input of the order's Id number
        public Order ReadOrderViaOrder(int orderNum)
        {
            try
            {
                int i;
                for (i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].OrderNumber == orderNum)
                        break;
                }


                Order sale = orderList[i];
                return sale;
            }
            catch
            {
                throw new Exception("No such order in our system");
            }
        }



        //returns a copy of the list of all orders
        public List<Order> ReadAll()
        {
            
            if (orderList.Count > 0)
            {
                List<Order> copy_list = orderList.ConvertAll(pro => new Order(pro.OrderNumber, pro.customerID, pro.productID));
                return copy_list;
            }
            else
            {
                throw new Exception("No order yet!");
            }

        }


    }
}
