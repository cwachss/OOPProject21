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

        public CustomerBLL()
        {
            misterA = new CustomerDAL();
        }
        public CustomerBLL(int orderConstructorIndicator) //when I call the customerDAL constructor in the order class, I don't want it to re-intiatilize the list or else I will have double of every customer (in the end, we didn't initialize a list of customers so it doesn't matter. But if we did, this would be a problem).
        {
            misterA = new CustomerDAL(1);
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
            misterA.Delete(idNum);
        }

       



    }
}
