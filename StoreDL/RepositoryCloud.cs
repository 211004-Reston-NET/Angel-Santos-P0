using System;
using System.Collections.Generic;
using System.Linq;
using Entity = StoreDL.Entities;
using Model = StoreModels;

namespace StoreDL
{
    public class RepositoryCloud : IRepository
    {
        //Depedency Injection
        private Entity.DBp0Context _context;
        public RepositoryCloud(Entity.DBp0Context p_context)
        {
            _context = p_context;
        }
        public Model.Product AddProduct(Model.Product p_product)
        {
            _context.Products.Add
            (
                new Entity.Product()
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

        public Model.StoreFront AddStore(Model.StoreFront p_store)
        {
            throw new System.NotImplementedException();
        }

        public Model.Customer CustomerSignUp(Model.Customer p_customer)
        {
            _context.Customers.Add
            (
                new Entity.Customer()
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

        public Model.PurchaseOrder AddPurchaseOrder(Model.PurchaseOrder p_order)
        {   /*  //Need to Select From Line_Item Table a Product_Id 
                // Specified by the User.
                // That Product_Id (Along with Product Name and Price will be stored
                // Into the PurchaseOrder Table ..like a Receipt of the customer order.
                // Query the database for the row to be updated.
                var query = 
                from item in db.Line_Item
                where item.product_id == ""MenuType UserChoice()"" // In IMENU
                select item;
            */
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

        public List<Model.Customer> GetAllCustomer()
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

        public List<Model.Product> GetAllProduct()
        {
            
            //1. Method Syntax - LINQ
            return _context.Products.Select(prod => 
                new Model.Product()
                {
                    ProductId = prod.ProductId,
                    ItemName = prod.ItemName,
                    Category = prod.Category,
                    Price = prod.Price,
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

        public List<Model.StoreFront> GetAllStore()
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