using System;
using System.Text.RegularExpressions;

namespace StoreModels

{
    public class Order
    {
        public string LineItems { get; set; }
        public string LocationID { get; set; }
        public float Price { get; set; }
    }
}