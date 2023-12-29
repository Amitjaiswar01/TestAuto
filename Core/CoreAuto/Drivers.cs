using Core.CoreAuto;
using Core.Verify;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Core
{
    public class Drivers
    {
        private IWebDriver driver;

        public Drivers() { }

        public IWebDriver CreateChromeDriver() 
        {
            driver = new ChromeDriver();
            return driver;
        }
        
        public IWebDriver CreateFireFoxDriver() 
        {
            driver = new FirefoxDriver();
            return driver;
        }
    }
}
