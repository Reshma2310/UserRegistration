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
        const string EMAIL = "^[a-z]{3,}.[a-z]{3,}@[a-z]{2,}.[a-z]{2,}$";
        const string NAME = "^[A-Z]{1}[a-z]{2,}$";       
        public void RegexName(string Name)
        {
            if (Regex.IsMatch(Name, NAME))
            {
                Console.WriteLine("Input Name is Valid");
                return;
            }
            Console.WriteLine("Input Name is Not Valid");
        }        
    }
}
