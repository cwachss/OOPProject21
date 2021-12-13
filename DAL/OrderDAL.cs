using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    class OrderDAL
    {
        List<Order> orderList = new List<Order> ();
        int orderNumber = 100;


        public void AddOrder(int customerID, int productID)
        {
            Order order = new Order(orderNumber, customerID, productID);
            orderList.Add(order);
            orderNumber += 100;
        }


    }
}
