namespace StoreUI
{
    //This enum will hold the different types of Menu the user can go through
    public enum MenuType
    {
        MainMenu,
        StoreMenu,
        InventoryMenu,
        ListStore,
        AddStore,
        AddPurchaseOrder,
        QueryStore,
        AddProduct,
        ListProduct,
        QueryProduct,
        CustomerSignUp,
        GetAllCustomer,
        QueryCustomer,
        Exit
    }

    //The purpose of the interface is to ensure that every menu that we will create will have
    //the following methods in this case we can also use polymorphism
    public interface IMenu
    {
        /// <summary>
        /// Will display the overall menu of the current menu class 
        /// and the choice you/the user can make
        /// </summary>
        void Menu();

        /// <summary>
        /// Will record the user's choice and change your menu based
        /// on the end-user's choice
        /// </summary>
        /// <returns>This method should return a menu that the user will go to next</returns>
        MenuType UserChoice();
    }
}