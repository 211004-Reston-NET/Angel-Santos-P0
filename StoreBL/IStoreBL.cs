using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {
        /// <summary>
        /// This will return a list of restaurants stored in the database
        /// It will also capitalize every name of the restaurant
        /// </summary>
        /// <returns>It will return a list of restaurants</returns>
        List<Store> GetAllStore();

        /// <summary>
        /// Adds a restaurant to the database
        /// </summary>
        /// <param name="p_store">This is the restaurant we are adding</param>
        /// <returns>It returns the added restaurant</returns>
        Store AddStore(Store p_store);
    }
}