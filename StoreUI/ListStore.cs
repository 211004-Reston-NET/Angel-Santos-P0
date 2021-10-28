using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;


namespace StoreUI
{
    public class ShowStore : IMenu
    {
        private IStoreBL _storeBL;
        public static string _findProdName;
        public ShowStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Stores");
            List<StoreFront> listOfStores = _storeBL.GetAllStore();

            foreach (StoreFront store in listOfStores)
            {
                Console.WriteLine("====================");
                Console.WriteLine(store);
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
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStore;
            }
        }
    }
}
