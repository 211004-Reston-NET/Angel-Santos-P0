/*using System;
using StoreBL;

namespace StoreUI
{
    //The ":" syntax is used to indicate that you will inherit another class, interface, or abstract class
    /// <summary>
    /// Maybe a Login for Admin can be made?
    /// </summary>
    public class StoreAdmin : IMenu
    {

        private IStoreBL _storeBL;
        public StoreAdmin(IStoreBL p_storeBL)
        {
            
        }
     
        public void Menu()
        {
            Console.WriteLine("GPUCity StoreAdmin, select an option from the mainmenu.");
            Console.WriteLine("[1] - Add Customer Credentials. ");
            Console.WriteLine("[2] - Select Store Location.");
            Console.WriteLine("[3] - Check Inventory.");
            Console.WriteLine("[4] - Ship Product.");
            Console.WriteLine("[0] - Exit");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType.SignCustomer;
                case "2":
                    return MenuType.AddStore;
                case "3":
                    return MenuType.ShowProduct;
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
*/