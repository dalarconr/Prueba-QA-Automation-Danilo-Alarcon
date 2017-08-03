using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeasQAAutoDanilo1.Pages;
using TestBrowser2.TestingTools;

namespace TeasQAAutoDanilo1.Transactions
{
    public class ModalTransactions
    {
        private ModalPage page;

        public ModalTransactions()
        {
            this.page = new ModalPage();
        }

        public HomeTransactions NewEmailSend()
        {
            this.page.AsuntoTxt.SendKeys("Prueba automatica Danilo&&Alarcon");
            this.page.ParaTxt.SendKeys("escarpo@gmail.com");
            this.page.BodyEmailTxt.SendKeys("Prueba automatica Danilo&&Alarcon");
            this.page.SendEmailBtn.Click();

            return new HomeTransactions();
        }
    }
}