using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using StoreModels;

namespace StoreDL
{
    //The repository class has a bunch of methods that we will use to get or store information from the database
    //Does not actually hold the data itself
    public class Repository : IRepository
    {
        //Filepath need to reference from the startup project (StoreUI) and hence why we need to go back a folder and cd into StoreDL
        private const string _filepath = "./../StoreDL/Database/";
        private string _jsonString;

        public Store AddStore(Store p_store)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Store> listOfStores = GetAllStore();

            //We added the new store from the parameter 
            listOfStores.Add(p_store);

            _jsonString = JsonSerializer.Serialize(listOfStores, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the store.json
            File.WriteAllText(_filepath+"store.json",_jsonString);

            //Will return a store object from the parameter
            return p_store;
        }


        public List<Store> GetAllStore()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"store.json");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Store>>(_jsonString);
        }

        public Customer AddCustomer(Customer p_customer)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Customer> listOfCustomer = GetAllCustomer();

            //We added the new customer from the parameter 
            listOfCustomer.Add(p_customer);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented=true});

            //This is what add the customer.json
            File.WriteAllText(_filepath+"customer.json",_jsonString);

            //Will return a restaurant object from the parameter
            return p_customer;
        }


        public List<Customer> GetAllCustomer()
        {
            //File class will just read everything in the Resturant.json and put it in a string
            _jsonString = File.ReadAllText(_filepath+"customer.json");

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }
    }
}
