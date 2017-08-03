using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestBrowser2.Transactions;
using TestBrowser2.TestingTools;

namespace TestBrowser2
{
    [TestFixture]
    internal class UITestsWordPress
    {
        [SetUp]
        public void Setup()
        {
            Browser.Instance.BrowserType = BrowserType.Chrome;
            Browser.Instance.Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDowm()
        {
            Browser.Instance.Driver.Quit();
            Browser.Instance.Dispose();
        }

        [Test]
        public void TestDeletePost()
        {
            LoginTransaction logIn = new LoginTransaction();
            string postNameResult =
            logIn.OpenUrl()
            .GotoLogin()
            .NewPost()
            .TrashPostDefinitive()
            .CheckNamePost();

            Screenshot ss = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
            ss.SaveAsFile(@"D:\ImagendePrueba.png", ImageFormat.Jpeg);
        }

        [Test]
        public void TestValidatePost()
        {
            string newPostName = RandomString.GenerateRandomString(8);
            LoginTransaction logIn = new LoginTransaction();
            string postNameResult =
            logIn.OpenUrl()
            .GotoLogin()
            .NewPost()
            .AddPost()
            .FillThePost(newPostName)
            .ChangeVisisbility()
            .CategorizePost()
            .InsertImage()
            .GotoImage()
            .PublishPost()
            .CheckNamePost();

            Screenshot ss = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
            ss.SaveAsFile(@"D:\ImagendePrueba.png", ImageFormat.Jpeg);

            Assert.AreEqual(postNameResult, newPostName);
        }
    }
}