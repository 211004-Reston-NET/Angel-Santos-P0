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

        public List<StoreFront> GetAllStore()
        {
           
            List<StoreFront> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].StoreName = listOfStore[i].StoreName.ToUpper(); 
            }

            return listOfStore;
        }
        public List<Customer> GetAllCustomer()
        {
            
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].FirstName = listOfCustomer[i].FirstName.ToUpper(); 
            }

            return listOfCustomer;
        
        }        
        public List<Product> GetAllProduct()
        {
            
            List<Product> listOfProduct = _repo.GetAllProduct();
            for (int i = 0; i < listOfProduct.Count; i++)
            {
                listOfProduct[i].Name = listOfProduct[i].Name.ToUpper(); 
            }

            return listOfProduct;
        }
        public List<Product> GetProduct(string p_name)
        {
            List<Product> listOfProduct = _repo.GetAllProduct();
            return listOfProduct.Where(prod => prod.Name.ToLower().Contains(p_name.ToLower())).ToList();
        }
    }
}