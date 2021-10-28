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
                    Name = p_product.Name,
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
            throw new System.NotImplementedException();
        }

        public List<Model.Customer> GetAllCustomer()
        {
            throw new System.NotImplementedException();
        }

        public List<Model.Product> GetAllProduct()
        {
            //1. Method Syntax - LINQ
            return _context.Products.Select(prod => 
                new Model.Product()
                {
                    ProductId = prod.ProductId,
                    Name = prod.Name,
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
            throw new System.NotImplementedException();
        }
    }
}