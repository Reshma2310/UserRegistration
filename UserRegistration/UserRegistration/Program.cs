using System;
namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name of User");
            string FName = Console.ReadLine();
            RegexClass regex = new RegexClass();
            regex.RegexName(FName);            
        }
    }
}