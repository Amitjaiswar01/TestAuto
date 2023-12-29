﻿using System;
using AutoPages;
using AutoPages.Pages;
using Core.CoreAuto;
using Core.Verify;
using NUnit.Framework;

namespace ClassLibrary1
{
    public class DemoScript : TestBaseInitilization
    { 
        [SetUp]
        public void Initialize()
        {
            InitializeFramwork();
        }

        [Test]
        public void GoogleDemo() 
        {
            Browser.Naviagte(Urls.GoogleLink);
            Login.SearchInputField("Test");
            Login.ClickOnSearchIcon(0);
            
            var pageTitle = Browser.PageTitle;
            Console.WriteLine(pageTitle);

            Browser.Action.DownAction();
        }

        [Test]
        public void AmazonAccessoriesPage()
        {
            Browser.Naviagte(Urls.AmazonAccessoriesLink);
            Browser.Wait(20);
            Browser.Refresh();

            LandingPage.SelectAccessories("Accessories");
            Console.WriteLine(Browser.PageTitle);

            Browser.Action.DownAction();
        }

        [TearDown]
        public void TearDown()
        {
            Dispose();
        }
    }
}