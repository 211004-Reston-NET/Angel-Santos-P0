using System;
using StoreBL;
using StoreModels;



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
            Console.WriteLine("[1] Browse Product Selection");
           // Future Implementation: Console.WriteLine("[2] Add a New Product.");
            Console.WriteLine("[2] Restock Inventory - Select ProductID and Input Amount. ");
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
                //case "2": 
                   // return MenuType.AddPurchaseOrder; 
                case "2":
                    _storeBL.PrintAllProducts();
                    Console.WriteLine("Enter the Product Id and Replenish Inventory");
                    try
                    {
                        int itemId = Int32.Parse(Console.ReadLine());
                        LineItem linFound = _storeBL.GetItemById(itemId);

                        Console.WriteLine("Input how much you want to add to inventory.");
                        int addedInventory = Int32.Parse(Console.ReadLine());
                        _storeBL.ReplenishLineById(linFound, addedInventory);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Please input a number and not a character!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.StoreMenu;
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