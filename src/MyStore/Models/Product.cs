using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class Product
    {
        public int ProductID { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
    }
}
