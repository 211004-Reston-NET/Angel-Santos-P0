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
        public decimal? Price { get;set; } 
        public string Description { get;set; } 
        
        public override string ToString()
        {
            return $"Name: {Name}\nCategory:{Category}\nPrice: {Price}\nDescription: {Description}";
        }
    }
}



