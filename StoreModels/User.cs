using System;

namespace StoreModels
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Username: {Username}\nPassword: {Password}";
        }

    }
}
