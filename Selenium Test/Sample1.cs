using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Test
{
    internal class Sample1
    {
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Intialize()

        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void Execiute()
        {
            IWebElement ele = driver.FindElement(By.Id("email"));
            ele.SendKeys("xyz11@gmail.com");
            Thread.Sleep(2000);
            Console.WriteLine("Username is entered");
            IWebElement ele1 = driver.FindElement(By.Id("pass"));
            ele1.SendKeys("12345");
            Thread.Sleep(3000);
            Console.WriteLine("Password is entered");
            IWebElement ele3 = driver.FindElement(By.Name("login"));
            ele3.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Login button is clicked");
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();

        }

    }
}
