using AutoPages;
using Core.CoreAuto;
using NUnit.Framework;

namespace ClassLibrary1
{
    public class DemoScript //: TestBaseInitilization
    {
        Browser Browser;
        Login Login;

        //public DemoScript() : base() { }

        [SetUp]
        public void Initialize()
        {
            Browser = new Browser();
            Login = new Login(Browser);
            //Setup = new TestBaseInitilization();
        }

        [Test] 
        public void Test() 
        {
            Browser.Naviagte("https://www.google.com/");
            Login.SearchInputField("Test");
        }

        [TearDown]
        public void TearDown() 
        {
            Browser.CloseWindow();
        }
    }
}