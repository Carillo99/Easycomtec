using Easycomtec.Controllers;
using Easycomtec.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace Easycomtec.Tests.Controllers
{
    [TestClass]
    public class HomeofficeControllerTest
    {
        [TestMethod]
        public void Edit()
        {
            // Arrange
            HomeofficeController controller = new HomeofficeController();

            // Act
            ViewResult result = controller.Edit() as ViewResult;
            
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Developer()
        {
            HomeofficeController controller = new HomeofficeController();

            CandidatesModel model = new CandidatesModel();

            var candidates = new Candidates()
            {
                CandidateID = 2092,
                Email = "test@test.com"
            };

            var occupation = new OccupationArea()
            {
                OccupationAreaID = 2092,
                Name = "tes",
                Skype = "tes",
                Linkedin = "https://linkedin.com/in/test",
                Cyte = "Itabuna",
                State = "Bahia",
                Portfolio = "https://github.com/test",
                Willingness = "Morning",
                Horary = "7-8",
                Salary = 20,
            };

            var information = new InformationBank()
            {
                InformationBankID = 2092,
                Cpf = "05453390573",
                BanK = "Banco do Brasil",
                Agency = "987898",
                AccountType = "corrente",
                AccountNumber = "6457"
            };

            var knowledge = new Knowledge()
            {
                KnowledgeID = 2092,
                Ionic = 3,
                Android = 5,
                Ios = 4,
                Majento = 2,
                WordPress = 3,
                Html = 4,
                Css = 4,
                Bootstrap = 4,
                Django = 3,
                Jquery = 3,
                Angular = 4,
                Vue = 4,
                SqlServer = 5,
                MySql = 5,
                Java = 5,
                Phyton = 3,
                Cake = 4,
                Php = 4,
                AspNetMvc = 4,
                Ruby = 4,
                C = 3,
                C_ = 3,
                Photoshop = 3,
                Illustraitor = 4,
                Salesforce = 4,
                Seo = 3,
                OtherLanguage = "JS-2",
                Crud = "https://github.com/test",
            };

            model.Candidates = candidates;
            model.OccupationArea = occupation;
            model.InformationBank = information;
            model.Knowledge = knowledge;

            controller.ModelState.AddModelError("", "error");

            //string expectedView = "Developer";

            var actual = controller.Developer(model) as ViewResult;
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expectedView, actual.ViewName);
            Assert.AreEqual(model, actual.Model);

        }
        [TestMethod]
        public void DeveloperEdit()
        {
            // Arrange
            HomeofficeController controller = new HomeofficeController();

            CandidatesModel model = new CandidatesModel();

            var candidates = new Candidates()
            {
                CandidateID = 2092,
                Email = "NewTest@test.com"
            };

            var occupation = new OccupationArea()
            {
                OccupationAreaID = 2092,
                Name = "tes",
                Skype = "tes",
                Linkedin = "https://linkedin.com/in/test",
                Cyte = "Itabuna",
                State = "Bahia",
                Portfolio = "https://github.com/test",
                Willingness = "Morning",
                Horary = "7-8",
                Salary = 20,
            };

            var information = new InformationBank()
            {
                InformationBankID = 2092,
                Cpf = "05453390573",
                BanK = "Banco do Brasil",
                Agency = "987898",
                AccountType = "corrente",
                AccountNumber = "6457"
            };

            var knowledge = new Knowledge()
            {
                KnowledgeID = 2092,
                Ionic = 3,
                Android = 5,
                Ios = 4,
                Majento = 2,
                WordPress = 3,
                Html = 4,
                Css = 4,
                Bootstrap = 4,
                Django = 3,
                Jquery = 3,
                Angular = 4,
                Vue = 4,
                SqlServer = 5,
                MySql = 5,
                Java = 5,
                Phyton = 3,
                Cake = 4,
                Php = 4,
                AspNetMvc = 4,
                Ruby = 4,
                C = 3,
                C_ = 3,
                Photoshop = 3,
                Illustraitor = 4,
                Salesforce = 4,
                Seo = 3,
                OtherLanguage = "JS-2",
                Crud = "https://github.com/test",
            };

            model.Candidates = candidates;
            model.OccupationArea = occupation;
            model.InformationBank = information;
            model.Knowledge = knowledge;

            controller.ModelState.AddModelError("", "error");

            //string expectedView = "Developer";

            var actual = controller.DeveloperEdit(model) as ViewResult;
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expectedView, actual.ViewName);
            Assert.AreEqual(model, actual.Model);

        }
    }
}
