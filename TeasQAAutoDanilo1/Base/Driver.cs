﻿namespace TestBrowser2.Base
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Support.UI;
    using UiTestBomgar.Base;

    public static class Driver
    {
        private static IWebDriver browser;
        private static WebDriverWait browserWait;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }

                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType, int defaultTimeOut)
        {
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    Driver.Browser = new FirefoxDriver();
                    break;

                case BrowserTypes.InternetExplorer:
                    Driver.Browser = new InternetExplorerDriver();
                    break;

                case BrowserTypes.Chrome:
                    Driver.Browser = new ChromeDriver();
                    break;

                default:
                    break;
            }

            BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(defaultTimeOut));
        }

        public static void StartChromeBrowser()
            => StartBrowser(BrowserTypes.Chrome, 30);

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}