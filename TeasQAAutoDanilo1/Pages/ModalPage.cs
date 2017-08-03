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
    public class ModalPage
    {
        public IWebElement AsuntoTxt =>
        Browser.Instance.Wait.Until
     (ExpectedConditions.ElementToBeClickable(By.Id(":m6")));

        public IWebElement BodyEmailTxt =>
             Browser.Instance.Wait.Until
    (ExpectedConditions.ElementToBeClickable(By.Id(":oo")));

        public IWebElement ParaTxt =>
              Browser.Instance.Wait.Until
     (ExpectedConditions.ElementToBeClickable(By.Id(":lp")));

        public IWebElement SendEmailBtn =>
             Browser.Instance.Wait.Until
    (ExpectedConditions.ElementToBeClickable(By.Id(":mb")));
    }
}