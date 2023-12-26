﻿using Core;
using Core.CoreAuto;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPages
{
    public class TestBaseInitilization
    {
        public Browser Browser {  get; set; }
        public Login Login { get; set; }

        public TestBaseInitilization ()
        {
            Browser = new Browser();
            Login = new Login(Browser);
        }

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


    }
}
