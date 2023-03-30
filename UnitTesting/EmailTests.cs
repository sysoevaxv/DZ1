using DemoPodgotovka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void CheckEmail_ReturningFalse()
        {
            Assert.IsTrue(Email.IsEmail("qwertyu@mail.ru"));

        }
    }
}
