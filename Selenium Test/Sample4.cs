using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Test
{
    internal class Sample4
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void ExecuteTest()
        {
            driver.Url = "https://demoqa.com/browser-windows";
            driver.FindElement(By.XPath("//button[@id='windowButton']")).Click();
            Thread.Sleep(2000);
            driver.Quit();


        }
    }
}
