using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndOrders_LINQ_App
{
    public class Customer
    {
        public int CustomerID { get; set; } // Unique identifier for a customer
        public string FirstName { get; set; } // First name of the customer
        public string LastName { get; set; } // Last name of the customer
        public string Country { get; set; } // Country where the customer is located
    }
}
