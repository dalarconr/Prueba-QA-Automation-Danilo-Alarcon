using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using TeasQAAutoDanilo1.Transactions;
using TestBrowser2.TestingTools;

namespace TeasQAAutoDanilo1
{
    [TestFixture]
    internal class UITestsEmail
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
        public void ValidaEmailDragAndDrop()
        {
            FirstLoginTransaction LogIn = new FirstLoginTransaction();
            string valida_email =

                LogIn.OpenUrl()
                .FirstAuthentication()
                .GotoEmail()
                .NewEmail()
                .NewEmailSend()
                .ValidaSentEmail()
                .DragEmailDropTrash()
                .DragTrashDropEmail()
                .CheckRecordsInGrid();
            Screenshot ss = ((ITakesScreenshot)Browser.Instance.Driver).GetScreenshot();
            ss.SaveAsFile(@"D:\ImagendePrueba.png", ImageFormat.Jpeg);

            Assert.AreEqual("1-1 de 1", valida_email);
        }
    }
}