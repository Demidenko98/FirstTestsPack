using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
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
    [AllureNUnit]
    //[Parallelizable(ParallelScope.Children)]
    public class YandexNavigationTests: BaseTests
    {

        BasePage basePage = new BasePage();
        MainPage mainPage = new MainPage();

       
        [Test(Description = "Video Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
       // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("Assert")]
        public void VideoNavigation()
        {
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.videoButtonOnMainPage);
            basePage.GoToFrame(1);
            By videoButtonOnVideoPage = By.XPath("//*[@class='tabs-navigation__tab-over-inner']");
            string videoText = basePage.GetText(videoButtonOnVideoPage);
            Assert.AreEqual("Видео", videoText);   //The text "Видео" is present on opened page
        }

        [Test(Description = "Pictures Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.blocker)]
        [AllureIssue("ISSUE-1")]
        // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("Assert")]
        public void PicturesNavigation()
        {
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.picturesButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedImagePageUrl = "https://yandex.by/images/?utm_source=main_stripe_big";
            string actualImagePageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedImagePageUrl, actualImagePageUrl);   //The expectedImagePageUrl mathes to the actualImagePageUrl on opened page

        }


        // [NonParallelizable]
        [Test(Description = "News Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureIssue("ISSUE-1")]
        // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("Assert")]
        public void NewsNavigation()
        {
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.newsButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedNewsPageUrl = "https://yandex.by/news/?utm_source=main_stripe_big";
            string actualNewsPageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedNewsPageUrl, actualNewsPageUrl);  //The expectedNewsPageUrl mathes to the actualNewsPageUrl on opened page
        }


        [Test(Description = "Maps Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureIssue("ISSUE-1")]
        // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("Assert")]
        public void MapsNavigation()
        {
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.mapsButtonOnMainPage);
            basePage.GoToFrame(1);
            string actualMapsPageUrl = basePage.GetUrl();
            StringAssert.Contains("https://yandex.by/maps", actualMapsPageUrl);   //actualMapsPageUrl contains a substring https://yandex.by/maps
        }


        [Test(Description = "Market Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureIssue("ISSUE-1")]
        // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("NoAssert")]
        public void MarketNavigation()
        {
            basePage.GoToFrame(0);
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.marketButtonOnMainPage);
            basePage.GoToFrame(1);
            basePage.ElementIsDisplayed(By.Id("logoPartMarket")); //marketLogo is present on opened page 
        }

        [Test(Description = "Translate Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureIssue("ISSUE-1")]
        // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("Assert")]
        public void TranslateNavigation()
        {
            basePage.GoToFrame(0);
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.translateButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedTranslatePageUrl = "https://translate.yandex.by/?utm_source=main_stripe_big";
            string actualTranslatePageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedTranslatePageUrl, actualTranslatePageUrl);  // The expectedTranslatePageUrl mathes to the actualTranslatePageUrl on opened page
        }

       
        [Test(Description = "Music Navigation")]
        [AllureTag("Functional")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureIssue("ISSUE-1")]
        // [AllureTms("TMS-12")]
        [AllureOwner("Philip")]
        [AllureSuite("Navigation")]
        [AllureSubSuite("Assert")]
        public void MusicNavigation()
        {
            basePage.GoToFrame(0);
            basePage.ButtonClick(mainPage.musicButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedMusicPageUrl = "https://music.yandex.by/home?utm_source=main_stripe_big";
            string actualMusicPageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedMusicPageUrl, actualMusicPageUrl);  // The expectedMusicPageUrl mathes to the actualMusicPageUrl on opened page
        }

    }
}
