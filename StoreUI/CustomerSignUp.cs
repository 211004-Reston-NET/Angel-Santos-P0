using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class CustomerSignUp : IMenu
    {
        private static Customer _customer = new Customer();
        private IStoreBL _storeBL;
         
        public CustomerSignUp(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine(" Please, add your credentials. ");
            Console.WriteLine("First Name - " + _customer.FirstName);
            Console.WriteLine("Last Name - " + _customer.LastName);
            Console.WriteLine("Street Address - "+ _customer.StreetAddress);
            Console.WriteLine("City - "+ _customer.City);
            Console.WriteLine("State - "+ _customer.State);
            Console.WriteLine("Email - " + _customer.Email);
            Console.WriteLine("Phone Number - " + _customer.PhoneNumber);
            Console.WriteLine("[1] - Input your First Name");
            Console.WriteLine("[2] - Input your Last Name");
            Console.WriteLine("[3] - Input your Street Address");
            Console.WriteLine("[4] - Input value for City");
            Console.WriteLine("[3] - Input value for State");
            Console.WriteLine("[5] - Input Email");
            Console.WriteLine("[6] - Input Phone Number");
            Console.WriteLine("[7] - Submit your completed information.");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
               
                case "1":
                    Console.WriteLine("Type in your First Name.");
                    _customer.FirstName = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "2":
                    Console.WriteLine("Type in your Last Name.");
                    _customer.LastName = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "3":
                    Console.WriteLine("Type in the value for the Street Address.");
                    _customer.StreetAddress = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "4":
                    Console.WriteLine("Type in the value for the City.");
                    _customer.City = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "5":
                    Console.WriteLine("Type in the value for the State.");
                    _customer.State = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "6":
                    Console.WriteLine("Type in the value for the Email.");
                    _customer.Email = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "7":
                    Console.WriteLine("Type in the value for the Phone Number.");
                    _customer.PhoneNumber = Console.ReadLine();
                    return MenuType.SignUpCustomer;
                case "8":
                //'try' block will 'catch' if exception arises, prevents interruption 
                // through exception handling
                    try
                    {
                         _storeBL.CustomerSignUp(_customer);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input value to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.MainMenu;
                    }
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;
            }
        }
    }
}