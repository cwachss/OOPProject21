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
    public class ProductDAL
    {
        //public int NumberOfProducts { get; set; }

        //Shira Laury
        public ProductDAL()
        {
            // NumberOfProducts = 0;
            InitializeList();
        }

        public ProductDAL(int orderConstructorIndicator) //when I call the customerDAL constructor in the order class, I don't want it to re-intiatilize the list or else I will have double of every product
        {

        }

        //create list to hold the product information 
        static List<Product> productList = new List<Product>(); 

        //create StreamReader object to read the list
        StreamReader reader = new StreamReader(@"../../../DAL/ListOfProducts.txt");

        string product;

       

        //method to initialize the list with products' information
        public void InitializeList()
        {
            using (reader)
            {
                for (int i = 0; (product = reader.ReadLine()) != null; i++)
                {
                    string[] orderArray = product.Split(' ');
                    Product aProduct = new Product(int.Parse(orderArray[0]), orderArray[1], decimal.Parse(orderArray[2]), int.Parse(orderArray[3]));
                    productList.Add(aProduct);

                }
            }

          

        }//end initialize list

        //Chani Wachsstock
        //Create method: create a product and add to product list
        public void Create(int prodNum, string prodName, decimal cost, int stock)
        {
            Product product = new Product(prodNum, prodName, cost, stock); //create a product with the info
            for (int i = 0; i < productList.Count; i++) //go through all the products
            {
                if (prodNum == productList[i].ProductNumber) //checks the product id we're trying to add against all the pre-existing ones
                {
                    throw new Exception("Product already exists"); //if it exists, throw an exception
                     
                }
            }

            productList.Add(product);


        }

        //read method: go through list of products to find correct id number and then return that product 
        public Product Read(int productNum)
        {
            //if(productNum)
            int index = 0;
            //while loop to find id number
            while (productList[index].ProductNumber != productNum)
            {
                if (index < productList.Count)
                {
                    index++;
                }
                else
                {
                   throw new ProductNumberNotFound(); //if it's not there, throw an exception
                }
            }

            Product product = new Product(productList[index]);//did you not want to find the index this way? How else should I find it?
            return product;
        }

       

        //returns a copy of the product list.
        public List<Product> ReadAll()
        {
            if (productList.Count > 0)
            {
                List<Product> copyOfList = productList.ConvertAll(pro => new Product(pro.ProductNumber, pro.ProductName,
                    pro.CostPerUnit, pro.AmountInStock)); //send a copy of the list, rather than the actual list

                return copyOfList;
            }
            else
            {
                throw new Exception("No products found");
            }
            
        }




        //update method: receives product number and allows to change product info
        public void Update(int prodNum, string prodName, decimal cost, int stock)
        {
            int i;
            for (i = 0; i < productList.Count; i++)
            {
                if (prodNum == productList[i].ProductNumber)//checks if we've found the sought-for product number
                {
                    Delete(prodNum);//if found does, it executes
                    Create(prodNum, prodName, cost, stock);
                    break;
                }
            }
            if (i == productList.Count)
            {
               throw new ProductNumberNotFound();//if never found product number, it throws an exception.
            }


        }

        //delete method: remove product from product list
        public void Delete(int productNum)
        {
            
            for (int i = 0; i < productList.Count; i++) //I feel like I made this method too unwieldy
            {
                if (productNum == productList[i].ProductNumber)//checks if we've found the sought-for product number
                {
                    
                    productList.Remove(productList[i]);
                    break;
                }
                if (i == productList.Count)//if never found product number, it throws an exception.
                {
                    throw new ProductNumberNotFound();
                }
            }
           
           
        }

            //Thought to make check product number easier by making it a method. But, this may not the way to do it...
            //public int CheckNum(int prodNum)
            //{
            //    int i;
            //    for (i = 0; i < productList.Count; i++) //I feel like I made this method too unwieldy
            //    {
            //        if (prodNum == productList[i].ProductNumber)//checks if we've found the sought-for product number
            //        {
            //            return prodNum;

            //        }
            //    }
            //    if (i == productList.Count)//if never found product number, it throws an exception.
            //    {
            //        throw new ProductNumberNotFound();  
            //    }
            //    return 0;
            //}


        }

    }

