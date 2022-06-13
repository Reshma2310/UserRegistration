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
                Func<string, bool> result = input => (Regex.IsMatch(input, NAME));
                if (result(input))
                {
                    Console.WriteLine("Input Name is Valid");
                    return "Valid";
                }
                Console.WriteLine("Input Name is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_NAME, "Invalid User Name");
            }
        }
        public string RegexEmail()
        {
            try
            {
                Func<string, bool> result = input => (Regex.IsMatch(input, EMAIL));
                if (result(input))
                {
                    Console.WriteLine("Email is Valid");
                    return "Valid";
                }
                Console.WriteLine("Email is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }
        public string RegexPhoneNo()
        {
            try
            {
                Func<string, bool> result = input => (Regex.IsMatch(input, PHONENO));
                if (result(input))
                {
                    Console.WriteLine("Mobile Number is Valid");
                    return "Valid";
                }
                Console.WriteLine("Mobile Number is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_NUMBER, "Invalid Mobile Number");
            }
        }
        public string RegexPassword()
        {
            try
            {
                Func<string, bool> result = input => (Regex.IsMatch(input, PASSWORD));
                if (result(input))
                {
                    Console.WriteLine("Password is Valid");
                    return "Valid";
                }
                Console.WriteLine("Password is Not Valid");
                return "Invalid";
            }
            catch
            {
                throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }
        public string RegexEMailCheck()
        {
            Func<string, bool> result = input => (Regex.IsMatch(input, EMAILFILE));
            if (result(input))
            {
                return "Valid";
            }
            return "Not Valid";
        }
    }
}
