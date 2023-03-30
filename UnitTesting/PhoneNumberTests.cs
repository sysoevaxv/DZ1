using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DemoPodgotovka;

namespace UnitTesting
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void CheckPhoneNumber_ReturningFalse()
        {
            Assert.IsTrue(PhoneNumber.IsPhoneNbr("7-564-321-09-12"));

        }
    }
}
