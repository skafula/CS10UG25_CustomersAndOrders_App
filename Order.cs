using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders_LINQ_App
{
    public class Order
    {
        public int OrderID { get; set; } // Unique identifier for an order
        public int CustomerID { get; set; } // Identifier for the customer who placed the order
        public DateTime OrderDate { get; set; } // Date on which the order was placed
        public DateTime? ShippedDate { get; set; } // Date on which the order was shipped, nullable
    }
}
