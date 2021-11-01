using System;
using System.Text.RegularExpressions;


namespace StoreModels
{
    public class Product
    {
        
        public int ProductId { get; set; }
        public string ItemName { get;set; } 
        public string Category { get;set; } 
        public decimal? Price { get;set; } 
        public string Description { get;set; } 
        
        public override string ToString()
        {
            return $"ProductID: {ProductId}\nName: {ItemName}\nCategory:{Category}\nPrice: {Price}\nDescription: {Description}";
        }
    }
}



