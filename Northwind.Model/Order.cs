﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal TotatAmount { get; set; }
    }
}
