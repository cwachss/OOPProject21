using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class OrderDAL
    {
        internal List<Order> orderList = new List<Order> ();
        int orderNumber = 100;

        Order transaction;
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

        //this does not work... the point is readOne should read in an order number and be able to find the customer and product ids also this just reads in a single predefined order, it doesn't find a specific one...
        public Order ReadOne(int customerID, int productID)
        {
            Order sale = new Order(transaction.OrderNumber, customerID, productID);
            return sale;
        }
        
       /* public List<Order> ReadALl()
        {
            if(orderList.Count > 0)
            {
                List<Order> copy_list = orderList.ConvertAll(user => new Order(transaction.OrderNumber, ));
                return copy_list;
            }
            else
            {
                throw new Exception("No order yet!");
            }
            
        }*/

    }
}
