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
    //[Parallelizable(ParallelScope.Self)]
    class YandexNavigationTests
    {

        BasePage basePage = new BasePage();
        MainPage mainPage = new MainPage();

        [Test]
        public void VideoNavigation()
        {
            basePage.ButtonClick(mainPage.videoButtonOnMainPage);
            basePage.GoToFrame(1);
            By videoButtonOnVideoPage = By.XPath("//*[@class='tabs-navigation__tab-over-inner']");
            string videoText = basePage.GetText(videoButtonOnVideoPage);
            Assert.AreEqual("Видео", videoText);   //The text "Видео" is present on opened page
        }

        [Test]
        public void PicturesNavigation()
        {
            basePage.ButtonClick(mainPage.picturesButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedImagePageUrl = "https://yandex.by/images/?utm_source=main_stripe_big";
            string actualImagePageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedImagePageUrl, actualImagePageUrl);   //The expectedImagePageUrl mathes to the actualImagePageUrl on opened page

        }

        [Test]
        public void NewsNavigation()
        {

            basePage.ButtonClick(mainPage.newsButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedNewsPageUrl = "https://yandex.by/news/?utm_source=main_stripe_big";
            string actualNewsPageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedNewsPageUrl, actualNewsPageUrl);  //The expectedNewsPageUrl mathes to the actualNewsPageUrl on opened page
        }

        [Test]
        public void MapsNavigation()
        {
            basePage.ButtonClick(mainPage.mapsButtonOnMainPage);
            basePage.GoToFrame(1);
            string actualMapsPageUrl = basePage.GetUrl();
            StringAssert.Contains("https://yandex.by/maps", actualMapsPageUrl);   //actualMapsPageUrl contains a substring https://yandex.by/maps
        }


        [Test]
        public void MarketNavigation()
        {
            basePage.ButtonClick(mainPage.marketButtonOnMainPage);
            basePage.GoToFrame(1);
            basePage.ElementIsDisplayed(By.Id("logoPartMarket")); //marketLogo is present on opened page 
        }

        [Test]
        public void TranslateNavigation()
        {
            basePage.ButtonClick(mainPage.translateButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedTranslatePageUrl = "https://translate.yandex.by/?utm_source=main_stripe_big";
            string actualTranslatePageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedTranslatePageUrl, actualTranslatePageUrl);  // The expectedTranslatePageUrl mathes to the actualTranslatePageUrl on opened page
        }

        [Test]
        public void MusicNavigation()
        {
            basePage.ButtonClick(mainPage.musicButtonOnMainPage);
            basePage.GoToFrame(1);
            string expectedMusicPageUrl = "https://music.yandex.by/home?utm_source=main_stripe_big";
            string actualMusicPageUrl = basePage.GetUrl();
            Assert.AreEqual(expectedMusicPageUrl, actualMusicPageUrl);  // The expectedMusicPageUrl mathes to the actualMusicPageUrl on opened page
        }

    }
}
