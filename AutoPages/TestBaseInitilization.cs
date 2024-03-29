﻿using AutoPages.Pages.LandingPage;
using Core.CoreAuto;
using Core.Verify;
using NUnit.Framework;
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

        private void InitializeFramwork1() 
        {
            Browser = new Browser();
            Login = new Login(Browser);
            LandingPage = new LandingPage(Browser);
        }

        public void Dispose()
        {
            Browser.Driver.Dispose();
        }

        [SetUp]
        public void InitializeFramwork()
        {
            InitializeFramwork1();
        }

        [TearDown]
        public void TearDown()
        {
            Dispose();
        }
    }
}
