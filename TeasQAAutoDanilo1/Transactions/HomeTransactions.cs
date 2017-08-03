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
    public class HomeTransactions
    {
        private HomePage page;

        public HomeTransactions()
        {
            this.page = new HomePage();
        }

        public string CheckRecordsInGrid()
        {
            return this.page.RecordsPage.Text;
        }

        public HomeTransactions DragEmailDropTrash()
        {
            var email = this.page.FirstElement;
            var trash = this.page.Trash;
            Actions builder = new Actions(Browser.Instance.Driver);

            IAction dragAndDrop = builder.ClickAndHold(email)
               .MoveToElement(trash)
               .Release(trash)
               .Build();

            dragAndDrop.Perform();

            return this;
        }

        public HomeTransactions DragTrashDropEmail()
        {
            this.page.Trash.Click();
            var email = this.page.FirstElement;
            var received = this.page.Received;
            Actions builder = new Actions(Browser.Instance.Driver);

            IAction dragAndDrop = builder.ClickAndHold(email)
               .MoveToElement(received)
               .Release(received)
               .Build();

            dragAndDrop.Perform();

            return this;
        }

        public ModalTransactions NewEmail()
        {
            this.page.RedactarButton.Click();

            return new ModalTransactions();
        }

        public HomeTransactions ValidaSentEmail()
        {
            this.page.SearchTxt.SendKeys("prueba_QA_automation_Danilo Alarcon");
            this.page.SearchBtn.Click();

            return this;
        }
    }
}