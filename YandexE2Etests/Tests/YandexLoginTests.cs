using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using YandexE2Etests.Pages;

namespace YandexE2Etests.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class YandexLoginTests: BaseTests
    {

        [Test]
        public void LogInAndCheckAccName()
        {
            LoginForm loginForm = new LoginForm();
            BasePage basePage = new BasePage();
            loginForm.Authorization();
            string accountName = basePage.GetText(loginForm.accountNameLocator);
            Assert.AreEqual("here is my login", accountName);  //Comparing That user is authorized and his nickname is displayed on page
        }


        [Test]
        public void CheckIfUserCanLogOut()
        {
            LoginForm loginForm = new LoginForm();
            BasePage basePage = new BasePage();
            loginForm.Authorization();
            basePage.ButtonClick(loginForm.accountNameLocator);
            basePage.ButtonClick(loginForm.logOutButtonLocator);
            string accNameAfterLogout = basePage.GetText(loginForm.accountNameAfterLogOut);
            Assert.AreEqual("Войти", accNameAfterLogout);  // Comparing That user is authorized and his nickname isn't displayed on page
        }


        [Test]
        public void InvalidPass()
        {
            LoginForm loginForm = new LoginForm();
            BasePage basePage = new BasePage();
            basePage.ButtonClick(loginForm.enterButtonOnMainPageLocator);
            loginForm.EnterLogin();
            basePage.ButtonClick(loginForm.enterButtonOnLoginFormLocator);
            loginForm.EnterPassword();
            basePage.ButtonClick(loginForm.enterButtonOnLoginFormLocator);
            string WrongPassMessage = basePage.GetText(loginForm.wrongPassMessageLocator);
            Assert.AreEqual("Неверный пароль", WrongPassMessage);  //Check is user can't log in with a wrong password and appropriate message is displayed
        }

        [Test]
        public void InvalidLogin()
        {
            LoginForm loginForm = new LoginForm();
            BasePage basePage = new BasePage();          
            basePage.ButtonClick(loginForm.enterButtonOnMainPageLocator);
            loginForm.EnterLogin();
            basePage.ButtonClick(loginForm.enterButtonOnLoginFormLocator);
            string WrongLoginMessage = basePage.GetText(loginForm.wrongLoginMessageLocator);
            Assert.AreEqual("Такого аккаунта нет", WrongLoginMessage); //Check is user can't log in with a wrong login and appropriate message is displayed
        }

    }
}
