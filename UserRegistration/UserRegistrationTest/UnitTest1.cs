namespace UserRegistrationTest
{
    public class Tests
    {        
        [Test]
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
        }
    }
}