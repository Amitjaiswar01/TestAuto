using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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

        public List<IWebElement> ElementsByClassName(string className)
        {
            var a = Browser.Driver.FindElements(By.ClassName(className)).ToList();
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
        
        public ReadOnlyCollection<IWebElement> ElementsBySelector(string selector)
        {
            var list = Browser.Driver.FindElements(By.CssSelector(selector));
            return list;
        }
        
        public IWebElement ElementByXpath(string xpath)
        {
            var a = Browser.Driver.FindElement(By.XPath(xpath));
            return a;
        }
    }
}
