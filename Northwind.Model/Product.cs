using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal? UnityPrice { get; set; }
        public string Package { get; set; }
        public bool IsDoscontinued { get; set; }

    }
}
