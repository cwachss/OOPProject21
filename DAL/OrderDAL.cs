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
                    Order sale1 = new Order(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), int.Parse(array[3]));
                    orderList.Add(sale1);
                    orderNumber++;

                    //What is this? 
                    Console.WriteLine(orderNumber);
                    Console.WriteLine(transaction.CustomerID);
                    Console.WriteLine(transaction.ProductID);
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

        public Order FakeReadByOrderForTestingPurposes(int orderNumber)
        {
            int index = 0;
            //this will be replaced by the read method but not yet
            while (index < orderList.Count)
            {
                if (orderNumber == orderList[index].OrderNumber)
                {
                    break;
                }
                index++;
            }
            //end test method

            Order order = new Order(orderNumber, orderList[index].CustomerID, orderList[index].ProductID, orderList[index].AmountOrdered);
            return order;
        }

        //Can't do more than one type of ReadOne or REadALl because the way the properties are set up
        //no, you can read in a customer id OR productiD and then all you do is check if the order exists based on the ORDER PROPERTIES of customer id and product id- you aren't supposed to be referencing the customer list or product list at all. 
       /* public Order ReadOne(int customerID, int productID)
        {
            if(CheckForCustomer(customerID) && CheckForProduct(productID))
            {

            }
            Order sale = new Order(transaction.OrderNumber, customerID, productID);
            return sale;
        }*/

        
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
       /* public bool CheckForCustomer(int customerID)
        {
            int i;
            for( i=0; i <= (CustomerDAL.customerList).Count; i++)
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
        }*/
    }
}
