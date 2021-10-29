using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {
        StoreFront AddStore(StoreFront p_store);
        List<StoreFront> GetAllStore();
        Customer CustomerSignUp(Customer p_customer);
        List<Customer> GetAllCustomer();
        Product AddProduct(Product p_product);
        List<Product> GetAllProduct();
        List<Product> GetProductName(string p_name);
        List<StoreFront> GetStoreName(string p_name);
    }
}