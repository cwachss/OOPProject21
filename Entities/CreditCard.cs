using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CreditCard
    {
        //properties, instance variables im not sure what
        public string OwnerName { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Charges { get; set; }
        public CreditCard(string name, int number, DateTime expiration)
        {
            OwnerName = name;
            CardNumber = number;
            ExpirationDate = expiration;
            
        }
    }
}
