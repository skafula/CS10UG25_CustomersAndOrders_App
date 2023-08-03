using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders_LINQ_App
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Unique identifier for an order detail
        public int OrderID { get; set; } // Identifier for the order to which the detail belongs
        public int ProductID { get; set; } // Identifier for the product in the order detail
        public int Quantity { get; set; } // Number of units of the product ordered
        public decimal Discount { get; set; } // Discount applied to the product in the order detail

    }
}
