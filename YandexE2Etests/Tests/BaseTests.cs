using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YandexE2Etests.Core;
using YandexE2Etests.Pages;

namespace YandexE2Etests
{
    
    public class BaseTests
    {

       protected DriverWrapper driver =  DriverWrapper.GetInstance();

        [SetUp]
        public void OneTimeSetUp()
        {
            
        }


        [TearDown]
        public void QuitBrowser()
        {
            driver.Quit();
        }

    }
}
