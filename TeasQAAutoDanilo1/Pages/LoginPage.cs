using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TeasQAAutoDanilo1.Pages
{
    public class LoginPage
    {
        public IWebElement LoginBtn =>
               Browser.Instance.Driver.FindElement(By.ClassName("CwaK9"));

        public IWebElement PasswordTxt =>
                        Browser.Instance.Driver.FindElement(By.ClassName("whsOnd zHQkBf"));
    }
}