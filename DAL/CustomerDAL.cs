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
       
        protected static List<Customer> customerList { get; set; }
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
            if (month <= 12 && creditCardNum.Length==16 && (year <= DateTime.Now.Year + 20 || year >= DateTime.Now.Year))
            {
                for (int i = 0; i < customerList.Count; i++)
                {
                    if (idNum == customerList[i].ID)
                    {
                        throw new Exception("Customer with this ID already exists.");                     
                    }
                }

                Customer PloniAlmoni = new Customer(first_name, last_name,  idNum, ccName, creditCardNum, year, month);//I think is terrible programming since we're storing sensitive information is a unsecured list, but I think this is what we're meant to do... 
                customerList.Add(PloniAlmoni);
                
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
        public void Update(string first_name, string last_name,  int idNum, string ccName, string creditCardNum, int year, int month)
        {

            Delete(idNum);
            Create(first_name, last_name, idNum, ccName, creditCardNum, year, month);
           
        }

        

        public void Delete(int idNum)
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

            customerList.Remove(customerList[index]);

        }

        //public override string ToString()
        //{

        //    return $"{FirstName}{LastName}{ID}{CreditCardNum}";
        //}
          
        //public void InitializeList()
        //{
        //    StreamReader reader = new StreamReader(@"..\..\customerList.txt");
        //    string line;
        //    using (reader)
        //    {
        //        for (int i = 0; (line = reader.ReadLine()) != null; i++)
        //        {
        //            string[] array = line.Split(' ');

        //            Customer soAndSo = new Customer(array[0], array[1], int.Parse(array[2]), array[3], array[4], int.Parse(array[5]), int.Parse(array[6]));
        //            customerList.Add(soAndSo);
        //            //input all info into list, then whenever you add use StreamWriter
        //        }
        //    }
        //}



    }
}
