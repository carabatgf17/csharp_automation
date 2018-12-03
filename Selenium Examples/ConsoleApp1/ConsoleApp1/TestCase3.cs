using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestCase3
    {

        [NUnit.Framework.Test]
        public void TestCase5()
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\gcarabat\source\repos\ConsoleApp1\ConsoleApp1");
            FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/table-data-download-demo.html");
            Task.Delay(2000).Wait();

            IWebElement table = driver.FindElement(By.Id("example"));


            ReadOnlyCollection<IWebElement> allRows = table.FindElements(By.TagName("tr"));

            foreach (IWebElement row in allRows)
            {
                ReadOnlyCollection<IWebElement> cells = row.FindElements(By.TagName("td"));

                foreach (IWebElement cell in cells)
                {
                    Console.WriteLine("\t" + cell.Text);
                }
            }



        }
    }
}
