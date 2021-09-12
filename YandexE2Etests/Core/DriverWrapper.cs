using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexE2Etests.Core
{
   public class DriverWrapper
    {
        IWebDriver driver;
        string url = ConfigurationManager.AppSettings["URL"];
        private static readonly Lazy<DriverWrapper> lazy =
     new Lazy<DriverWrapper>(() => new DriverWrapper());

        private static readonly object ThreadLock = new object();
        public IWebDriver CurrentDriver => GetDriver();

        private DriverWrapper()
        {

        }

        public IWebDriver GetDriver()
        {

            if (driver == null)
            {
                lock (ThreadLock)
                {
                    driver = new ChromeDriver();

                    driver.Url = url;

                    driver.Manage().Window.Maximize();
                }
            }
            return driver;
        }

        public static DriverWrapper GetInstance()
        {
            return lazy.Value;
        }
        

        public void Quit()
        {
            if (driver == null)
                return;

            else
            {         
                driver.Quit();
                driver = null;
            }

        }

    }
}
