using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        /// <summary>
        /// It will add a store in our database
        /// </summary>
        /// <param name="p_store">This is the store we will be adding to the database</param>
        /// <returns>It will just return the store we are adding</returns>
        Store AddStore(Store p_store);

        /// <summary>
        /// This will return a list of stores stored in the database
        /// </summary>
        /// <returns>It will return a list of stores</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// It will add a customer in our database
        /// </summary>
        /// <param name="p_customer">This is the Customer we will be adding to the database</param>
        /// <returns>It will just return the Customer we are adding</returns>
        Customer AddCustomer(Customer p_customer);

        /// <summary>
        /// This will return a list of Customers stored in the database
        /// </summary>
        /// <returns>It will return a list of customers</returns>
        List<Customer> GetAllCustomer();
        Product AddProduct(Product p_product);

        /// <summary>
        /// This will return a list of Customers stored in the database
        /// </summary>
        /// <returns>It will return a list of customers</returns>
        List<Product> GetAllProduct();
        List<Cart> GetAllCart();
    }
}