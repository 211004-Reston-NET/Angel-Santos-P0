using System;
using System.Text.RegularExpressions;


namespace StoreModels
{
    public class Product
    {
        
        public string Name {get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nType: {Type}\nPrice: {Price}\nStock: {Stock}";
        }

    }
}


