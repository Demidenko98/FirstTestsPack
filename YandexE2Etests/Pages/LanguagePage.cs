using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexE2Etests.Pages
{
    class LanguagePage
    {   
       public readonly By openDropDownBtnLocOnLanguagePage = By.XPath("//*[@class='button select__button button_theme_normal button_arrow_down button_size_m i-bem button_js_inited']");   
       public readonly By enLangBtnLoc = By.XPath("//*[@class='select__list']/div[6]"); 
       public readonly By saveLangBtnLocOnLanguagePage =By.XPath("//*[@type='submit']");  
    }
}
