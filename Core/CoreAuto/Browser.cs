using OpenQA.Selenium;

namespace Core.CoreAuto
{
    public class Browser
    {
        public IWebDriver Driver; 
        public Locate Locate;

        public Browser()
        {
            Driver = new Drivers().CreateChromeDriver();
            Driver.Manage().Window.Maximize();
            Locate = new Locate(this);
        } 

        public void Naviagte(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void CloseWindow()
        {
            Driver.Dispose();
        }
    }
}
