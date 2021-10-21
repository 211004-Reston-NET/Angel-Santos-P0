/*
using System;
using System.Collections.Generic;
using System.Linq;
using StoreModels;
using StoreBL;

namespace StoreUI
{
    public class Cart : IMenu
    {
        private IStoreBL _storeBL;
        public Cart(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        internal Cart()
        {
            return;
        }
        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<Product> listOfProduct = _storeBL.GetAllProduct();
            

            foreach (Product product in listOfProduct)
            {
                Console.WriteLine("====================");
                Console.WriteLine(product);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }
        
    }
}
*/