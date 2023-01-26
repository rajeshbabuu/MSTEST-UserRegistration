using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace UserTesting
{
    [TestClass]
    public class Testing
    {
        [TestMethod]

        public void TestFirstName()
        {
            UserRegistrationTesting.UserRegistrationTesting objTest = new UserRegistrationTesting.UserRegistrationTesting();

            objTest.ValidateFirstName("Piyush");
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            var regex = new Regex(name);
            StringAssert.Matches("Rajesh", regex);
        }

        [TestMethod]
        public void TestLastName()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateLastName("Nimje");
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            var regex = new Regex(name);
            StringAssert.Matches("Kumar", regex);
        }
        [TestMethod]
        public void TestEmail()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateEmail("abc.rajesh@bl.co.in");
            string name = @"^([a][b][c])([_\.\+\-])([a-zA-Z0-9]+)\@([b][l])\.([c][o])\.([a-z]{2})*$";
            var regex = new Regex(name);
            StringAssert.Matches("abc.xyz@bl.co.in", regex);
        }

        [TestMethod]
        public void TestMobileNumber()
        {
            UserRegistrationTesting.UserRegistrationClass objTest = new UserRegistrationTesting.UserRegistrationClass();

            objTest.ValidateMobileNumber("+91 1234567890");
            string mobileNum = @"^\+[1-9]{1}[0-9]{0,2}\s[1-9]{1}[0-9]{9}";
            var regex = new Regex(mobileNum);
            StringAssert.Matches("+91 56588567890", regex);
        }
}
}
