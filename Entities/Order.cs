using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        //int customerID;
        //int productID;

        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int OrderNumber { get; set; }
        public int AmountOrdered { get; set; }

        public Order(int orderNumber, int cID, int pID, int amount)
        {
            OrderNumber = orderNumber;
            CustomerID = cID;
            ProductID = pID;
            AmountOrdered = amount;
        }

        public override string ToString() => $"Order Number: {OrderNumber}\tCustomerID: {CustomerID}\tProductID: {ProductID}\t{AmountOrdered}";
        

    }
}
