using System;

namespace Customers
{
    public class Customers
    {
        //private will make this field belong to just this C# code and nowhere else
        public string name; 
        private string address;
        private string email;
        private int phonenumber;
        private string orders;

        public Customers()
        {
            name = "Bob";
            address = "14 Manhatten";
            phonenumber = 1212132312312;
        }
}

