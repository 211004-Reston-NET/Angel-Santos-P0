using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public interface IStoreBL
    {   int ReadConsoleParser();
        void PrintAllProducts();
        StoreFront AddStore(StoreFront p_store);
        List<StoreFront> GetAllStores();
        List<Customer> GetAllCustomers();
        Customer CustomerSignUp(Customer p_customer);
        Product AddProduct(Product p_product);
        PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);
        List<Product> GetAllProducts();
        List<Product> GetProductName(string p_name);
        List<Customer> GetCustomerName(string p_name);
        List<StoreFront> GetStoreName(string p_name);
    }
}