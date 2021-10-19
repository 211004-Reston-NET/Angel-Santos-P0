using System;
using System.Text.RegularExpressions;


namespace StoreModels
{
    public class Product
    {
        
        public string Name {get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nType: {Type}\nPrice: {Price}\nStock: {Stock}";
        }

    }
}


