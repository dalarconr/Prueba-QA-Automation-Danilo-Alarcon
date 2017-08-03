using OpenQA.Selenium.Interactions;
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
    public class LoginTransaction
    {
        private LoginPage page;

        public LoginTransaction()
        {
            this.page = new LoginPage();
        }

        public HomeTransactions GotoEmail()
        {
            this.page.PasswordTxt.SendKeys("bebesito");
            this.page.LoginBtn.Click();

            return new HomeTransactions();
        }
    }
}