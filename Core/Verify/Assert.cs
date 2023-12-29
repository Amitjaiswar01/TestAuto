using Core.CoreAuto;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Verify
{
    public class Assert
    {
        Assert assert;
        public Assert(Assert assert) 
        {
            this.assert = assert;
        }

        public void Equals(object expected, object actual, string message, bool skipMessage = false)
        {
            
            try
            {
                
            }
            catch
            {
                //Browser.IsTestFailed = true;
                //if (!string.IsNullOrEmpty(message)) { Browser.Log.Message(message); }
                throw;
            }
        }
    }
}
