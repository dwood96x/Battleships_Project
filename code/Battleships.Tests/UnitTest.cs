using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battleships;
using Battleships.Controllers;
using System.Reflection;

namespace Battleships.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestRegisterAccount()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void TestLoginAccount()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void TestLogoutAccount()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void TestCheckStats()
        {
            // Arrange

            // Act

            // Assert
        }
        [TestMethod]
        public void TestGameLoad()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }
    }
}
