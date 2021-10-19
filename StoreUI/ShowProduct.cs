using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class ShowProduct : IMenu
    {
        private IStoreBL _storeBL;
        public ShowProduct(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
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

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowProduct;
            }
        }
    }
}

