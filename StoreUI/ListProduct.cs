using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;


namespace StoreUI
{
    public class ListProduct : IMenu
    {
        private IStoreBL _storeBL;
        public static string _findProdName;
        
        public ListProduct(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Products");
            List<Product> listOfProduct = _storeBL.GetAllProduct();
            

            foreach (Product prod in listOfProduct)
            {
                Console.WriteLine("====================");
                Console.WriteLine(prod);
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
                    return MenuType.StoreMenu;
                case "1":
                    Console.WriteLine("Enter a name for the Product");
                    _findProdName = Console.ReadLine();
                    return MenuType.QueryProduct;
                
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ListProduct;
            }
        }
    }
}

