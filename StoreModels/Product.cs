using System;
using System.Text.RegularExpressions;


namespace StoreModels
{
    public class Product
    {
        private string _name;
        private string _type;
        private string _price;
        private string _description;
        

        public int ProductId { get; set; }
        public string Name { get;set; } 
        public string Category { get;set; } 
        public decimal Price { get;set; } 
        public string Description { get;set; } 

    }
}



