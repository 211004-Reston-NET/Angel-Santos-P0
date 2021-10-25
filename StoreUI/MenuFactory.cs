using StoreBL;
using StoreDL;

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
                case MenuType.ShowStore:
                    return new ShowStore();
                //case MenuType.AddStore:
                    //return new AddStore(new StoreBL(new Repository()));
                case MenuType.StoreAdmin:
                    return new StoreAdmin(new StoreBL(new Repository()));
                //case MenuType.CurrentRestaurant:
                    //return new CurrentRestaurant(new StoreBL(new Repository()));
                default:
                    return null;
            }
        }
    }
}