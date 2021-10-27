using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;


namespace UseEntities
{
    /// <summary>
    /// Chani Wachsstock
    /// Program to run all the entities such as products and people
    /// </summary>
    class UseEntitiesMain
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("George", 23423423); //assignment 3 
            Product product1 = new Product(234234, "Banana", 23); //assignment 3

            Person[] personArray = new Person[5]; //initialize array of the people
            StreamReader reader = new StreamReader(@"C:\Users\chani\source\repos\OOPProject\Entities\Input.txt"); //retrieve data from the source

            for (int i = 0; i < personArray.Length; i++)
            {
                /*Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter ID number:");
                int id = int.Parse(Console.ReadLine());*/
                
            
            string name = reader.ReadLine(); //store name in a string (these two lines only work if the file is stored name on one line and ID on the other)
            int id = int.Parse(reader.ReadLine()); //store ID in string
            
           

                personArray[i] = new Person(name, id); //fill spot in array

            }
            reader.Close(); //stop reading things

            for (int i = 0; i < personArray.Length; i++) //print out the array
            {
                Console.WriteLine(personArray[i]); 

            }

           /* StreamReader reader = new StreamReader
                (Contents.txt);

            string fileContents = reader.ReadToEnd();

            Console.WriteLine(fileContents);
            reader.Close();*/
        }
    }
    
}
