using Core.CoreAuto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoPages.Pages.LandingPage
{
    public class LandingPage
    {
        public Browser Browser { get; set; }

        private string _auto = "[dir=\"auto\"]";
        public LandingPage(Browser browssr) 
        {
            Browser = browssr;
        }

        public void SelectAccessories(string Accessories)
        {
            var findTheText = Browser.Locate.ElementsBySelector(_auto);

            //Linq
            findTheText.FirstOrDefault(item => item.Text == Accessories)?.Click();

            /*  //Normal
            foreach (var item in findTheText)
            {
                var bbbb = item.Text;
                if (item.Text == "Accessories")
                {
                    var nn = item;
                }
            } */ 
        }
    }
}
