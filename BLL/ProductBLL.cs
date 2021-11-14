using Entities;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    class ProductBLL
    {
        ProductDAL product = new ProductDAL();

        public void Create(int prodNum, string prodName, decimal cost, int stock)
        {
            
            product.Create(prodNum, prodName, cost, stock);

        }
        /// <summary>
        /// Method that Reads a specific product from the list
        /// </summary>
        /// <param name="productNum"></param>
        public void Read(int productNum)
        {
            int i = 0;
           
            for(i=0; i<productList.Count;i++)
            {
                if (productNum == productList[i])
                {
                    product.Read();
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
            
            product.ReadAll();
        }

            /// <summary>
            /// Method that Updates a specific product from the list
            /// </summary>
            /// <param name="productNum"></param>
            public void Update(int prodNum, string prodName, decimal cost, int stock)
        {
            int i;
            for(i=0; i< productList.Count;i++)
            {
                if (product.ProductNumber == prodNum)
                    break;
            }
            if (i== productList.Count)
                {
                    throw new ProductNumberOutOfRange();
                }
                    
           
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
