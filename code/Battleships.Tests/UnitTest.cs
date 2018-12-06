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
using Moq;
using Battleships.Domain.Abstract;

namespace Battleships.Tests
{
    [TestClass]
    public class UnitTest
    {
        // TODO : Learn how to use Moq
        [TestMethod]
        public void TestRegisterAccount()
        {
            // Arrange
            var MockUsersRepo = new Mock<IUsersRepository>();
            // Act

            // Assert
        }
        [TestMethod]
        public void TestLoginAccount()
        {
            // Arrange
            var MockUsersRepo = new Mock<IUsersRepository>();
            // Act

            // Assert
        }
        [TestMethod]
        public void TestLogoutAccount()
        {
            // Arrange
            var MockUsersRepo = new Mock<IUsersRepository>();
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
