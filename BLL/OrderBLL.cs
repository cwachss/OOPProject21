using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class OrderBLL
    {
        OrderDAL orderDAL = new OrderDAL();
        public void Create(int customerID, int productID)
        {
            orderDAL.Create(customerID, productID);
            
            
            //I don't know how to change the stock or to add charges to a customer's credit card
        }

        public void Delete(int orderNum)
        {
            orderDAL.Delete(orderNum);
            
            //again, same problem
        }

        public void Update(int orderNum, int customerID, int productID)
        {
            orderDAL.Update(orderNum, customerID, productID);

            //see delete comment
        }

        public Order ReadOne(int customerID, int productID)
        {
            return orderDAL.ReadOne(customerID,productID);//returns a list of one order
        }

        //it's commented b/c DAL method doesn't work
        //public List<Order> ReadAll()
        //{
        //    return orderDAL.ReadALl();//returns list of all order with all their order details
        //}
    }
}
