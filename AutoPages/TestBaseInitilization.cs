using AutoPages.Pages.LandingPage;
using Core.CoreAuto;
using OpenQA.Selenium;
using System;

namespace AutoPages
{
    public class TestBaseInitilization : IDisposable
    {
        public Browser Browser {  get; set; }
        public Login Login { get; set; }
        public LandingPage LandingPage { get; set; }

        public TestBaseInitilization() { }

        public IWebDriver GetDriverInstance()
        {
            IWebDriver chromeDriverInstance = null;
            if (chromeDriverInstance == null)
            {
                //dd = new Drivers(driver)?? ;
                //chromeDriverInstance = dd.CreateChromeDriver();
            }
            return chromeDriverInstance;
        }

        public void InitializeFramwork() 
        {
            Browser = new Browser();
            Login = new Login(Browser);
            LandingPage = new LandingPage(Browser);
        }

        public void Dispose()
        {
            Browser.Driver.Dispose();
        }
    }
}
