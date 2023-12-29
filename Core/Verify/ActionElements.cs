using Core.CoreAuto;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Verify
{
    public class ActionElements
    {
        public Actions Action { get; set; }

        public ActionElements(IWebDriver Driver) 
        {
            Action = new Actions(Driver);
        }

        public void DownAction()
        {
            Action.KeyDown(Keys.Down).Perform();
        }
    }
}
