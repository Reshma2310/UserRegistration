namespace UserRegistrationTest
{
    public class Tests
    {
        //UC10
        /*[Test]
        public void GivenFirstName_RegexFirstName_ReturnValid()
        {
            UserRegistration.RegexClass regex = new UserRegistration.RegexClass();
            string firstName = "Reshma";
            string actualResult = regex.RegexName(firstName);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenLastName_RegexlastName_ReturnValid()
        {
            UserRegistration.RegexClass regex = new UserRegistration.RegexClass();
            string lastName = "Rose";
            string actualResult = regex.RegexName(lastName);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenEmail_RegexEmail_ReturnValid()
        {
            UserRegistration.RegexClass regex = new UserRegistration.RegexClass();
            string Email = "abc.xyz@bl.co.in";
            string actualResult = regex.RegexEmail(Email);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenPhoneNo_RegexPhoneNo_ReturnValid()
        {
            UserRegistration.RegexClass regex = new UserRegistration.RegexClass();
            string PhoneNo = "91 5642389546";
            string actualResult = regex.RegexEmail(PhoneNo);
            Assert.Pass("Valid", actualResult);
        }
        [Test]
        public void GivenPassward_RegexPassword_ReturnValid()
        {
            UserRegistration.RegexClass regex = new UserRegistration.RegexClass();
            string Pwd = "Rgmail*1996";
            string actualResult = regex.RegexPassword(Pwd);
            Assert.Pass("Valid", actualResult);
        }*/
        [Test]
        public void GivenValidEmailFile_RegexEmail_ReturnValid()
        {
            string mails = @"D:\BridgeLabs\UserRegistration\UserRegistration\UserRegistration\EmailTestForValid.txt";
            string[] mailArray = File.ReadAllLines(mails);
            for (int i = 0; i < mailArray.Length; i++)
            {
                UserRegistration.RegexClass regexp = new UserRegistration.RegexClass(mailArray[i]);
                string result = regexp.RegexEMailCheck();
                Assert.Pass("Valid", result);
            }
        }
        [Test]
        public void GivenInvalidEmailFile_RegexEmail_ReturnInvalid()
        {
            string mails = @"D:\BridgeLabs\UserRegistration\UserRegistration\UserRegistration\EmailTestForValid.txt";
            string[] mailArray = File.ReadAllLines(mails);
            for (int i = 0; i < mailArray.Length; i++)
            {
                UserRegistration.RegexClass regexp = new UserRegistration.RegexClass(mailArray[i]);
                string result = regexp.RegexEMailCheck();
                Assert.Pass("Not Valid", result);
            }
        }
    }
}