using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexE2Etests.Core
{
    class DriverWrapper
    {
        IWebDriver driver;

        private static readonly Lazy<DriverWrapper> lazy =
     new Lazy<DriverWrapper>(() => new DriverWrapper());

        public IWebDriver CurrentDriver => GetDriver();

        public IWebDriver GetDriver()
        {

            if (driver == null)
            {
                driver = new ChromeDriver();

                driver.Url = "https://yandex.by/";

                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static DriverWrapper GetInstance()
        {
            return lazy.Value;
        }

        public string GetUrl()
        {
            return driver.Url;
        }

        public void Close()
        {

            if (driver == null)
                return;

            else
            {
                driver.Close();
                driver = null;
            }

        }

    }
}
