using OpenQA.Selenium;

namespace Core.CoreAuto
{
    public class Locate
    {
        Browser Browser;

        public Locate(Browser browser) 
        {
            Browser = browser;
        }

        public IWebElement ElementByClassName(string className)
        {
            var a = Browser.Driver.FindElement(By.ClassName(className));
            return a;
        }
        
        public IWebElement ElementById(string id)
        {
            var a = Browser.Driver.FindElement(By.Id(id));
            return a;
        }
        
        public IWebElement ElementByName(string name)
        {
            var a = Browser.Driver.FindElement(By.Name(name));
            return a;
        }
        
        public IWebElement ElementByTagName(string tagname)
        {
            var a = Browser.Driver.FindElement(By.TagName(tagname));
            return a;
        }
        
        public IWebElement ElementBySelector(string selector)
        {
            var a = Browser.Driver.FindElement(By.CssSelector(selector));
            return a;
        }
        
        public IWebElement ElementByXpath(string xpath)
        {
            var a = Browser.Driver.FindElement(By.XPath(xpath));
            return a;
        }
    }
}
