using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBrowser2.TestingTools;

namespace TestBrowser2.Pages
{
    public class NewPostPage
    {
        public IWebElement AddNewPostLk =>
                Browser.Instance.Wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("current")));

        public IWebElement AddNewTitleTxt =>
                Browser.Instance.Driver.FindElement(By.Id("title"));

        public IWebElement BlackWordLk =>
                Browser.Instance.Driver.FindElement(By.Id("qt_content_strong"));

        public IWebElement CategorizePostClk =>
               Browser.Instance.Driver.FindElement(By.Id("in-category-4"));

        public IWebElement ContentHtml =>
               Browser.Instance.Driver.FindElement(By.Id("content-html"));

        public IWebElement ContentVisual =>
                Browser.Instance.Driver.FindElement(By.Id("content-tmce"));

        public IWebElement CursiveWordLk =>
               Browser.Instance.Driver.FindElement(By.Id("qt_content_em"));

        public IWebElement EditPublishLk =>
               Browser.Instance.Driver.FindElement(By.ClassName("edit-visibility hide-if-no-js"));

        public IWebElement MediaLk =>
               Browser.Instance.Driver.FindElement(By.ClassName("wp-has-submenu wp-not-current-submenu menu-top menu-icon-media"));

        public IWebElement NewPostLk =>
                       Browser.Instance.Driver.FindElement(By.ClassName("wp-has-submenu wp-has-current-submenu wp-menu-open open-if-no-js menu-top menu-icon-post menu-top-first"));

        public IWebElement NewTagsBtn =>
               Browser.Instance.Driver.FindElement(By.Id("button tagadd"));

        public IWebElement NewTagsTxt =>
              Browser.Instance.Driver.FindElement(By.Id("new-tag-post_tag"));

        public IWebElement OkStickyBtn =>
             Browser.Instance.Driver.FindElement(By.Id("save-post-visibility hide-if-no-js button"));

        public IWebElement PublishBtn =>
                Browser.Instance.Driver.FindElement(By.Id("publish"));

        public IWebElement StickyPublishClk =>
               Browser.Instance.Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("sticky")));

        public IWebElement TextArea =>
                Browser.Instance.Driver.FindElement(By.Id("content"));

        public IWebElement TrashDefinitiveLinkk =>
              Browser.Instance.Wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("submitdelete")));

        public IWebElement TrashDefinitiveTitleLk =>
               Browser.Instance.Wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("row-title")));

        public IWebElement TrashLk =>
                Browser.Instance.Driver.FindElement(By.ClassName("submitdelete deletion"));
    }
}