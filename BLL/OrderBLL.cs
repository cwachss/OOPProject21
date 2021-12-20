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
        
        ProductBLL productBLL = new ProductBLL();
        OrderDAL orderDAL = new OrderDAL();


        public void Create(int customerID, int productID, int amountOrdered)
        {

            orderDAL.Create(customerID, productID);
            Product product = productBLL.Read(productID);

            if(product.AmountInStock >= amountOrdered)
            {
                productBLL.Update(productID, product.ProductName, product.CostPerUnit, (product.AmountInStock - amountOrdered));
            }
            else
            {
                throw new Exception("Not enough in stock");
            }
            
        }

        public void Delete(int orderNum)
        {
           /* Waiting for critical updates in the order class
            * Order order = orderDAL.ReadOne(orderNum);
            Product product = productBLL.Read(order.productID);
            productBLL.Update(order.productID, product.ProductName, product.CostPerUnit, (product.AmountInStock + amountOrdered));*/
            orderDAL.Delete(orderNum);
            
            //again, same problem
        }

        public void Update(int orderNum, int customerID, int productID, int amountOrdered)
        {
            orderDAL.Update(orderNum, customerID, productID);

            Product product = productBLL.Read(productID);

            if (product.AmountInStock >= amountOrdered)
            {
                productBLL.Update(productID, product.ProductName, product.CostPerUnit, (product.AmountInStock - amountOrdered));
            }
            else
            {
                throw new Exception("Not enough in stock");
            }

            
        }

       /* public Order ReadOne(int customerID, int productID)
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
