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

        //places an order after checking if all the info is valid
        public void Create(int customerID, int productID, int amountOrdered)
        {

            try
            {
                productBLL.Read(productID); //checks for the existance of the product ordered
                customerBLL.Read(customerID); //checks for the existence of the customer ordering

                Product product = productBLL.Read(productID); //creates a product for checking purposes

                if (product.AmountInStock >= amountOrdered) //checks if there is enough in stock to be ordered
                {
                    productBLL.Update(productID, product.ProductName, product.CostPerUnit, (product.AmountInStock - amountOrdered));
                }
                else
                {
                    throw new ExceptionNotEnoughInStock("Not enough in stock");
                }

                orderDAL.Create(customerID, productID, amountOrdered); //if all checkboxes are checked, place order
            }
            catch (ProductNumberNotFound)
            {
                throw new ProductNumberNotFound();
            }
            catch (CustomerNotFound)
            {
                throw new CustomerNotFound();
            }


        }

        //deletes order from the list and updates the stock
        public void Delete(int orderNum)
        {
            //Waiting for critical updates in the order class
            Order order = orderDAL.ReadOrderViaOrder(orderNum);
        Product product = productBLL.Read(order.ProductID);
        productBLL.Update(product.ProductNumber, product.ProductName, product.CostPerUnit, (product.AmountInStock + order.AmountOrdered));
            orderDAL.Delete(orderNum);
            
           
        }

        //allows modifications of orders- just the amount ordered. otherwise, you have to place a new order completely. seems pretty logical since orders are placed by individual product
        public void Update(int orderNum, int amountToOrder)
        {
            Order order = orderDAL.ReadOrderViaOrder(orderNum);

            Product product = productBLL.Read(order.ProductID);
            int amountDifference = amountToOrder - order.AmountOrdered;

            if (product.AmountInStock >= amountDifference)
            {
            
                productBLL.Update(order.ProductID, product.ProductName, product.CostPerUnit, (product.AmountInStock - amountDifference));
                orderDAL.Update(orderNum, amountToOrder);
                
            }
            else
            {
                throw new Exception("Not enough in stock");
            }

            
        }

        //again, this is just for automating the order number
        public int GetOrderNumber()
        {
            return orderDAL.GetOrderNumber();
        }

      

        //returns orders of a scpecific customer
       public List<Order> ReadOrderViaCustomer(int customerID)
        {
            List<Order> customerOrders = orderDAL.ReadOrderViaCustomer(customerID);

            if (customerOrders.Count == 0)
            {
                throw new ExceptionCustomerHasNoOrders("This customers has no orders yet");
            }
                
            return customerOrders;
        }

        //returns orders of a specific product
        public List<Order> ReadOrderViaProduct(int productID)
        {
            List<Order> productOrders = orderDAL.ReadOrderViaProduct(productID);
            if (productOrders.Count == 0)
            {
                throw new ExceptionProductHasNoOrders("This products has no orders yet");
            }
               
            return productOrders;
           
        }

        //returns a specific order when given its order number
        public Order ReadOrderViaOrderNum(int orderNum)
        { 
                Order orderRequested = orderDAL.ReadOrderViaOrder(orderNum);

                return orderRequested;
           
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
