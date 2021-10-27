/*using StoreBL;
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
            var configuration = new ConfigurationBuilder() // Class from Microsoft.extensions.configuration package
                .SetBasePath(Directory.GetCurrentDirectory()) // Gets current directory in StoreUI 
                .AddJsonFile("appsetting.json") //Add appsetting.json to StoreUI
                .Build(); //Builds our configuration

                public DBp0Context(DbContextOptions<DBp0Context> options = new DbContextOptionsBuilder()
                    .UseSqlServer(configuration.GetConnectionString("ReferenceToDB"));
                    .Options;


            switch (p_menu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.StoreMenu;
                    return new StoreMenu;
                case MenuType.ShowStore:
                    return new ShowStore((new StoreBL(new RespositoryCloud(new StoreDatabaseContext(options)))));
                case MenuType.AddStore:
                    return new AddStore(new StoreBL(new RespositoryCloud(new StoreDatabaseContext(options))));
                //case MenuType.StoreAdmin:
                    //return new StoreAdmin(new StoreBL(new RespositoryCloud(new StoreDatabaseContext(options))));
                //case MenuType.CurrentStore:
                    //return new CurrentStore(new StoreBL(new RespositoryCloud(new StoreDatabaseContext(options))));
                default:
                    return null;
            }
        }
    }
}
*/