using Core.Verify;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Core.CoreAuto
{
    public class Browser
    {
        public IWebDriver Driver;
        public ActionElements Action;
        public Locate Locate;


        // Get Current Page Url
        public string PageUrl => Driver.Url;
        
        // Get Page Title
        public string PageTitle => Driver.Title;
        
        // Get Page Source
        public string PageSource => Driver.PageSource;

        public Browser()
        {
            Driver = new Drivers().CreateChromeDriver();
            Driver.Manage().Window.Maximize();

            Locate = new Locate(this);
            Action = new ActionElements(Driver);
        }

        public void Naviagte(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        public void Forward()
        {
            Driver.Navigate().Forward();
        }
        
        public void Backward()
        {
            Driver.Navigate().Back();
        }

        public IWebElement FindElement(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }

            return Driver.FindElement(by);
        }

        public void Wait(int miliseconds, int maxTimeOutSeconds = 60)
        {
            var wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 1, maxTimeOutSeconds));
            var delay = new TimeSpan(0, 0, 0, 0, miliseconds);
            var timestamp = DateTime.Now;
            wait.Until(Driver => (DateTime.Now - timestamp) > delay);
        }
    }
}
