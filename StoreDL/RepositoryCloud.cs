using System.Collections.Generic;
using StoreDL;
using Model = StoreModels;

public class RepositoryCloud : IRepository
{
    public Model.Product AddProduct(Model.Product p_product)
    {
        throw new System.NotImplementedException();
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
        throw new System.NotImplementedException();
    }

    public List<Model.StoreFront> GetAllStore()
    {
        throw new System.NotImplementedException();
    }
}