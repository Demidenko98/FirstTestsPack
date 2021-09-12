using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexE2Etests.Pages;
using YandexE2Etests.Core;

namespace YandexE2Etests.Tests
{
    [TestFixture]
   public class LocationTests: BaseTests
    {

        [Test]
        public void ChangeLocationAndCheckElsePopUp()
        {
            MainPage mainPage = new MainPage();
            mainPage.ChangeLocationOnMainPage(Variables.londonCity);
            string[] londonElsePopupContent = mainPage.GetAllElementsFromPopUp();

            mainPage.ChangeLocationOnMainPage(Variables.parisCity);
            string[] parisElsePopupContent = mainPage.GetAllElementsFromPopUp();

            CollectionAssert.AreEqual(londonElsePopupContent, parisElsePopupContent); //Comparing that londonElsePopupContent array mathes to the parisElsePopupContent
        }
    }
}
