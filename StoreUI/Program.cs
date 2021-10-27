﻿using System;
using StoreBL;
using StoreDL;


namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a boolean that has either a false or true value
            //I will use this to stop the while loop
            bool repeat = true;


            //This is example of polymorphism, abstraction, and inheritance all at the same time
            IMenu page = new MainMenu();

            //This is a while loop that will keep repeating until I changed the
            //repeat variable to false
            while (repeat)
            {
                //Clean the screen on the terminal
                Console.Clear();

                //IMenu interface can hold a bunch of objects as long as they inherited from
                //IMenu, this lets us dynamically change the page by having the page variable
                //Point to a different object each time
                page.Menu();
                MenuType currentPage = page.UserChoice();

                //switch case will change the page variable to point to another object to change
                //its MainMenu 
                switch (currentPage)
                {
                    case MenuType.MainMenu:
                        //If user choosed to go back to the MainMenu
                        //page will start pointing to a MainMenu object instead
                        page = new MainMenu();
                        break;
                    case MenuType.StoreMenu:
                        //This will point the page reference variable to a new Object
                        //Since Object has different implementation/function of the Menu Method
                        //It will have different implementations/functions when the while loop goes back and
                        //repeat itself
                        page = new StoreMenu();
                        break;
                   // case MenuType.StoreAdmin:
                     //   page = new StoreAdmin(new StoreFrontBL(new Repository()));
                       // break;
                    case MenuType.ShowStore:
                        page = new ShowStore(new StoreFrontBL(new Repository()));
                        break;
                    case MenuType.AddStore:
                        page = new AddStore(new StoreFrontBL(new Repository()));
                        break;
                    case MenuType.ShowCustomer:
                        page = new ShowCustomer(new StoreFrontBL(new Repository()));
                        break;
                    case MenuType.QueryProduct:
                        page = new QueryProduct(new StoreFrontBL(new Repository()));
                        break;
                    //case MenuType.CartOrder:
                        //page = new CartOrder(new StoreFrontBL(new Repository()));
                        //break;
                    case MenuType.Exit:
                        Console.WriteLine("You are exiting the application!");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("You forgot to add a menu in your enum/code");
                        repeat = false;
                        break;
                }
            }

        }
    }
}
