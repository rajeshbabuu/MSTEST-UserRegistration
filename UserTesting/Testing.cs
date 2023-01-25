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
    }
}
