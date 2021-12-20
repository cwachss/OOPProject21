//Chani Wachsstock and Shira Laury
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CreditCard
    {
        //properties, instance variables I'm not sure what
        public string Name { get; set; }
       
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Charges { get; set; }

        public CreditCard(string name, string number, DateTime expiration)
        {
            Name = name;
            CardNumber = number;
            ExpirationDate = expiration;
            Charges = 0;
        }


    }
}
