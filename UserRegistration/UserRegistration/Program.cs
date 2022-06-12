using System;
namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name of User");
            string FName = Console.ReadLine();
            RegexClass regexN = new RegexClass(FName);
            regexN.RegexName();
            Console.WriteLine("Enter Last Name of User");
            string LName = Console.ReadLine();
            RegexClass regexA = new RegexClass(LName);
            regexA.RegexName();
            Console.WriteLine("Enter Email of User");
            string Email = Console.ReadLine();
            RegexClass regexE = new RegexClass(Email);
            regexE.RegexEmail();
            Console.WriteLine("Enter your Phone Number");
            string PhoneNo = Console.ReadLine();
            RegexClass regexP = new RegexClass(PhoneNo);
            regexP.RegexPhoneNo();
            Console.WriteLine("Enter your Password");
            string Password = Console.ReadLine();
            RegexClass regexPwd = new RegexClass(Password);
            regexPwd.RegexPassword();
            string mails = @"D:\BridgeLabs\UserRegistration\UserRegistration\UserRegistration\EmailsTextFile.txt";
            string[] mailArray = File.ReadAllLines(mails);
            for (int i = 0; i < mailArray.Length; i++)
            {
                RegexClass regexp = new RegexClass(mailArray[i]);
                string result = regexp.RegexEMailCheck();
                Console.WriteLine(mailArray[i] + "   is   " + result);
            }
        }
    }
}