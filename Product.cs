using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders_LINQ_App
{
    public class Product
    {
        public int ProductID { get; set; } // Unique identifier for a product
        public string ProductName { get; set; } // Name of the product
        public decimal UnitPrice { get; set; } // Price of a single unit of the product
    }
}
