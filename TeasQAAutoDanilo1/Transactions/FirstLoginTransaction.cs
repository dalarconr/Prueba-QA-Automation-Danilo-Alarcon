using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeasQAAutoDanilo1.Pages;
using TestBrowser2.TestingTools;

namespace TeasQAAutoDanilo1.Transactions
{
    public class FirstLoginTransaction
    {
        private FirstLoginPage page;

        public FirstLoginTransaction()

        {
            this.page = new FirstLoginPage();
        }

        public LoginTransaction FirstAuthentication()
        {
            this.page.EmailTxt.SendKeys("escarpo");
            this.page.NextBtn.Click();

            return new LoginTransaction();
        }

        public FirstLoginTransaction OpenUrl()
        {
            Browser.Instance.Driver.Navigate().GoToUrl("https://mail.google.com");
            return this;
        }
    }
}