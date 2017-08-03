using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestBrowser2.Pages;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Transactions
{
    public class Mediatransaction
    {
        private MediaPage page;

        public Mediatransaction()
        {
            this.page = new MediaPage();
        }

        public Mediatransaction GotoImage()
        {
            this.page.AddNewMediaLk.Click();
            this.page.SelectFiles.Click();
            var f = Directory.GetFiles("C:\\Users\\DALARCONR\\Documents\\Visual Studio 2015\\Projects\\Solution1\\TestQAAutomationDanilo2\\Image", "*.*", SearchOption.AllDirectories)
                .ToList();
            return this;
        }

        public NewPostTransactions PublishPost()
        {
            this.page.AllPost.Click();
            return new NewPostTransactions();
        }
    }
}