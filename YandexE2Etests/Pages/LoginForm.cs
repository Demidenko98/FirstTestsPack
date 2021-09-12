using OpenQA.Selenium;
using Microsoft.Extensions.Configuration;
using System.Configuration;
namespace YandexE2Etests.Pages

{
   public class LoginForm : BasePage
    {
        public readonly By enterButtonOnMainPageLocator = By.XPath("//*[@data-statlog='notifications.mail.logout.enter']");
        public readonly By loginFormLocator = By.ClassName("Textinput-Control");
        public readonly By passwdFormLocator = By.Name("passwd");
        public readonly By enterButtonOnLoginFormLocator = By.XPath("//*[@data-t='button:action:passp:sign-in']");

        public readonly By wrongLoginMessageLocator = By.XPath("//*[@id='field:input-login:hint']");
        public readonly By accountNameLocator = By.XPath("//*[@class='username desk-notif-card__user-name']");
        public readonly By wrongPassMessageLocator = By.XPath("//*[@id='field:input-passwd:hint']");
        public readonly By logOutButtonLocator = By.XPath("//*[@aria-label='Выйти']");
        public readonly By accountNameAfterLogOut = By.XPath("//*[@data-statlog='notifications.mail.logout.enter']/div[2]");


        string email = ConfigurationManager.AppSettings["email"];
        string password = ConfigurationManager.AppSettings["password"];

       
        public void Authorization()
        {
            BasePage basePage = new BasePage();
            basePage.ButtonClick(enterButtonOnMainPageLocator);
            EnterLogin();
            basePage.ButtonClick(enterButtonOnLoginFormLocator);
            EnterPassword();
            basePage.ButtonClick(enterButtonOnLoginFormLocator);
        }

        public void EnterLogin()
        {
            SendKeys(loginFormLocator, email);
        }
        public void EnterPassword()
        {
            SendKeys(passwdFormLocator, password);
        }

    }
}
