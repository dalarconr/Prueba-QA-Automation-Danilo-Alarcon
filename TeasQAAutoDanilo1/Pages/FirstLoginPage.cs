using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TeasQAAutoDanilo1.Pages
{
    public class FirstLoginPage
    {
        public IWebElement EmailTxt =>
               Browser.Instance.Driver.FindElement(By.Id("identifierId"));

        public IWebElement NextBtn =>
                Browser.Instance.Driver.FindElement(By.ClassName("RveJvd snByac"));
    }
}