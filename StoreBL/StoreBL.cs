using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;
using System.Linq;

namespace StoreBL
{
    public class StoreFrontBL : IStoreBL
    {
        private IRepository _repo;
        
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        
        public int ReadConsoleParser()
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {       
                return num;
            }
            Console.WriteLine("   Must be an Integer  ");
            return 0;
        }

        //public void ReplenishInventory()
        /* public static LineItem _replenishInventory = new LineItem();
        {
            try 
            { 
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "revservp0.database.windows.net"; 
                builder.UserID = "AngelS12";            
                builder.Password = "Okaypassword123";     
                builder.InitialCatalog = "DBp0";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = "UPDATE Line_Item SET Inventory = Inventory + 1 WHERE product_id = 001"
                    //String sql = "UPDATE Line_Item SET Inventory = Inventory + _replenishInventory"
                    //String sql = "SELECT p.item_name, p.Price, li.product_id, li.inventory FROM Product p inner join Line_Item li on p.product_id = li.product_id";

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
        }

        */
        /*
        public void PrintAllProducts()
        {
            List<Product> listOfProduct = GetAllProducts();
                foreach (Product prod in listOfProduct)
                    {
                    Console.WriteLine("====================");
                    Console.WriteLine(prod);
                    Console.WriteLine("====================");
                    }
        }
                // Need to Select From Line_Item Table a Product_Id 
                // Specified by the User.
                // That Product_Id (Along with Product Name and Price will be stored
                // Into the PurchaseOrder Table ..like a Receipt of the customer order.
                // Query the database for the row to be updated.
                
                var query = 
                from item in db.Line_Item
                where item.product_id == ""MenuType UserChoice()"" // In IMENU
                select item;

                // Execute the query, and change the column values
                // you want to change.
                foreach (Order ord in query)
                {
                    ord.ShipName = "Mariner";
                    ord.ShipVia = 2;
                    // Insert any additional changes to column values.
                }

                // Submit the changes to the database.
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    // Provide for exceptions.
                }
            */

        public void PrintAllProducts()
        {
            List<Product> listOfProduct = GetAllProducts();
                foreach (Product prod in listOfProduct)
                    {
                    Console.WriteLine("====================");
                    Console.WriteLine(prod);
                    Console.WriteLine("====================");
                    }
        }

        public LineItem ReplenishLineById(LineItem p_lineItem, int p_addQuantity)
        {
            {
                p_lineItem.Inventory += p_addQuantity;
            }
            return _repo.ReplenishLineById(p_lineItem);
        }


        public StoreFront AddStore(StoreFront p_store)
        {
            return _repo.AddStore(p_store);
        }

        public Product AddProduct(Product p_product)
        {
            return _repo.AddProduct(p_product);
        }

        public Customer CustomerSignUp(Customer p_customer)
            {
            return _repo.CustomerSignUp(p_customer);
            }
        
        public PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order)
            {
            return _repo.AddPurchaseOrder(p_order);
            }

        public List<StoreFront> GetAllStores()
        {
           
            List<StoreFront> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].StoreName = listOfStore[i].StoreName.ToUpper(); 
            }

            return listOfStore;
        }
        public List<StoreFront> GetStoreName(string p_name)
        {
            List<StoreFront> listOfStore = _repo.GetAllStore();
            return listOfStore.Where(store => store.StoreName.ToLower().Contains(p_name.ToLower())).ToList();
        }
        public List<Customer> GetAllCustomers()
        {
            
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].FirstName = listOfCustomer[i].FirstName.ToUpper(); 
            }

            return listOfCustomer;
        
        }
        public List<Customer> GetCustomerName(string p_customerfname)
        {
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            return listOfCustomer.Where(cust => cust.FirstName.ToLower().Contains(p_customerfname.ToLower())).ToList();
        }        
        public List<Product> GetAllProducts()
        {
            
            List<Product> listOfProduct = _repo.GetAllProduct();
            for (int i = 0; i < listOfProduct.Count; i++)
            //Below sets product names to Uppercase
            {
                listOfProduct[i].ItemName = listOfProduct[i].ItemName.ToUpper(); 
            }

            return listOfProduct;
        }
        public List<Product> GetProductName(string p_name)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.ItemName.ToLower().Contains(p_name.ToLower())).ToList();
        }
/*        public List<Product> GetProductCategory(string p_category)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.Category.ToLower().Contains(p_category.ToLower())).ToList();
        }
        */
    }
}