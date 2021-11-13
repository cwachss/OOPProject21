using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    class ProductBLL 
    {

        public void Create(int prodNum, string prodName, decimal cost, int stock)
        {
            ProductDAL product = new ProductDAL();
            product.Create(prodNum, prodName, cost, stock);
        }
        /// <summary>
        /// Method that Reads a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Read(int productNum)
        {
            ProductDAL product2 = new ProductDAL(productNum);
            for(int i=0; i< productList.Count)
            if (productNum!=productList.)
            product2.Read();

        }

        public List<Product> ReadAll()
        {
            ProductDAL product3 = new ProductDAL();
            product3.ReadAll;
        }

            /// <summary>
            /// Method that Updates a specific product from the list
            /// </summary>
            /// <param name="productNum"></param>
            public void Update(int prodNum, string prodName, decimal cost, int stock)
        {
            ProductDAL product4 = new DAL.ProductDAL(prodNum, prodName, cost, stock);
            product2.Update();
        }

        /// <summary>
        /// Method that Deletes a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Delete(int productNum)
        {
            ProductDAL product5 = new DAL.ProductDAL(productNum);
            product3.Delete;
        }

    }
}
