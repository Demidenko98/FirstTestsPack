using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexE2Etests.Pages;

namespace YandexE2Etests.Tests
{
    [TestFixture]
    class LanguageTests
    {
        MainPage mainPage = new MainPage();
        BasePage basePage = new BasePage();

        [Test]
        public void SwitchLanguageToEn()
        {
            basePage.ButtonClick(mainPage.languageBtnLocatorOnMainPage);
            basePage.ButtonClick(mainPage.elseBtnLocatorOnMainPage);
            basePage.ButtonClick(By.XPath("//*[@class='button select__button button_theme_normal button_arrow_down button_size_m i-bem button_js_inited']")); //openDropDownBtnLocOnLanguagePage  
            basePage.ButtonClick(By.XPath("//*[@class='select__list']/div[6]")); //enLangBtnLoc
            basePage.ButtonClick(By.XPath("//*[@type='submit']")); // saveLangBtnLocOnLangiagePage
            string actualLangText = basePage.GetText(mainPage.languageBtnLocatorOnMainPage);
            Assert.AreEqual("En", actualLangText);// Comparing expected language mathes to the actualLangText

        }

    }
}
