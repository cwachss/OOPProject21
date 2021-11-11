using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;


namespace DAL
{
    public class ProductDAL
    {
        //Shira Laury
        public ProductDAL()
        {
            InitializeList();
        }

        //create list to hold the product information 
        static List<Product> productList = new List<Product>();

        //create StreamReader object to read the list
        StreamReader reader = new StreamReader("ListOfProducts.txt");
               
        private int number;//variable to hold the number of the product
        private string name;//variable to hold the name of the product
        private decimal price;//variable to hold the price of the product
        private int stock;

       
        protected int index = 0;//variable to hold the index of the list
       
        //method to initialize the list with products' information
        public void InitializeList()
        {

            using (reader)
            {
                
                number = int.Parse(reader.ReadLine());//reads the ID number into the variable number
                name = reader.ReadLine();//reads the name into the variable name
                price = decimal.Parse(reader.ReadLine());//reads the price into the variable price
                stock = int.Parse(reader.ReadLine());//reads the amount in stock

                while (name != null) //read until there are no more entries
                {

                    Product Item = new Product(number, name, price, stock);//creates new Product object 
                    productList.Add(Item);//puts the new object into the List
                    Console.WriteLine(productList[index]);

                    index++;

                    string checkForNull = reader.ReadLine();
                    if (checkForNull == null)
                    {
                        break;
                    }

                    number = int.Parse(checkForNull);//reads the ID number into the variable number
                    name = reader.ReadLine();//reads the name into the variable name
                    price = decimal.Parse(reader.ReadLine());//reads the price into the variable price
                } //end while

            }//close reader

        }//end initialize list

        //Chani Wachsstock
        //Create method: create a product and add to product list
        public void Create(int prodNum, string prodName, decimal cost, int stock)
        {
            Product product = new Product(prodNum, prodName, cost, stock);
            productList.Add(product);
        }

        //read method: go through list of products to find correct id number and then return that product 
        public Product Read(int productNum)
        {
            int index = 0;
            //while loop to find id number
            while (productList[index].ProductNumber != productNum)
            {
                index++;
            }

            Product product = productList[index];
            return product;
        }

        //readall method: return a copy of the product list
        public List<Product> ReadAll()
        {
            List<Product> copyProductList = productList;
            return copyProductList;
        }

        //update method: receives product number and allows to change product info
        public void Update(int prodNum, string prodName, decimal cost, int stock)
        {
            Delete(prodNum);
            Create(prodNum, prodName, cost, stock);

        }

        //delete method: remove product from product list
        public void Delete(int productNum)
        {
            Product product = Read(productNum);
            productList.Remove(product);
        }
    }

}
