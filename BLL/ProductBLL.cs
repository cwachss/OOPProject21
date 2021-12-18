//Chani Wachsstock and Shira Laury
using Entities;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        internal ProductDAL productDAL = new ProductDAL();

        public ProductDAL Create(int prodNum, string prodName, decimal cost, int stock)
        {
            
           productDAL.Create(prodNum, prodName, cost, stock);
            return productDAL;

        }

        /// <summary>
        /// Method that Reads a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public Product Read(int productNum)
        {
            
                return productDAL.Read(productNum);
            
         
               
        }
        /// <summary>
        /// method that reads all the products
        /// </summary>
        public List<Product> ReadAll()
        {
            
            return productDAL.ReadAll();
        }

            /// <summary>
            /// Method that Updates a specific product from the list
            /// </summary>
            /// <param name="productNum"></param>
        public void Update(int prodNum, string prodName, decimal cost, int stock)
        {
                productDAL.Update(prodNum, prodName, cost, stock);
           
        }

        /// <summary>
        /// Method that Deletes a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Delete(int productNum)
        {
              productDAL.Delete(productNum);
           
            
        }

    }
}
