using System;

namespace RRModels
{
    public class Restaurant
    {
         private string _city;
        public string string City;  
        {
        get { return _city; }
        set
        {
            //Regex will find any number inside of my string
            if (Regex.IsMatch(value, @"^[A-Za-z .]+$"))
            {
                int
            }
        } 
    }

    public string state {get; set}
    public string city {get; set}
    }
}
