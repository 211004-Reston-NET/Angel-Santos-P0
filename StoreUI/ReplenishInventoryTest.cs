/*
using System;
using StoreBL;
using StoreModels;

namespace StoreUI
{
    public class ReplenishInventory : IMenu
    {

        //PurchaseOrder - Entity
        private static LineItem _inventory = new LineItem();
        private IStoreBL _storeBL;
         
        public ReplenishInventory(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        public void Menu()
        {
            Console.WriteLine("-- Replenish Inventory --"
            Console.WriteLine("[1] - List All Products");
            Console.WriteLine("[2] - Replenish Inventory by 5 - ItemId 001");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    _storeBL.PrintAllProducts();

                case "2":
                    try 
                    { 
                        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                        builder.DataSource = "revservp0.database.windows.net"; 
                        builder.UserID = "AngelS12";            
                        builder.Password = "Okaypassword123";     
                        builder.InitialCatalog = "DBp0";

                        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                        {
                            String sql = "UPDATE Line_Item SET Inventory = Inventory + 5 WHERE product_id = 001";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                connection.Open();
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine(reader.GetInt32(0));
                                    }
                                }
                            }                    
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    Console.ReadLine();
                    return MenuType.StoreMenu;

               
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}
*/