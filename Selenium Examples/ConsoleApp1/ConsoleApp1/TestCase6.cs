using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestCase6
    {

        [NUnit.Framework.Test]
        public void TestCase()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\gcarabat\source\repos\ConsoleApp1\ConsoleApp1");
            FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();
            driver.FindElement(By.XPath("//*[@id='get-input']/button")).Click();
            ////*[@id="gettotal"]/button
            driver.FindElement(By.XPath("//*[@id='gettotal']/button")).Click();

            ReadOnlyCollection<IWebElement> buttons = driver.FindElements(By.TagName("button"));

            foreach (IWebElement button in buttons)
            {
                Console.WriteLine(button.Text);
            }

            ReadOnlyCollection<IWebElement> buttons2 = driver.FindElements(By.XPath("//button"));

            foreach (IWebElement button in buttons)
            {
                Console.WriteLine(button.Text);
            }


        }
    }
}
