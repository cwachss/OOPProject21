using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        int customerID;
        int productID;
        public int OrderNumber { get; set; }

        public Order(int orderNumber, int cID, int pID)
        {
            OrderNumber = orderNumber;
            customerID = cID;
            productID = pID;
        }

    }
}
