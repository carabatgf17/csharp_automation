using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TestCase7
    {

        [NUnit.Framework.Test]
        public void TestCase()
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\gcarabat\source\repos\ConsoleApp1\ConsoleApp1");
            FirefoxOptions options = new FirefoxOptions();
            //options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html");

            //ReadOnlyCollection<IWebElement> selectList = driver.FindElements(By.Id("multi-select"));

            //foreach (IWebElement button in selectList)
            //{
            //    Console.WriteLine(button.Text);
            //    if (button.Text.Contains("Ohio")) { 
            //        button.Click();
            //    }

            //}


            IWebElement selectList = driver.FindElement(By.Id("multi-select"));
            //IWebElement selectElement = driver.FindElement(By.Id(""));
            SelectElement oSelect = new SelectElement(selectList);

            //foreach (IWebElement button in oSelect.Options)
            //{
            //    Console.WriteLine(button.Text);
            //    if (button.Text.Contains("Ohio"))
            //    {
            //        Console.WriteLine(button.Text);
            //        button.Click();
            //    }

            //}
            //Console.WriteLine(oSelect.Options.ToString()); 
            //driver.SwitchTo().DefaultContent();

            //driver.FindElement(By.XPath("//select/option[normalize-space(text())='Washington']")).Click();


            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Multi Select List Demo'])[1]/following::option[8]")).Click();
            driver.FindElement(By.Id("printAll")).Click();



        }
    }
}
