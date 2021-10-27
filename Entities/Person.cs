using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return $"{Name} {ID}";

        }
    }
}
