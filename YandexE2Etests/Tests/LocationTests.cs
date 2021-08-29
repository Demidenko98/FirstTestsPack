using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexE2Etests.Pages;

namespace YandexE2Etests.Tests
{
    [TestFixture]
    class LocationTests
    {
        MainPage mainPage = new MainPage();

        [Test]
        public void ChangeLocationAndCheckElsePopUp()
        {
            mainPage.ChangeLocationOnMainPage("Лондон");
            string[] londonElsePopupContent = mainPage.GetAllElementsFromPopUp();

            mainPage.ChangeLocationOnMainPage("Париж");
            string[] parisElsePopupContent = mainPage.GetAllElementsFromPopUp();

            CollectionAssert.AreEqual(londonElsePopupContent, parisElsePopupContent); //Comparing that londonElsePopupContent array mathes to the parisElsePopupContent
        }
    }
}
