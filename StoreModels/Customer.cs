using System;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace StoreModels
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _email; 
        private string _phoneNumber;
        
        public string FirstName 
        { 
        get { return _firstName; }
        set
            {
            //Regex.IsMatch() Method - checks the regular expression to match with input string
            //Exception is thrown when Field is set with a number
            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   First Name must contain only letters.  ");
                }
                _firstName = value;
            } 
        }
        public string LastName 
        { 
        get { return _lastName; }
        set
            {
            if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   Last Name must contain only letters.    ");
                }
                _lastName = value;
            }
        }
        public string StreetAddress
        {
            get { return _streetAddress; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {       
                    throw new Exception
                    (
                        "   Street Address cannot be left empty.     "
                    );
                }
                _streetAddress = value;    
            } 
        }
        public string City
        {
            get { return _city; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$" ))
                {       
                    throw new Exception("   City must contain only letters.    ");
                }
                _city = value;
            }
        }
        public string State 
        {
            get { return _state; }
            set 
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {       
                    throw new Exception("   State must contain only letters.    ");
                }
                _state = value;
            }
        }
        public string Email 
        {
            get { return _email; }
            set 
            {
                if (!MailAddress.TryCreate(value, out var mailAddress))
                {       
                    throw new Exception
                    (
                        "   Invalid Email. Please, check spelling errors or try a different email.     "
                    );
                }
                _email = value;    
            } 
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (!Regex.IsMatch(value, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$"))
                {       
                    throw new Exception
                    (
                        "   Invalid Phone Number. Please follow a (555)-(555)-(5555) format.    "
                    );
                }
                _phoneNumber = value;    
            } 
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name:{LastName}\nStreet Address: {StreetAddress}\nCity: {City}\nState: {State}\nEmail: {Email}\nPhone Number: {PhoneNumber}";
        }
    }
}
