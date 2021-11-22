using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class BLLTest
    {
        static void Main(string[] args)
        {
            //Shira Laury
            try
            {
                ProductBLL obj = new ProductBLL();
                
                obj.Delete(19238);
                obj.Update(98342, "fishing rod", (decimal)45.65, 32);
                obj.ReadAll();
                obj.Read(19238);
            }
            catch(ProductNumberNotFound numOut)
            {
                Console.WriteLine(numOut.Message); 
                
            }
            //catch()


            //Chani Wachsstock
            try
            {
                ProductBLL products = new ProductBLL();
                products.Create(19387, "ballie", (decimal)32.00, 98);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops... That product already exists");
            }
        }
    }
}
