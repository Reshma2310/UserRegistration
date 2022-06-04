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
        const string EMAIL = "^[0-9a-zA-Z]{3,}[0-9a-zA-Z._-]+@[a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})*$";
        public void RegexName(string Name)
        {
            if (Regex.IsMatch(Name, NAME))
            {
                Console.WriteLine("Input Name is Valid");
                return;
            }
            Console.WriteLine("Input Name is Not Valid");
        }
        public void RegexEmail(string Name)
        {
            if (Regex.IsMatch(Name, EMAIL))
            {
                Console.WriteLine("Email is Valid");
                return;
            }
            Console.WriteLine("Email is Not Valid");
        }
    }
}
