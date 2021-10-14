using System;

namespace StoreUI
{
    public class StoreStock : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the GPU Shop!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[5] - List Customers");
            Console.WriteLine("[4] - Add Customers");
            Console.WriteLine("[3] - Add a Store");
            Console.WriteLine("[2] - Checkout");
            Console.WriteLine("[1] - Buy a Product");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                    return MenuType.ShowCustomer;
                case "4":
                    return MenuType.AddCustomer;
                case "3":
                    return MenuType.AddStore;
                case "2":
                    return MenuType.StoreStock;
                case "1":
                    return MenuType.StoreStock;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreStock;
            }
        }
    }

    
}