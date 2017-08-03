using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestBrowser2.Pages;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Transactions
{
    public class LoginTransaction
    {
        private LoginPage page;

        public LoginTransaction()
        {
            this.page = new LoginPage();
        }

        public HomeTransactions GotoLogin()
        {
            this.page.Username.SendKeys("admin");
            this.page.PasswordTxt.SendKeys("demo123");
            this.page.LogInBtn.Click();

            return new HomeTransactions();
        }

        public LoginTransaction OpenUrl()
        {
            Browser.Instance.Driver.Navigate().GoToUrl("demosite.center/wordpress/wp-login.php");
            return this;
        }
    }
}