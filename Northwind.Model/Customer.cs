using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Model
{
    public class Customer
    {
        public int Id  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string city { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
