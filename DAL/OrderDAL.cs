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
        internal static List<Order> orderList = new List<Order>();
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

        public int GetOrderNumber()
        {
            return orderNumber;
        }

        public void Create(int customerID, int productID, int amountOrdered)
        {

            Order order = new Order(orderNumber, customerID, productID, amountOrdered);
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

        public void Update(int anOrderNumber, int amountOrdered)
        {
            int index = 0;
            //this will be replaced by the read method but not yet
            while (index < orderList.Count)
            {
                if (anOrderNumber == orderList[index].OrderNumber)
                {
                    break;
                }
                index++;
            }
            //end test method
 
            Order order = new Order(anOrderNumber, orderList[index].CustomerID, orderList[index].ProductID, amountOrdered);
            Delete(anOrderNumber);
            orderList.Add(order);
        }

        //public Order FakeReadByOrderForTestingPurposes(int orderNumber)
        //{
        //    int index = 0;
        //    //this will be replaced by the read method but not yet
        //    while (index < orderList.Count)
        //    {
        //        if (orderNumber == orderList[index].OrderNumber)
        //        {
        //            break;
        //        }
        //        index++;
        //    }
        //    //end test method
        //}
        
        //method that reads out a specific customer's orders
         public Order ReadOrderViaCustomer(int customerID)
         {
                int i;
                for (i = 0; i <orderList.Count; i++)
                {
                    if (orderList[i].CustomerID == customerID)
                        break;
                }
                   
                Order sale = orderList[i];
                return sale;
            
            
         }

        //reads out orders of a specific product
        public Order ReadOrderViaProduct(int productID)
        {
           
            int i;
                for (i = 0; i < orderList.Count; i++)
                {
                    if (orderList[i].ProductID == productID)
                        break;
                }


                Order sale = orderList[i];
                return sale;
            
            
        }


        //Checks for order by input of the order's Id number
        public Order ReadOrderViaOrder(int orderNum)
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



        //returns a copy of the list of all orders
        public List<Order> ReadAll()
        {
            
           
                List<Order> copy_list = orderList.ConvertAll(pro => new Order(pro.OrderNumber, pro.CustomerID, pro.ProductID, pro.AmountOrdered));
                return copy_list;
           

        }


    }
}
