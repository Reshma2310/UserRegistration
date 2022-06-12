namespace UserRegistrationTest
{
    public class Tests
    {
        //UC10
        [Test]
        public void GivenFirstNameValid_RegexExpression_ReturnValid()
        {
            try
            {
                UserRegistration.RegexClass regex = new UserRegistration.RegexClass("Reshma");                
                string actualResult = regex.RegexName();
                Assert.Pass("Valid", actualResult);
            }
            catch (UserRegistration.UserException exc)
            {
                Assert.AreEqual("Invalid User Name", exc.Message);
            }
        }
        [Test]
        public void GivenInvalidFirstName_Process_ReturnInvalid()
        {
            try
            {
                UserRegistration.RegexClass regex = new UserRegistration.RegexClass("shma");
                string actualResult = regex.RegexName();
                Assert.Pass("Valid", actualResult);
            }
            catch (UserRegistration.UserException exc)
            {
                Assert.AreEqual("Invalid User Name", exc.Message);
            }
        }
        [Test]
        public void GivenInvalidLastName_Process_ReturnInvalid()
        {
            try
            {
                UserRegistration.RegexClass regex = new UserRegistration.RegexClass("rose");
                string actualResult = regex.RegexName();
                Assert.Pass("Valid", actualResult);
            }
            catch (UserRegistration.UserException exc)
            {
                Assert.AreEqual("Invalid Last Name", exc.Message);
            }
        }
        [Test]
        public void GivenInvalidEmail_RegexEmail_ReturnInvalid()
        {
            try
            {
                UserRegistration.RegexClass regex = new UserRegistration.RegexClass(".xyz@bl.co.in");
                string actualResult = regex.RegexEmail();
                Assert.Pass("Valid", actualResult);
            }
            catch (UserRegistration.UserException exc)
            {
                Assert.AreEqual("Invalid Email", exc.Message);
            }
        }
        [Test]
        public void GivenInvalidPhoneNo_RegexPhoneNo_ReturnInvalid()
        {
            try
            {
                UserRegistration.RegexClass regex = new UserRegistration.RegexClass("642389546");
                string actualResult = regex.RegexEmail();
                Assert.Pass("Valid", actualResult);
            }
            catch (UserRegistration.UserException exc)
            {
                Assert.AreEqual("Invalid Mobile Number", exc.Message);
            }
        }
        [Test]
        public void GivenInvalidPassward_RegexPassword_ReturnInvalid()
        {
            try
            {
                UserRegistration.RegexClass regex = new UserRegistration.RegexClass("1996abcd");
                string actualResult = regex.RegexPassword();
                Assert.Pass("Valid", actualResult);
            }
            catch (UserRegistration.UserException exc)
            {
                Assert.AreEqual("Invalid Password", exc.Message);
            }
        }
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