using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Easycomtec.Tests.Selenium;
using System.Configuration;


namespace ConversorDistancias.Testes
{
    public class TelaConversaoDistancias
    {
        private Browser _browser;
        private IWebDriver _driver;

        public TelaConversaoDistancias(Browser browser)
        {
            _browser = browser;

            string caminhoDriver = null;

            caminhoDriver =
                   ConfigurationManager.AppSettings["DriverUrlChrome"];
 
            _driver = WebDriverFactory.GetWebDriver(
                browser, caminhoDriver);
        }

        public void CarregarPagina()
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["UrlPageWeb"]);

        }

        public void PreencherLogin(string email, string password)
        {
            IWebElement Email =_driver.FindElement(By.Name("Email"));
            IWebElement Password = _driver.FindElement(By.Name("Password"));

            Email.SendKeys(email.ToString());
            Password.SendKeys(password.ToString());
        }

        public void ProcesssarLogin()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            IWebElement Register = wait.Until<IWebElement>(d => d.FindElement(By.Id("Login")));
            Register.Click();
        }
    

        public void Fechar()
        {
            _driver.Quit();
            _driver = null;
        }

    }
}