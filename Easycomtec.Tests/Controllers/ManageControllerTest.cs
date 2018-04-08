using Easycomtec.Controllers;
using Easycomtec.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace Easycomtec.Tests.Controllers
{
    /// <summary>
    /// Descrição resumida para ManageControllerTest
    /// </summary>
    [TestClass]
    public class ManageControllerTest
    {

        [TestMethod]
        public void Detaills()
        {
            // Arrange
            ManageController controller = new ManageController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        
    }
}

