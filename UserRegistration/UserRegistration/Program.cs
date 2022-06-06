using System;
namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexClass regex = new RegexClass();
            /*Console.WriteLine("Enter First Name of User");
            string FName = Console.ReadLine();
            regex.RegexName(FName);
            Console.WriteLine("Enter Last Name of User");
            string LName = Console.ReadLine();
            regex.RegexName(LName);
            Console.WriteLine("Enter Email of User");
            string Email = Console.ReadLine();
            regex.RegexEmail(Email);
            Console.WriteLine("Enter your Phone Number");
            string PhoneNo = Console.ReadLine();
            regex.RegexPhoneNo(PhoneNo);
            Console.WriteLine("Enter your Password");
            string Password = Console.ReadLine();
            regex.RegexPassword(Password);*/
            string mails = @"D:\BridgeLabs\UserRegistration\UserRegistration\UserRegistration\EmailsTextFile.txt";
            string[] mailArray = File.ReadAllLines(mails);
            for (int i = 0; i < mailArray.Length; i++)
            {
                string result = regex.RegexEMailCheck(mailArray[i]);
                Console.WriteLine(mailArray[i] + "   is   " + result);
            }
        }
    }
}