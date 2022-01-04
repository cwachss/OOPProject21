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
       
        protected int orderNumber = 103;
        internal static List<Order> orderList = new List<Order>();


        public OrderDAL()
        {
            InitilizeList();
        }

        //method to initialize a list of orders
        public void InitilizeList()
        {
            StreamReader reader = new StreamReader(@"../../../DAL/ListOfOrders.txt");
            string line;
            using (reader)
            {
                for (int i = 0; (line = reader.ReadLine()) != null; i++)
                {
                    string[] orderArray = line.Split(' ');
                    Order sale1 = new Order(int.Parse(orderArray[0]), int.Parse(orderArray[1]), int.Parse(orderArray[2]), int.Parse(orderArray[3]));
                    orderList.Add(sale1);

                }
            }
        }

        //this is just so the visuals can access this relatively unimportant and arbitrary order number. it doesn't really matter, it just makes our visual neater with this lovely generated order number..
        public int GetOrderNumber()
        {
            return orderNumber;
        }

        //method to place an order
        public void Create(int customerID, int productID, int amountOrdered)
        {
            //no need to exception handle- order number is predefined and all other exceptions are dealt with in the BLL
            Order order = new Order(orderNumber, customerID, productID, amountOrdered);
            orderList.Add(order);
            orderNumber += 1;
        }

        //deletes an order from the system 
        public void Delete(int anOrderNumber)
        {
            for (int i = 0; i < orderList.Count; i++)
            {
                if (anOrderNumber == orderList[i].OrderNumber)//checks if we've found the sought-for product number
                {

                    orderList.Remove(orderList[i]);
                    break;
                }
                //if (i == orderList.Count)//if never found product number, it throws an exception.
                //{
                //    throw new ProductNumberNotFound();
                //}//This is unnecassy for our current UI setup. We're keeping this to be used if needed another time.
            }
        }

        public void Update(int anOrderNumber, int amountOrdered)
        {
                Order pastOrder = ReadOrderViaOrder(anOrderNumber);

                Order order = new Order(anOrderNumber, pastOrder.CustomerID, pastOrder.ProductID, amountOrdered);
                Delete(anOrderNumber);
                orderList.Add(order);
        }

        

        //method that reads out a specific customer's orders
        public List<Order> ReadOrderViaCustomer(int customerID)
        {
            List<Order> customerOrders = new List<Order>();

            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].CustomerID == customerID)
                {
                    Order customerOrder = new Order(orderList[i].OrderNumber, orderList[i].CustomerID, orderList[i].ProductID, orderList[i].AmountOrdered);
                    customerOrders.Add(customerOrder);
                }
            }
            return customerOrders;
        }

        //reads out orders of a specific product
        public List<Order> ReadOrderViaProduct(int productID)
        {
            List<Order> productOrders = new List<Order>();
           

            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].ProductID == productID)
                {
                    Order productOrder = new Order(orderList[i].OrderNumber, orderList[i].CustomerID, orderList[i].ProductID, orderList[i].AmountOrdered);
                    productOrders.Add(productOrder);
                }
                
            }
            return productOrders;

        }


        //Checks for order by input of the order's Id number
        public Order ReadOrderViaOrder(int orderNum)
        {

            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].OrderNumber == orderNum)
                {
                    Order sale = new Order(orderList[i].OrderNumber, orderList[i].CustomerID, orderList[i].ProductID, orderList[i].AmountOrdered);
                    return sale;
                }
                
                
            }
            throw new ExceptionOrderNumInvalid ();
        }



        //returns a copy of the list of all orders
        public List<Order> ReadAll()
        {


            List<Order> copy_list = orderList.ConvertAll(pro => new Order(pro.OrderNumber, pro.CustomerID, pro.ProductID, pro.AmountOrdered));
            return copy_list;


        }


    }
}