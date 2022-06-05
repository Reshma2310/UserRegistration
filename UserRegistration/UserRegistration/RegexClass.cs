using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegexClass
    {        
        const string NAME = "^[A-Z]{1}[a-zA-Z]{2,}$";        
        const string EMAIL = "^[0-9a-zA-Z]{3,}([0-9a-zA-Z._-])*@[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})*$";
        const string PHONENO = "^([0-9]{2}[ ][0-9]{10})$";
        const string PASSWORD = "^[A-Z]{1}[0-9a-zA-Z]{7,}$";
        public void RegexName(string Name)
        {
            if (Regex.IsMatch(Name, NAME))
            {
                Console.WriteLine("Input Name is Valid");
                return;
            }
            Console.WriteLine("Input Name is Not Valid");
        }
        public void RegexEmail(string Mail)
        {
            if (Regex.IsMatch(Mail, EMAIL))
            {
                Console.WriteLine("Email is Valid");
                return;
            }
            Console.WriteLine("Email is Not Valid");
        }
        public void RegexPhoneNo(string Number)
        {
            if (Regex.IsMatch(Number, PHONENO))
            {
                Console.WriteLine("Mobile Number is Valid");
                return;
            }
            Console.WriteLine("Mobile Number is Not Valid");
        }
        public void RegexPassword(string password)
        {
            if (Regex.IsMatch(password, PASSWORD))
            {
                Console.WriteLine("Password is Valid");
                return;
            }
            Console.WriteLine("Password is Not Valid insert 8 characters next time");
        }
    }
}
