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
        private Order transaction;

        public void InitilizeList()
        {
            StreamReader reader = new StreamReader(@"../../bin/debug/ListOfOrders.txt");
            string line;
            using(reader)
            {
                for (int i = 0; (line = reader.ReadLine()) != null; i++)
                {
                    string [] array =line.Split(' ');
                    Order sale1 = new Order(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]));
                    orderList.Add(sale1);
                    Console.WriteLine(orderNumber);
                    Console.WriteLine(transaction.customerID);
                    Console.WriteLine(transaction.productID);
                }

                //while(orderNumber!=0)
                //{

                //    Order sale1 = new Order(orderNumber, transaction.customerID, transaction.productID);
                //    orderList.Add(sale1);

                //   // string checkForNull=reader.ReadLine();
                //    //if (checkForNull != null)
                //    //    break;
                //    orderNumber=int.Parse(reader.ReadLine());
                //    transaction.customerID=int.Parse(reader.ReadLine());
                //    transaction.productID=int.Parse(reader.ReadLine());

                    
                //}
            }
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

        //Can't do more than one type of ReadOne or REadALl because the way the properties are set up
        public Order ReadOne(int customerID, int productID)
        {
            if(CheckForCustomer(customerID) && CheckForProduct(productID))
            {

            }
            Order sale = new Order(transaction.OrderNumber, customerID, productID);
            return sale;
        }

        
        //public List<Order> ReadALl()
        //{
        //    if(orderList.Count > 0)
        //    {
        //        List<Order> copy_list = orderList.ConvertAll(user => new Order(transaction.OrderNumber,  ));
        //        return copy_list;
        //    }
        //    else
        //    {
        //        throw new Exception("No order yet!");
        //    }
            
        //}

        //this is an idea that I have: to make the customerId and productId be anything that the user wants to enter -and then we check it for validity 
        private bool CheckForCustomer(int customerID)
        {
            int i;
            for( i=0; i<=CustomerDAL.customerList.Count; i++)
            {
                if ((CustomerDAL.customerList[i]).ID==customerID)
                {
                    return true;
                }
            }
            if (i > CustomerDAL.customerList.Count)
                return false;
            else
                return false;
        }

        private bool CheckForProduct(int productID)
        {
            return false;//same as above
        }
    }
}
