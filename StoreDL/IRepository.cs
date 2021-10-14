using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_store">This is the restaurant we will be adding to the database</param>
        /// <returns>It will just return the restaurant we are adding</returns>
        Store AddStore(Store p_store);

        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
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
    }
}