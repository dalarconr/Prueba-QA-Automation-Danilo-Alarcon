using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace TestBrowser2.TestingTools
{
    public class Browser
    {
        private static readonly Lazy<Browser> instance =
            new Lazy<Browser>(() => new Browser());

        private static Browser myInstnace;
        private BrowserType browserType;
        private IWebDriver driver;
        private WebDriverWait wait;

        private Browser()
        {
            this.browserType = BrowserType.None;
        }

        public static Browser Instance
            => instance.Value;

        public static Browser Instances
        {
            get
            {
                if (myInstnace == null)
                {
                    myInstnace = new Browser();
                }

                return myInstnace;
            }
        }

        public BrowserType BrowserType
        {
            get
            {
                return this.BrowserType;
            }
            set
            {
                if (this.browserType == BrowserType.None && value != BrowserType.None)
                {
                    this.browserType = value;
                    InstanceBrowser();
                }
            }
        }

        public IWebDriver Driver
        {
            get
            {
                if (this.driver == null)
                {
                    new NullReferenceException("The driver is not instanced");
                }

                return this.driver;
            }
            private set
            {
                this.driver = value;
                this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(30));
                //this.wait = new WebDriverWait(this.driver, TimeSpan.FromDays(1));
            }
        }

        public object Until { get; internal set; }

        public WebDriverWait Wait
        {
            get
            {
                if (this.wait == null)
                {
                    new NullReferenceException("The web driver wait is not instanced");
                }

                return this.wait;
            }
            private set
            {
                this.wait = value;
            }
        }

        public void Dispose()
        {
            this.driver = null;
            this.wait = null;
            this.browserType = BrowserType.None;
        }

        public void Start()
        {
            this.driver.Navigate().GoToUrl("demosite.center/wordpress/wp-login.php");
            this.driver.Manage().Window.Maximize();
        }

        private void InstanceBrowser()
        {
            switch (this.browserType)
            {
                case BrowserType.Chrome:
                    this.Driver = new ChromeDriver();
                    break;

                case BrowserType.Firefox:
                    this.Driver = new FirefoxDriver();
                    break;

                case BrowserType.InternetExplorer:
                    this.Driver = new InternetExplorerDriver();
                    break;

                default:
                    new NotImplementedException($"The {this.browserType} type is not supported");
                    break;
            }
        }
    }
}