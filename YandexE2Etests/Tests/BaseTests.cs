using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexE2Etests.Core;


namespace YandexE2Etests
{
    
    public class BaseTests
    {

        DriverWrapper driver = DriverWrapper.GetInstance();

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //   driver.GetDriver();
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
