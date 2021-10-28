using StoreBL;
using StoreDL;
using StoreUI;

namespace StoreUI
{
    /// <summary>
    /// Designed to create menu objects
    /// </summary>
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.CustomerSignUp:
                    return new CustomerSignUp(new StoreFrontBL(new Repository()));
                case MenuType.ShowStore:
                    return new ShowStore(new StoreFrontBL(new Repository()));
                case MenuType.GetAllCustomer:
                    return new ListCustomer(new StoreFrontBL(new Repository()));
                case MenuType.ListProduct:
                    return new ListProduct(new StoreFrontBL(new Repository()));
                case MenuType.QueryProduct:
                    return new ListProduct(new StoreFrontBL(new Repository()));
                default:
                    return null;
            }
        }
    }
}
