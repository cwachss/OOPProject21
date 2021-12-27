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

        ProductBLL productBLL = new ProductBLL(0); //calls constructor that does not reinitialize list
        CustomerBLL customerBLL = new CustomerBLL();
        OrderDAL orderDAL = new OrderDAL();


        public void Create(int customerID, int productID, int amountOrdered)
        {

            try
            {
                productBLL.Read(productID);
                customerBLL.Read(customerID);


                orderDAL.Create(customerID, productID, amountOrdered);
            }
            catch
            {
                throw new Exception("Incorrect input");
            }

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

        public void Delete(int orderNum)
        {
            //Waiting for critical updates in the order class
            Order order = orderDAL.ReadOrderViaOrder(orderNum);
        Product product = productBLL.Read(order.ProductID);
        productBLL.Update(product.ProductNumber, product.ProductName, product.CostPerUnit, (product.AmountInStock + order.AmountOrdered));
            orderDAL.Delete(orderNum);
            
            //again, same problem
        }

        public void Update(int orderNum, int amountOrdered)
        {
            Order order = orderDAL.ReadOrderViaOrder(orderNum);

            Product product = productBLL.Read(order.ProductID);

            if (product.AmountInStock >= amountOrdered)
            {
                orderDAL.Update(orderNum, amountOrdered);
                productBLL.Update(order.ProductID, product.ProductName, product.CostPerUnit, (product.AmountInStock - amountOrdered));
            }
            else
            {
                throw new Exception("Not enough in stock");
            }

            
        }

        public int GetOrderNumber()
        {
            return orderDAL.GetOrderNumber();
        }

      

        //returns orders of a scpecific customer
       public Order ReadOrderViaCustomer(int customerID)
        {
                int i;
                for (i = 0; i < orderDAL.ReadAll().Count; i++)
                {
                    if (orderDAL.ReadAll()[i].CustomerID == customerID)
                        return orderDAL.ReadOrderViaCustomer(customerID);
                }
                if (i == orderDAL.ReadAll().Count)
                    throw new Exception("This customers has no orders yet");
            return null;
        }

        //returns orders of a specif product
        public Order ReadOrderViaProduct(int productID)
        {
            int i;
            for (i = 0; i < orderDAL.ReadAll().Count; i++)
            {
                if (orderDAL.ReadAll()[i].ProductID == productID)
                    return orderDAL.ReadOrderViaProduct(productID);
            }
            if (i == orderDAL.ReadAll().Count)
                throw new Exception("This products has no orders yet");
            return null;
           
        }

        //returns a specific order when given its order number
        public Order ReadOrderViaOrderNum(int orderNum)
        {
            int i;
            for (i = 0; i < orderDAL.ReadAll().Count; i++)
            {
                if (orderDAL.ReadAll()[i].OrderNumber == orderNum)
                    return orderDAL.ReadOrderViaOrder(orderNum);
            }
            if (i == orderDAL.ReadAll().Count)
                throw new Exception("Invalid order number");
            return null;
           
        }

        public List<Order> ReadAll()
        {
            if (orderDAL.ReadAll().Count != 0)
                return orderDAL.ReadAll();
            else
                throw new Exception("No orders yet.");
        }
    }
}
