using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Easycomtec.Tests.Selenium
{
    class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(Browser browser, string urlDriver = null)
        {
            IWebDriver webDriver = null;

            webDriver = new ChromeDriver(urlDriver);
           
            return webDriver;
        }
    }
}