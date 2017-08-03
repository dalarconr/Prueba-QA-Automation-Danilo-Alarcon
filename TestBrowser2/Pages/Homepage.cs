using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Pages
{
    public class HomePage
    {
        public IWebElement NewPostLk =>
                Browser.Instance.Driver.FindElement(By.ClassName("wp-has-submenu wp-not-current-submenu open-if-no-js menu-top menu-icon-post menu-top-first"));
    }
}