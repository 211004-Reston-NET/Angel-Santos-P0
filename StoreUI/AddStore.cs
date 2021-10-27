using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddStore : IMenu
    {
        private static StoreFront _store = new StoreFront();
        private IStoreBL _storeBL;
         
        public AddStore(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new Store");
            Console.WriteLine("Name - " + _store.Name);
            Console.WriteLine("State - "+ _store.State);
            Console.WriteLine("City - "+ _store.City);
            //Console.WriteLine("[4] - Add Store");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for State");
            Console.WriteLine("[1] - Input value for City");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "":
                    //Add implementation to talk to the repository method to add a store
                    _storeBL.AddStore(_store);
                    return MenuType.StoreMenu;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _store.Name = Console.ReadLine();
                    return MenuType.AddStore;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _store.State = Console.ReadLine();
                    return MenuType.AddStore;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _store.City = Console.ReadLine();
                    return MenuType.AddStore;
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
