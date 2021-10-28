using System;
using System.Text.RegularExpressions;

namespace StoreModels
{
    public class LineItem
    {   public int LocationId   { get; set; }
        public int ProductID    { get; set; }
        public string ItemName { get; set; }
        public int Inventory    { get; set; }
        public decimal Price    {  get; set; }
        
    }    
}

