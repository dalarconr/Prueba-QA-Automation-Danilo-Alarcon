using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.Pages;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Transactions
{
    public class HomeTransactions
    {
        private HomePage page;

        public HomeTransactions()
        {
            this.page = new HomePage();
        }

        public NewPostTransactions NewPost()
        {
            this.page.NewPostLk.Click();

            return new NewPostTransactions();
        }
    }
}