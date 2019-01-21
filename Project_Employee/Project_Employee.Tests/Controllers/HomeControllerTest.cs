using BusinessLogic;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project_Employee.Controllers;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Project_Employee.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {          
        [TestMethod]
        public void Index()
        {
            // Arrange            
            var mock = new Mock<BusinessLogic.IBridge>();
            mock.Setup(a => a.GetFullEmployee()).Returns(new List<Common.Employee>());
            HomeController controller = new HomeController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void EditorPage()
        {
            // Arrange            
            var mock = new Mock<BusinessLogic.IBridge>();
            mock.Setup(a => a.GetFullEmployee()).Returns(new List<Common.Employee>());
            HomeController controller = new HomeController(mock.Object);

            // Act
            ViewResult result = controller.EditorPage() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }

        [TestMethod]
        public void BriedgeEmailSelect()
        {
            // Arrange
            Common.Employee test = new Employee();
            var mock = new Mock<DataAccessLayer.ISqlServerAccess>();
            mock.Setup(a => a.GetEmailSelect(test.Email)).Returns(new Common.Employee());
            Bridge bridge = new Bridge(mock.Object);

            // Act
            var received =  bridge.GetEmailSelect(test.Email);

            // Assert
            Assert.IsNotNull(received);
        }
    }
}
