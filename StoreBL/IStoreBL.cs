using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {
        /// <summary>
        /// This will return a list of stores stored in the database
        /// It will also capitalize every name of the store
        /// </summary>
        /// <returns>It will return a list of stores</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// Adds a store to the database
        /// </summary>
        /// <param name="p_store">This is the store we are adding</param>
        /// <returns>It returns the added store</returns>
        Store AddStore(Store p_store);

        /// <summary>
        /// This will return a list of stores stored in the database
        /// It will also capitalize every name of the store
        /// </summary>
        /// <returns>It will return a list of stores</returns>
        List<Customer> GetAllCustomer();

        /// <summary>
        /// Adds a customer to the database.
        /// </summary>
        ///<param name="p_customer">This is the customer we are adding</param>
        /// <returns>It returns the added customer</returns>
        Customer AddCustomer(Customer p_customer);
        
        List<Product> GetAllProduct();

        /// <summary>
        /// Adds a product to the database.
        /// </summary>
        ///<param name="p_product">This is the product we are adding</param>
        /// <returns>It returns the added customer</returns>
        Product AddProduct(Product p_product);
        List<Product> FindProduct(string p_name);
        
    }
}