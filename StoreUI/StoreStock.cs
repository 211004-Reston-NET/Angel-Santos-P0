using System;

namespace StoreUI
{
    public class StoreStock : IMenu
    {
        public void Menu()
///
/// Reads into Main Menu. Change this Interface to Products after Main Menu has Admin. 
        {
            Console.WriteLine("GPU City, where GPUs grow on trees! :D");
            Console.WriteLine("[1] Browse our GPU cornucopia!");
            Console.WriteLine("[2] - Checkout");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.ShowProduct;
                case "2":
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