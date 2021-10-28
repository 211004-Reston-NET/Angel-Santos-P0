using System;
using System.Text.RegularExpressions;

namespace StoreModels

{
    public class Order
    {
        public int OrderId { get; set; }
        public int LocationID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }
}