using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YandexE2Etests.Core;

namespace YandexE2Etests.Pages
{
    public class MainPage: BasePage
    {
        IWebDriver insDriver = DriverWrapper.GetInstance().CurrentDriver;
       

        By elseBtnOnMainPageLoc = By.XPath("//*[@data-statlog='services_new.more']");
        By cityOnMainPageLoc = By.ClassName("geolink__reg");
        By inputCityFieldOnGeoPageLoc = By.XPath("//*[@class='input__control input__input']");
        By firstCityinDropdownLoc = By.XPath("//*[@class='popup__content']/ul/li[1]/div[1]");

        public readonly By videoButtonOnMainPage = By.XPath("//*[@data-id='video']");
        public readonly By picturesButtonOnMainPage = By.XPath("//*[@data-id='images']");
        public readonly By newsButtonOnMainPage = By.XPath("//*[@data-id='news']");
        public readonly By mapsButtonOnMainPage = By.XPath("//*[@data-id='maps']");
        public readonly By marketButtonOnMainPage = By.XPath("//*[@data-id='market']");
        public readonly By translateButtonOnMainPage = By.XPath("//*[@data-id='translate']");
        public readonly By musicButtonOnMainPage = By.XPath("//*[@data-id='music']");

        public readonly By languageBtnLocatorOnMainPage = By.XPath("//*[@title='Выбрать язык']");
        public readonly By elseBtnLocatorOnMainPage = By.XPath("//*[@data-statlog='head.lang.more']");

        public string[] GetAllElementsFromPopUp()
        {
          
            ButtonClick(elseBtnOnMainPageLoc);  //открываю поп ап еще
            IList<IWebElement> all = insDriver.FindElements(By.XPath("//*[@class='services-new__more-popup-content']"));

            string[] allText = new string[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }
            return allText;
        }


        public void ChangeLocationOnMainPage(string city)
        {
          
            ButtonClick(cityOnMainPageLoc);
            ClearInputField(inputCityFieldOnGeoPageLoc);       
            SendKeys(inputCityFieldOnGeoPageLoc, city);
           
            if (city == "Париж")
            {
                ElementWithDefinedTextIsVisible(firstCityinDropdownLoc, "Париж");
                ButtonClick(firstCityinDropdownLoc);
            }
            else if (city == "Лондон")
            {
                ElementWithDefinedTextIsVisible(firstCityinDropdownLoc, "Лондон");
                ButtonClick(firstCityinDropdownLoc);
            }

        }
    }
}
