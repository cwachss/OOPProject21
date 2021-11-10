using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public decimal CostPerUnit { get; set; }

        public Product (int productNumber, string productName, decimal costPerUnit)
        {
            ProductNumber = productNumber;
            ProductName = productName;
            CostPerUnit = costPerUnit;
        }

        public override string ToString()
        {
            //note to self: format cost as currency

            return $"{ProductNumber} {ProductName} {CostPerUnit}";
        }
    }
}
