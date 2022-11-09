using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Test
{
    internal class Sample3
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new FirefoxDriver();

        }
        [Test]
        public void Test()
        {
            driver.Url = "https://demoqa.com/";
            String Title = driver.Title;
            int TitleLength = driver.Title.Length;
            Console.WriteLine("Title of the page is : " + Title);
            Console.WriteLine("Length of the Title is : " + TitleLength);
            String PageURL = driver.Url;
            int URLLength = PageURL.Length;
            Console.WriteLine("URL of the page is : " + PageURL);
            Console.WriteLine("Length of the URL is : " + URLLength);
            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            Console.WriteLine("Page Source of the page is : " + PageSource);
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);
            bool staus1 = driver.FindElement(By.XPath("//h5[text()='Elements']")).Displayed;
            Console.WriteLine(staus1);
            bool status=driver.FindElement(By.XPath("//h5[text()='Forms']")).Enabled;
            Console.WriteLine(status);
            driver.Url = "https://demoqa.com/radio-button";
            bool status2 = driver.FindElement(By.XPath("//label[@for='impressiveRadio']")).Selected;
            Console.WriteLine(status2);
            driver.Url = "https://demoqa.com/links";
            IWebElement Linktext = driver.FindElement(By.XPath("//a[@id='dynamicLink']"));
            String text = Linktext.Text;
            Console.WriteLine(text);
            driver.Quit();


        }



    }
}
