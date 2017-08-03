using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.Pages;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Transactions
{
    public class NewPostTransactions
    {
        private NewPostPage page;

        public NewPostTransactions()
        {
            this.page = new NewPostPage();
        }

        public NewPostTransactions AddPost()
        {
            this.page.NewPostLk.Click();
            this.page.AddNewPostLk.Click();
            return this;
        }

        public NewPostTransactions AddTags(string tagname)
        {
            this.page.NewTagsTxt.SendKeys(tagname + "T1");
            this.page.NewTagsBtn.Click();
            this.page.NewTagsTxt.SendKeys(tagname + "T2");
            this.page.NewTagsBtn.Click();
            this.page.NewTagsTxt.SendKeys(tagname + "T3");
            return this;
        }

        public NewPostTransactions CategorizePost()
        {
            this.page.CategorizePostClk.Click();
            return this;
        }

        public NewPostTransactions ChangeVisisbility()
        {
            this.page.EditPublishLk.Click();
            this.page.StickyPublishClk.Click();
            return this;
        }

        public string CheckNamePost()
        {
            return this.page.AddNewTitleTxt.Text;
        }

        public NewPostTransactions FillThePost(string newpostname)
        {
            this.page.ContentHtml.Click();
            this.page.BlackWordLk.Click();
            this.page.AddNewTitleTxt.SendKeys(newpostname);
            this.page.TextArea.SendKeys("Esta es la la letra en negrita");
            this.page.CursiveWordLk.Click();
            this.page.TextArea.SendKeys("Esta es la la letra en cursiva");
            return this;
        }

        public Mediatransaction InsertImage()
        {
            this.page.MediaLk.Click();

            return new Mediatransaction();
        }

        public NewPostTransactions PublishPost()
        {
            this.page.PublishBtn.Click();
            return this;
        }

        public NewPostTransactions TrashPost()
        {
            this.page.TrashLk.Click();

            return this;
        }

        public NewPostTransactions TrashPostDefinitive()
        {
            Actions overAction = new Actions(Browser.Instance.Driver);
            overAction.MoveToElement(page.TrashDefinitiveTitleLk).Perform();
            page.TrashDefinitiveLinkk.Click();

            return this;
        }
    }
}