/*using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class AddPurchaseOrder : IMenu
    {

        //PurchaseOrder - Entity
        private static PurchaseOrder _order = new PurchaseOrder();
        private IStoreBL _storeBL;
         
        public AddPurchaseOrder(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine(" Select an Item(ID) you wish to purchase. ");
            Console.WriteLine("Order ID: " + _order.OrderId);
            Console.WriteLine("Store Location ID: " + _order.LocationId);
            Console.WriteLine("Customer ID: " + _order.CustomerId);
            Console.WriteLine("Item Name: " + _order.ItemName);
            Console.WriteLine("Price: " + _order.Price);
            Console.WriteLine("[1] - Input Order ID");
            Console.WriteLine("[2] - Input Store Location ID");
            Console.WriteLine("[3] - Input Item Name");
            Console.WriteLine("[4] - Input Customer ID");
            Console.WriteLine("[5] - Input Price");
            Console.WriteLine("[6] - Submit completed information.");
            Console.WriteLine("[6] - List all Products.");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Type in your Order ID.");
                    try
                    {
                         _order.OrderId = Int32.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must use only numbers.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddPurchaseOrder;
                    }

                    return MenuType.AddPurchaseOrder;
                case "2":
                    Console.WriteLine("Type in Location ID.");
                    try
                    {
                    _order.LocationId = Int32.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must use only numbers.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddPurchaseOrder;
                    }

                    return MenuType.AddPurchaseOrder;
                case "3":
                    Console.WriteLine("Type in the Item Name.");
                    try
                    {
                    _order.ItemName = Console.ReadLine();
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must enter only letters.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddPurchaseOrder;
                    }
                    
                    return MenuType.AddPurchaseOrder;
                case "4":
                    
                    Console.WriteLine("Type in the Total Price.");
                    try
                    {
                    _order.Price = Int32.Parse(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must enter only numbers.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddPurchaseOrder;
                    }

                    return MenuType.AddPurchaseOrder;
                case "5":
                //'try' block will 'catch' if exception arises, prevents interruption 
                // through exception handling
                    try
                    {
                         _storeBL.AddPurchaseOrder(_order);
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("You must input values to all fields above");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return MenuType.AddPurchaseOrder;
                    }

                    return MenuType.StoreMenu;
               
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddPurchaseOrder;
            }
        }
    }
}
*/