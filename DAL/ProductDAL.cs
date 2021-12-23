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
        StreamReader reader = new StreamReader(@"../../../../OOPProject21/DAL/ListOfProducts.txt");

        private int number;//variable to hold the number of the product
        private string name;//variable to hold the name of the product
        private decimal price;//variable to hold the price of the product
        private int stock;

        //question: why do we need an index?
        //protected int index = 0;//variable to hold the index of the list *see comment on index below*

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
                                          //NumberOfProducts++;

                    //index++; I like number of products better because index is not really what we care about


                    string checkForNull = reader.ReadLine();
                    if (checkForNull == null)
                    {
                        break;
                    }

                    number = int.Parse(checkForNull);//reads the ID number into the variable number
                    name = reader.ReadLine();//reads the name into the variable name
                    price = decimal.Parse(reader.ReadLine());//reads the price into the variable price
                    stock = int.Parse(reader.ReadLine());//reads the amount in stock
                } //end while

            }//close reader

        }//end initialize list

        //Chani Wachsstock
        //Create method: create a product and add to product list
        public void Create(int prodNum, string prodName, decimal cost, int stock)
        {
            Product product = new Product(prodNum, prodName, cost, stock);
            for (int i = 0; i < productList.Count; i++)
            {
                if (prodNum == productList[i].ProductNumber)
                {
                    throw new Exception("Product already exists");
                     //throw new NumberAlreadyExists();
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
                   throw new ProductNumberNotFound();
                }
            }

            Product product = new Product(productList[index]);//did you not want to find the index this way? How else should I find it?
            return product;
        }

        //readall method: prints out the whole list
        /* public void PrintAll()
        {
            
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i]);
            }
            
        }*/

        //possibly what readall is supposed to:  return a copy of the product list.
        public List<Product> ReadAll()
        {
            if (productList.Count > 0)
            {
                List<Product> copyOfList = productList.ConvertAll(pro => new Product(pro.ProductNumber, pro.ProductName,
                    pro.CostPerUnit, pro.AmountInStock));

                return copyOfList;
            }
            else
            {
                throw new Exception("No products found");
            }
            /* for (int i = 0; i < productList.Count; i++)
             {
             copyOfList.Add(productList[i]);
             }*/
            //test exception
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

