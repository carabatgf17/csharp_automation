using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleProj
{
    class TestCase1

    {
        static public FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"c:\unu");
        static public FirefoxOptions options = new FirefoxOptions();
        static public IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));

        //open page
        [Test]
        public void PageOpen()
        {

            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
        }

        // get title
        [Test]
        public void PageTitle()

        {
            driver.Title.ToString();
            Assert.AreEqual("Selenium Easy Demo - Simple Form to Automate using Selenium", driver.Title.ToString());


        }

        //field operation
        [Test]
        public void FieldOperation()
        {

            IWebElement elementA = driver.FindElement(By.id("sum1"));
            elementA.Click();
            elementA.SendKeys("8");
            elementA.Clear();
            elementA.SendKeys("765");

            IWebElement elementB = driver.FindElement(By.id("sum2"));
            elementB.Click();
            elementB.SendKeys("54664");
            elementB.Clear();
            elementB.SendKeys("5");

            IWebElement GetTotal = driver.FindElements(By.XPath(""));





        }
       
        //close page 

        [Test]
        public void XclosePage()
     
         { 
            Task.Delay(2000).Wait();

            driver.Quit();
        }
    }
}
