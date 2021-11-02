using System;
using StoreBL;
using System.Linq;
using Entity = StoreDL.Entities;
using Microsoft.Data.SqlClient;



namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private IStoreBL _storeBL;
        public StoreMenu(IStoreBL p_storeBL)
        {
             _storeBL = p_storeBL;
        }
         
       
        
        
        
        
        public void Menu()

/// Reads into Main Menu. Change this Interface to Products after Main Menu has Admin. 
        {   
            Console.WriteLine("[1] Browse our cyberware!");
            Console.WriteLine("[2] -WIP- Place an item to your cart.");
            Console.WriteLine("[3] -WIP- Checkout");
            Console.WriteLine("[4] Replenish inventory ");
            //by 5 - ItemId:1 ");
            Console.WriteLine("[0] - Go to MainMenu");
        }
        
        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                _storeBL.PrintAllProducts();
                
                Console.WriteLine("====================");
                Console.WriteLine("Press Enter to return to Store Menu options.");
                Console.ReadLine();
                return MenuType.StoreMenu;
                case "2": 
                    return MenuType.AddPurchaseOrder; 
                case "3":
                    return MenuType.StoreMenu;
                case "4":
                    try 
                    { 
                    
                    }
                    catch (Exception)
                    {

                    }
                    return MenuType.StoreMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}