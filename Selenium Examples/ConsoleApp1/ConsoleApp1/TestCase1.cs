using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class TestCase1
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Init()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\gcarabat\source\repos\ConsoleApp1\ConsoleApp1");
            FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
        }

        [Test]
        public void TestCase()
        {
 
            driver.Navigate().GoToUrl("http://www.google.com/");
            Task.Delay(2000).Wait();
            //driver.Quit();
           
        }

        [Test]
        public void TestCase2()
        {

            driver.Navigate().GoToUrl("http://www.google.com/");
            Task.Delay(2000).Wait();
            driver.Quit();

        }
    }
}
