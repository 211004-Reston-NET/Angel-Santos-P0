using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class ShowStore : IMenu
    {
        private IStoreBL _storeBL;
        public ShowStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Stores");
            List<Store> listOfStores = _storeBL.GetAllStore();

            foreach (Store store in listOfStores)
            {
                Console.WriteLine("====================");
                Console.WriteLine(store);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreStock;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStore;
            }
        }
    }
}
