using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexE2Etests.Core;

namespace YandexE2Etests.Pages
{
    class BasePage
    {
        Waits waits = new Waits();

        IWebDriver InsDriver = DriverWrapper.GetInstance().CurrentDriver;
        public string GetText(By locator)
        {
            return waits.ElementIsVisible(locator).Text;
        }

        public void SendKeys(By locator, string text)
        {
            waits.ElementIsVisible(locator).SendKeys(text);
        }

        public void ButtonClick(By locator)
        {
            waits.ElementIsClickable(locator).Click();
        }

        public string GetUrl()
        {
            return InsDriver.Url;
        }

        public void GoToFrame(int framenumber)
        {
            InsDriver.SwitchTo().Window(InsDriver.WindowHandles[framenumber]);
        }

        public void SwitchToParentVideo()
        {
            string winHandleBefore = InsDriver.CurrentWindowHandle;

            InsDriver.SwitchTo().Window(winHandleBefore); 
        }

        public void ElementIsDisplayed(By locator)
        {
            waits.ElementIsVisible(locator);
        }



    }
}
