//Chani Wachsstock and Shira Laury
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
        const int CREDITCARDNUMBERLENGTH = 16;
        protected static List<Customer> customerList;
        public CustomerDAL()
        {
            customerList = new List<Customer>();//creates list to hold all the customer's information
            Customer aCustomerForTestingPurposes = new Customer("chani", "wachsstock",  222, "Chani N. Wachsstock", "1232321309240918", 2021, 12);
            customerList.Add(aCustomerForTestingPurposes);
        }

        
       
        
        /// <summary>
        /// method that adds a customer's information to a list
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idNum"></param>
        /// <param name="creditCardNum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void Create(string first_name, string last_name, int idNum, string ccName, string creditCardNum, int year, int month)
        {
            if (month <= 12 && creditCardNum.Length==16 && (year <= DateTime.Now.Year + 20 || year >= DateTime.Now.Year)) //check if credit card number is a valid number (16 digits) and if expiration date is valid    
            {
                for (int i = 0; i < customerList.Count; i++) //check if the customer id is already in use
                {
                    if (idNum == customerList[i].ID)
                    {
                        throw new Exception("Customer with this ID already exists.");                     
                    }
                }

                Customer PloniAlmoni = new Customer(first_name, last_name,  idNum, ccName, creditCardNum, year, month);  //create the customer
                customerList.Add(PloniAlmoni); //add him to the list
                
            }
            else if (month>12)
            {
                throw new MonthOutOfRange();
            }
            else if(year < DateTime.Now.Year | year > DateTime.Now.Year+20)
            {
                throw new Exception("Year out of range.");
            }
            else if(creditCardNum.Length!=16)
            {
                throw new CreditCardNumOutOfRange();
            }         
        }
        /// <summary>
        /// method that returns a copy of the customer list
        /// </summary>
        /// <returns></returns>
        
        public List<Customer> ReadAll()
        {
            if (customerList.Count > 0)
            {
                List<Customer> copyOfCustomerList = customerList.ConvertAll(user => new Customer(user.FirstName, user.LastName, user.ID));
                return customerList;

            }
            else
            {
                throw new Exception("No customers recorded.");
            }
        }

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

            Customer customer = new Customer(customerList[index]);
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
        public void Update(string first_name, string last_name,  int idNum, string ccName, string creditCardNum, int year, int month)
        {

            Delete(idNum);
            Create(first_name, last_name, idNum, ccName, creditCardNum, year, month);
           
        }

        
        //method deletes a customer entirely from the list
        public void Delete(int idNum)
        {
            //if(productNum)
            int index = 0;
            //while loop to find id number
            while (customerList[index].ID != idNum)
            {
                if (index < customerList.Count) //checks if the customer is actually in the list
                {
                    index++;
                }
                else
                {
                    throw new Exception("Customer not found.");
                }
            }

            customerList.Remove(customerList[index]);

        }

        



    }
}
