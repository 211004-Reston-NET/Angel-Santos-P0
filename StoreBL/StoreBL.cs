using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;

namespace StoreBL
{
    /// <summary>
    /// Handles all the business logic for the our restuarant application
    /// They are in charge of further processing/sanitizing/furthur validation of data
    /// Any Logic
    /// </summary>
    public class StoreFrontBL :IStoreBL
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

        public List<Store> GetAllStore()
        {
            //Maybe my business operation needs to capitalize every name of a restaurant
            List<Store> listOfStore = _repo.GetAllStore();
            for (int i = 0; i < listOfStore.Count; i++)
            {
                listOfStore[i].Name = listOfStore[i].Name.ToLower(); 
            }

            return listOfStore;
        }
    }
}
 