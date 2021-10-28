using System;
using System.Collections.Generic;
using StoreBL;
using StoreModels;


namespace StoreUI
{
    public class GetAllCustomer : IMenu
    {
        private IStoreBL _storeBL;
        public GetAllCustomer(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Customers");
            List<Customer> listOfCustomer = _storeBL.GetAllCustomer();

            foreach (Customer customer in listOfCustomer)
            {
                Console.WriteLine("====================");
                Console.WriteLine(customer);
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
                    return MenuType.GetAllCustomer;
            }
        }
    }
}

