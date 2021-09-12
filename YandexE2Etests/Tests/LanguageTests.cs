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
   public class LanguageTests: BaseTests
   {
      
        [Test]
        public void SwitchLanguageToEn()
        {
            MainPage mainPage = new MainPage();
            BasePage basePage = new BasePage();
            LanguagePage languagePage = new LanguagePage();
            basePage.ButtonClick(mainPage.languageBtnLocatorOnMainPage);
            basePage.ButtonClick(mainPage.elseBtnLocatorOnMainPage);
            basePage.ButtonClick(languagePage.openDropDownBtnLocOnLanguagePage);   
            basePage.ButtonClick(languagePage.enLangBtnLoc); 
            basePage.ButtonClick(languagePage.saveLangBtnLocOnLanguagePage); 
            string actualLangText = basePage.GetText(mainPage.languageBtnLocatorOnMainPage);
            Assert.AreEqual("En", actualLangText);// Comparing expected language mathes to the actualLangText

        }

   }
}
