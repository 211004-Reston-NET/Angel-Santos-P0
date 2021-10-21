using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;
using System.Linq;

namespace StoreBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class StoreFrontBL : IStoreBL
    {
        private IRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our RRDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public StoreFrontBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Store AddStore(Store p_store)
        {
            return _repo.AddStore(p_store);
        }

        public Product AddProduct(Product p_product)
        {
            return _repo.AddProduct(p_product);
        }

        public Customer AddCustomer(Customer p_customer)
            {
            return _repo.AddCustomer(p_customer);
            }

        public List<Store> GetAllStore()
        {
            //Maybe my business operation needs to capitalize every name
            /// <summary>
            /// Displays a List of Store Locations.
            /// 
            /// </summary>
            /// <returns></returns>
            List<Store> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].Name = listOfStore[i].Name.ToLower(); 
            }

            return listOfStore;
        }
        public List<Customer> GetAllCustomer()
        {
            
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].FirstName = listOfCustomer[i].FirstName.ToLower(); 
            }

            return listOfCustomer;
        
        }        
        public List<Product> GetAllProduct()
        {
            
            List<Product> listOfProduct = _repo.GetAllProduct();
            for (int i = 0; i < listOfProduct.Count; i++)
            {
                listOfProduct[i].Name = listOfProduct[i].Name.ToLower(); 
            }

            return listOfProduct;
        }
        public List<Product> FindProduct(string p_name)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.Name .Contains(p_name)).ToList();
        }
        /*public List<Product> GetAllOrder()
        {
            
            List<Order> listOfOrder = _repo.GetAllOrder();
            for (int i = 0; i < listOfOrder.Count; i++)
            {
                listOfOrder[i].Name = listOfOrder[i].Name.ToLower(); 
            }

            return listOfProduct;
        
        } 
        */       
}
}