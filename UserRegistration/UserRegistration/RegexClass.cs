using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;
namespace UserRegistration
{    
    public class RegexClass
    {
        public string input;
        public RegexClass(string input)
        {
            this.input = input;
        }
        const string NAME = "^[A-Z]{1}[a-zA-Z]{2,}$";        
        const string EMAIL = "^[0-9a-zA-Z]{3,}([0-9a-zA-Z._-])*@[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})*$";
        const string PHONENO = "^([0-9]{2}[ ][0-9]{10})$";        
        const string PASSWORD = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[&!@#$%^*_-]).{8,}$";
        const string EMAILFILE = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public string RegexName()
        {
            try
            {
                if (Regex.IsMatch(input, NAME))
                {
                    Console.WriteLine("Input Name is Valid");
                    return "Valid";
                }
                Console.WriteLine("Input Name is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_MESSAGE, "Invalid User Name");
            }
        }
        public string RegexEmail()
        {
            try
            {
                if (Regex.IsMatch(input, EMAIL))
                {
                    Console.WriteLine("Email is Valid");
                    return "Valid";
                }
                Console.WriteLine("Email is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_MESSAGE, "Invalid User Name");
            }
        }
        public string RegexPhoneNo()
        {
            try
            {
                if (Regex.IsMatch(input, PHONENO))
                {
                    Console.WriteLine("Mobile Number is Valid");
                    return "Valid";
                }
                Console.WriteLine("Mobile Number is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_MESSAGE, "Invalid User Name");
            }
        }
        public string RegexPassword()
        {
            try
            {
                if (Regex.IsMatch(input, PASSWORD))
                {
                    Console.WriteLine("Password is Valid");
                    return "Valid";
                }
                Console.WriteLine("Password is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_MESSAGE, "Invalid User Name");
            }
        }
        public string RegexEMailCheck()
        {
            if (Regex.IsMatch(input, EMAILFILE))
            {
                return "Valid";
            }
            return "Not Valid";
        }
    }
}
