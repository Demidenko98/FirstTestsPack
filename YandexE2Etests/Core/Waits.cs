using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexE2Etests.Core
{
   public class Waits
    {
        IWebDriver insDriver = DriverWrapper.GetInstance().CurrentDriver;
        public IWebElement ElementIsVisible(By locator)
        {

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(insDriver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));

            //WebDriverWait wait = new WebDriverWait(insDriver, TimeSpan.FromSeconds(10));
            //IWebElement searchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            //return searchResult;
        }

        public void ElementWithTextIsVisible(By locator, string text)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(insDriver)
            {
                Timeout = TimeSpan.FromSeconds(10),
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(locator, text));
        }

        public IWebElement ElementIsClickable(By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(insDriver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
