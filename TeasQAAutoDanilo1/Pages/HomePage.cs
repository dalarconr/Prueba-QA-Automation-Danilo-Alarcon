using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TeasQAAutoDanilo1.Pages
{
    public class HomePage
    {
        public IWebElement FirstElement =>
             Browser.Instance.Driver.FindElement(By.XPath(".//*[@id=':iw']/div/div[2]/span/a"));

        public IWebElement Received =>
            Browser.Instance.Driver.FindElement(By.XPath(".//*[@id=':iw']/div/div[2]/span/a"));

        public IWebElement RecordsPage =>
                     Browser.Instance.Driver.FindElement(By.Id(":ii"));

        public IWebElement RedactarButton =>
             Browser.Instance.Driver.FindElement(By.ClassName("T-I J-J5-Ji T-I-KE L3"));

        public IWebElement SearchBtn =>
                            Browser.Instance.Driver.FindElement(By.Id("gbqfb"));

        public IWebElement SearchTxt =>
             Browser.Instance.Driver.FindElement(By.Id("gbqfq"));

        public IWebElement Trash =>
             Browser.Instance.Driver.FindElement(By.ClassName("J-Ke n0 aBU"));
    }
}