using Entities;
using System.Collections.Generic;
using System.Linq;
using DAL;

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
            int i = 0;
            ProductDAL product2 = new ProductDAL(productNum);
            for(i=0; i<productList.Count;i++)
            {
                if (productNum == productList[i])
                {
                    product2.Read();
                }
                else counter++; 
               
            }
            if (i == productList.Count)
            {
                throw new ProductNumberOutOfRange();
            }
                

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
            ProductDAL product4 = new DAL.ProductDAL();

            int i;
            for(i=0; i< productList.Count;i++)
            {
                if (product4.ProductNumber == prodNum)
                    break;
            }
            if (i== productList.Count)
                {
                    throw new ProductNumberOutOfRange();
                }
                    
           
            product2.Update(prodNum);
        }

        /// <summary>
        /// Method that Deletes a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Delete(int productNum)
        {
            ProductDAL product5 = new DAL.ProductDAL(p);
            product3.Delete;
        }

    }
}
