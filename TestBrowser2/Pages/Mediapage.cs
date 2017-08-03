using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Pages
{
    public class MediaPage
    {
        public IWebElement AddNewMediaLk =>
               Browser.Instance.Driver.FindElement(By.Id("add-new-h2"));

        public IWebElement AllPost =>
               Browser.Instance.Driver.FindElement(By.ClassName("wp-first-item current"));

        public IWebElement SelectFiles =>
               Browser.Instance.Driver.FindElement(By.Id("plupload-browse-button"));
    }
}