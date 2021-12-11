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
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public long CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Charges { get; set; }

        public CreditCard(string first_name,string last_name, long number, DateTime expiration)
        {
            OwnerFirstName = first_name;
            OwnerLastName = last_name;
            CardNumber = number;
            ExpirationDate = expiration;
            Charges = 0;
        }


    }
}
