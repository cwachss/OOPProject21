//Chani Wachsstock and Shira Laury

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Person(string first_name, string last_name, int id)
        {
            FirstName = first_name;
            LastName=last_name;
            ID = id;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {ID}";

        }
    }
}
