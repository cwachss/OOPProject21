using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace DAL
{
    public class CustomerDAL
    {
       
        public List<Customer> customerList;
        public CustomerDAL()
        {
            customerList = new List<Customer>();//creates list to hold all the customer's information
        }

        /// <summary>
        /// method that adds a customer's information to a list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idNum"></param>
        /// <param name="creditCardNum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void Create(string name, int idNum, long creditCardNum, int year, int month)
        {
            if (month <= 12)
            {
               Customer PloniAlmoni = new Customer(name, idNum, creditCardNum, year, month);//I think is terrible programming since we're storing sensitive information is a unsecured list, but I think this is what we're meant to do... 
                customerList.Add(PloniAlmoni);
            }
            else
            {
                throw new MonthOutOfRange(); //there are more exceptions needed:)
            }

        }
        /// <summary>
        /// method that returns a copy of the customer list
        /// </summary>
        /// <returns></returns>
       /* public List<Customer> ReadAll()
        {
            if (customerList.Count > 0)
            {
                List<Customer> copyOfCustomerList = customerList.ConvertALL(user => new Customer(user.Name, user.ID, user.myCreditCard));
                return customerList;

            }
            else
            {
                throw new Exception("No customers recorded.");
            }
        }*/

        //read method: go through list of products to find correct id number and then return that product 
        public Customer Read(int idNum)
        {
            //if(productNum)
            int index = 0;
            //while loop to find id number
            while (customerList[index].ID != idNum)
            {
                if (index < customerList.Count)
                {
                    index++;
                }
                else
                {
                    throw new Exception("Customer not found.");
                }
            }

            Customer customer = new Customer(customerList[index]);//did you not want to find the index this way? How else should I find it?
            return customer;
        }




        /// <summary>
        /// method that updates a specified customer's information on the customer list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idNum"></param>
        /// <param name="creditCardNum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void Update(string name, int idNum, long creditCardNum, int year, int month)
        {

            Delete(idNum);
            Create(name, idNum, creditCardNum, year, month);
           
        }

        public void Delete(int idNum)
        {
            customerList.Remove(Read(idNum));

        }

        //public int? Find()
        //{
        //    for (int i=0;)
        //}
          




    }
}
