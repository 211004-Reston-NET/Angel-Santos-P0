using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        StoreFront AddStore(StoreFront p_store);

        List<StoreFront> GetAllStore();
        Customer CustomerSignUp(Customer p_customer);
        List<Customer> GetAllCustomer();
        Product AddProduct(Product p_product);
        List<Product> GetAllProduct();
        
        
    }
}