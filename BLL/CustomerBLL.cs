//Chani Wachsstock and Shira Laury
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL misterA;
        OrderBLL orderBLL;
        public CustomerBLL()
        {
            misterA = new CustomerDAL();
            orderBLL = new OrderBLL(0);
        }
       
        /// <summary>
        /// method that adds a customer's information to the list in the DAL
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="idNum"></param>
        /// <param name="creditCardNum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public void Create(string first_name, string last_name, string ccName, int idNum, string creditCardNum, int year, int month)
        {
            misterA.Create(first_name, last_name, idNum, ccName, creditCardNum, year, month);
            
        }

        /// <summary> 
        /// method that returns ac copy of a list of customers and their information from the DAL
        /// </summary>
        /// <returns></returns>
        public List<Customer> ReadAll()
        {
            misterA.ReadAll();
            return misterA.ReadAll();

        }

        //returns a copy of the customer
        public Customer Read(int idNum)
        {
           return misterA.Read(idNum);
        }


        /// <summary>
        /// method that updates a specified customer's information
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idNum"></param>
        /// <param name="creditCardNum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void Update(string first_name, string last_name, int idNum,  string ccName, string creditCardNum, int year, int month)
        
        {
            misterA.Update(first_name, last_name, idNum, ccName, creditCardNum, year, month);
        }

        //deletes a customer from the list
        public void Delete(int idNum)
        {

            List<Order> customerOrders = orderBLL.ReadOrderViaCustomer(idNum);

            for (int i = 0; i < customerOrders.Count; i++)
            {
                orderBLL.Delete(customerOrders[i].OrderNumber);
            }

            misterA.Delete(idNum);
        }

       



    }
}
