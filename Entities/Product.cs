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
        public int AmountInStock { get; set; } //fit this into code via textfile

        public Product (int productNumber, string productName, decimal costPerUnit, int amountInStock)
        {
            ProductNumber = productNumber;
            ProductName = productName;
            CostPerUnit = costPerUnit;
            AmountInStock = amountInStock;
        }

        public Product(Product p)//copy constuctor
        {
            ProductName = p.ProductName;
            ProductNumber = p.ProductNumber;
            CostPerUnit = p.CostPerUnit;
            AmountInStock = p.AmountInStock;

        }
        public override string ToString()
        {
            //note to self: format cost as currency

            return $"{ProductNumber} {ProductName} {CostPerUnit}";
        }

        
    }
}
