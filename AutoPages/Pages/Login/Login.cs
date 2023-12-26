using Core.CoreAuto;
using OpenQA.Selenium;

namespace AutoPages
{
    public class Login
    {
        private string _googleSearhcFieldClass = "gLFyf";

        private IWebElement SearchField => Browser.Locate.ElementByClassName(_googleSearhcFieldClass);

        public Browser Browser { get; set; }
        public Login(Browser browser) 
        {
            Browser = browser;
        }

        public void SearchInputField(string term)
        {
            SearchField.SendKeys(term);
            SearchField.Click();
        }
    }
}
