using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_Test
{
    internal class Sample2
    {

        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {

             driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }



    }
}
