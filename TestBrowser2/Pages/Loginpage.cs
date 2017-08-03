using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Pages
{
    public class LoginPage
    {
        public IWebElement LogInBtn =>
                Browser.Instance.Driver.FindElement(By.Id("wp-submit"));

        public IWebElement PasswordTxt =>
                        Browser.Instance.Driver.FindElement(By.Id("user_pass"));

        public IWebElement Username =>
                Browser.Instance.Driver.FindElement(By.Id("user_login"));
    }
}