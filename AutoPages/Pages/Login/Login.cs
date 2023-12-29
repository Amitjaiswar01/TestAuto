using Core.CoreAuto;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AutoPages
{
    public class Login
    {
        private string _googleSearhcFieldClass = "gLFyf";
        private string _googleSearchButtonClass = "QCzoEc";

        private IWebElement SearchField => Browser.Locate.ElementByClassName(_googleSearhcFieldClass);
        private List<IWebElement> SearchIcon => Browser.Locate.ElementsByClassName(_googleSearchButtonClass);

        public Browser Browser { get; set; }
        public Login(Browser browser) 
        {
            Browser = browser;
        }

        public void SearchInputField(string term)
        {
            SearchField.Clear();
            SearchField.SendKeys(term);
        }

        public void ClickOnSearchIcon(int index)
        {
            SearchField.SendKeys(Keys.Enter);
        }
    }
}
