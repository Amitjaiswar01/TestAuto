﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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
