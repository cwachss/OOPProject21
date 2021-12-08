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
        CustomerDAL misterA = new CustomerDAL();//creates generic customer to use


        /// <summary>
        /// method that adds a customer's information to the list in the BLL 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="idNum"></param>
        /// <param name="creditCardNum"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public CustomerDAL Create(string name, int idNum, int creditCardNum, int year, int month)
        {
            misterA.Create(name,idNum,creditCardNum,year,month);
            return misterA;
        }

        /// <summary> 
        /// method that returns the list of customers and their information in the BLL
        /// </summary>
        /// <returns></returns>
        //public List<Customer> ReadAll()
        //{
        //    return misterA.ReadAll();
        //}


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
        public void Update(string name, int idNum, long creditCardNum, int year, int month)
        
        {
            misterA.Update(name, idNum, creditCardNum, year, month);
        }

        public void Delete(int idNum)
        {
            misterA.Delete(idNum);
        }





    }
}
