
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model = StoreModels;

namespace StoreDL
{
    public class RepositoryCloud : IRepository
    {
        //Depedency Injection
        private StoreDL.DBp0Context _context;
        public RepositoryCloud(StoreDL.DBp0Context p_context)
        {
            _context = p_context;
        }
        public StoreModels.Product AddProduct(StoreModels.Product p_product)
        {
            _context.Products.Add
            (
                new Model.Product()
                {
                    ItemName = p_product.ItemName,
                    Category = p_product.Category,
                    Price = p_product.Price,
                    Description = p_product.Description 
                }
            );

            //Save changes to DB
            _context.SaveChanges();
            return p_product;
        }

        public StoreModels.StoreFront AddStore(StoreModels.StoreFront p_store)
        {
            throw new System.NotImplementedException();
        }

        public StoreModels.Customer CustomerSignUp(StoreModels.Customer p_customer)
        {
            _context.Customers.Add
            (
                new Model.Customer()
                {
                    CustomerId = p_customer.CustomerId,
                    FirstName = p_customer.FirstName,
                    LastName = p_customer.LastName,
                    StreetAddress = p_customer.StreetAddress,
                    Email = p_customer.Email
                }
            );

            //Save changes to DB
            _context.SaveChanges();
            return p_customer;
        }

        

        public StoreModels.LineItem ReplenishLineById(StoreModels.LineItem p_lin)
        {
            StoreModels.LineItem linUpdated = new StoreModels.LineItem()
                {
                OrderId = p_lin.OrderId,
                Inventory = p_lin.Inventory,
                };

            _context.LineItems.Update(linUpdated);
            _context.SaveChanges();
            return p_lin;
        }
 
        public StoreModels.LineItem GetItemById(int p_id)
        {
            Model.LineItem linFound = _context.LineItems.AsNoTracking().FirstOrDefault(lin => lin.OrderId == p_id);
            
            return new StoreModels.LineItem()
            {
                OrderId = linFound.OrderId,
                Inventory = (int)linFound.Inventory              
            };
            
        }
       


        public List<StoreModels.LineItem> GetAllLineItemInventory(StoreModels.Product p_prod)
        {
            return _context.LineItems
                .Where(lin => lin.OrderId == p_prod.ProductId) //We find the LineItems that have matching prodId
                .Select(lin => new Model.LineItem(){ //Convert it into Model.Review
                  OrderId = lin.OrderId,
                  Inventory = lin.Inventory
                })
                .ToList(); //Convert it into List
        }



        public List<StoreModels.Customer> GetAllCustomer()
        {
            return _context.Customers.Select(cust => 
                new Model.Customer()
                {
                    CustomerId = cust.CustomerId,
                    FirstName = cust.FirstName,
                    LastName = cust.LastName,
                    StreetAddress = cust.StreetAddress,
                    Email = cust.Email
                    
                }
            ).ToList();
        }

        public List<StoreModels.Product> GetAllProduct()
        {
            
            //1. Method Syntax - LINQ
            return _context.Products.Select(prod => 
                new Model.Product()
                {
                    ProductId = prod.ProductId,
                    ItemName = prod.ItemName,
                    Category = prod.Category,
                    Price = (decimal)prod.Price,
                    Description = prod.Description
                    
                }
            ).ToList();

            //2. Query Syntax
            // var result = (from prod in _context.Products
            //             select prod);

            // List<Model.Product> listOfProd = new List<Model.Product>();
            // foreach (var rest in result)
            // {
            //     listOfProd.Add(new Model.Product(){
            //         ProductId = prod.ProductId,
            //         Name = prod.Name,
            //         Category = prod.Category,
            //         Price = prod.Price,
            //         Description = prod.Description
            //     });
            // }

            // return listOfProd;
        }

        public List<StoreModels.StoreFront> GetAllStore()
        {
            return _context.StoreFronts.Select(store => 
                new Model.StoreFront()
                {
                    StoreId = store.StoreId,
                    StoreName = store.StoreName,
                    StreetAddress = store.StreetAddress,
                    City = store.City,
                    State = store.State
                    
                }
            ).ToList();
        }
    }
}

/*
        public List<Product> GetProductId(int p_id)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.ProductIdContains(p_id)).ToList();
        }

*/
/*    
        public Model.PurchaseOrder AddPurchaseOrder(Model.PurchaseOrder p_order)
        {   
            _context.PurchaseOrders.Add
            (
                new Entity.PurchaseOrder()
                {
                    OrderId = p_order.OrderId,
                    LocationId = p_order.LocationId,
                    CustomerId = p_order.CustomerId,
                    ItemName = p_order.ItemName,
                    TotalPrice = p_order.Price
                }
            );

            //Save changes to DB
            _context.SaveChanges();
            return p_order;
        }
*/