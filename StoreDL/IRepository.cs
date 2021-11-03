using System.Collections.Generic;
using StoreModels;

namespace StoreDL
{
    public interface IRepository
    {
        StoreFront AddStore(StoreFront p_store);
        List<Customer> GetAllCustomer();
        List<Product> GetAllProduct();
        List<StoreFront> GetAllStore();
        List<LineItem> GetAllLineItemInventory(Product p_prod);
        Customer CustomerSignUp(Customer p_customer);
        Product AddProduct(Product p_product);
        LineItem ReplenishLineById(LineItem p_lin);
        LineItem GetItemById(int p_id);

        //PurchaseOrder AddPurchaseOrder(PurchaseOrder p_order);
    }
}