using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddCustomer : IMenu
    {
        private static Store _store = new Store();
        private IStoreBL _storeBL;
         
        public AddCustomer(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding new Customer credentials.");
            Console.WriteLine("Name - " + _customer.Name);
            Console.WriteLine("State - "+ _customer.State);
            Console.WriteLine("City - "+ _customer.City);
            Console.WriteLine("[4] - Add Username.");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for State");
            Console.WriteLine("[1] - Input value for City");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                    //Add implementation to talk to the repository method to add a restaurant
                    _storeBL.AddCustomer(_customer);
                    return MenuType.StoreStock;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _store.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _store.State = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _store.City = Console.ReadLine();
                    return MenuType.AddCustomer;
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
