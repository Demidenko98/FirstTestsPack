using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexE2Etests.Core;

namespace YandexE2Etests.Pages
{
   public class BasePage: Waits
    {
       

        IWebDriver insDriver = DriverWrapper.GetInstance().CurrentDriver;
        public string GetText(By locator)
        {
            return ElementIsVisible(locator).Text;
        }

        public void SendKeys(By locator, string text)
        {
            ElementIsVisible(locator).SendKeys(text);
        }

        public void ButtonClick(By locator)
        {
            ElementIsClickable(locator).Click();
        }

        public string GetUrl()
        {
            return insDriver.Url;
        }

        public void GoToFrame(int framenumber)
        {
            insDriver.SwitchTo().Window(insDriver.WindowHandles[framenumber]);
        }

        public void ElementWithDefinedTextIsVisible(By locator, string text)
        {
            ElementWithTextIsVisible(locator, text);
        }


        public void ElementIsDisplayed(By locator)
        {
            ElementIsVisible(locator);
        }

        public void ClearInputField(By locator)
        {
            ElementIsVisible(locator).Clear();
           
        }



    }
}
