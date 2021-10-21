using System;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to GPUCity! Please, select an option from the mainmenu.");
            Console.WriteLine("[0] - Admin - Store Manager");
            Console.WriteLine("[1] - Create an Account ");
            Console.WriteLine("[2] - Select Store Location.");
            Console.WriteLine("[3] - Enter our store page.");
            Console.WriteLine("[4] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.StoreAdmin;
                case "1":
                    return MenuType.SignCustomer;
                case "2":
                    return MenuType.AddStore;
                case "3":
                    return MenuType.StoreMenu;
                case "4":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}