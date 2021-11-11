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


        public void Read()
        {
            ProductDAL 
            Console.WriteLine();
        }
    }
}
