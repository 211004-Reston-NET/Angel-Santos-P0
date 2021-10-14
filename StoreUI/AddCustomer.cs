using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddCustomer : IMenu
    {
        private static Customer _customer = new Customer();
        private IStoreBL _storeBL;
         
        public AddCustomer(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding new Customer credentials.");
            Console.WriteLine("Username - " + _customer.Username);
            Console.WriteLine("Name - " + _customer.Name);
            Console.WriteLine("State - "+ _customer.State);
            Console.WriteLine("City - "+ _customer.City);
            Console.WriteLine("[5] - Finish adding Customer");
            Console.WriteLine("[4] - Input Username");
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
                case "5":
                    //Anything inside the try block will be catched if an exception has risen
                    //Laymen's term if a problem has happened while doing this code, it will instead do the catch block
                    try
                    {
                         _storeBL.AddCustomer(_customer);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddCustomer;
                    }
                    
                    return MenuType.StoreStock;
                case "4":
                    Console.WriteLine("Type in the value for the Username");
                    _customer.Username = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "3":
                    Console.WriteLine("Type in the value for the Name");
                    _customer.Name = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the value for the State");
                    _customer.State = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the City");
                    _customer.City = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.StoreStock;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;
            }
        }
    }
}
