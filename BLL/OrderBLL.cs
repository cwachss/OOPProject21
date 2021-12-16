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
            productDAL.
            
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
    }
}
