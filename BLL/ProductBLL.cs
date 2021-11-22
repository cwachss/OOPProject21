using Entities;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    class ProductBLL
    {
        ProductDAL product = new ProductDAL();

        public ProductDAL Create(int prodNum, string prodName, decimal cost, int stock)
        {
            
           product.Create(prodNum, prodName, cost, stock);
            return product;

        }

        /// <summary>
        /// Method that Reads a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Read(int productNum)
        {
            
            product.Read(productNum);
            //return product;
        }
        /// <summary>
        /// method that reads all the products
        /// </summary>
        public void ReadAll()
        {
            product.ReadAll();
                
        }

            /// <summary>
            /// Method that Updates a specific product from the list
            /// </summary>
            /// <param name="productNum"></param>
            public void Update(int prodNum, string prodName, decimal cost, int stock)
        {            
            product.Update(prodNum,prodName,cost,stock);
        }

        /// <summary>
        /// Method that Deletes a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Delete(int productNum)
        {
            product.Delete(productNum);
        }

    }
}
