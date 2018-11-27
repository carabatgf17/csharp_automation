using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Lectia3
{

    class TestCases
    {
        [NUnit.Framework.Test]
        public void TestCase1()
        {
            Console.WriteLine("GoGo test 1");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("user-message")).SendKeys("ASP.NET");
            driver.FindElement(By.ClassName("btn-default")).Click();
            string actualvalue = driver.FindElement(By.Id("display")).Text;
            Assert.IsTrue(actualvalue.Contains("ASP.NET"), actualvalue + " doesn't contains 'ASP.NET'");
            Task.Delay(2000).Wait();
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase2()
        {
            Console.WriteLine("GoGo test 2");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();
            Console.WriteLine("The page title is: " + driver.Title);
            Assert.AreEqual("Selenium Easy Demo - Simple Form to Automate using Selenium", driver.Title);
            driver.FindElement(By.Id("sum1")).SendKeys("2");
            driver.FindElement(By.Id("sum2")).SendKeys("2");
            driver.FindElement(By.XPath("//button[contains(.,'Get Total')]")).Click();
            string actualvalue = driver.FindElement(By.Id("displayvalue")).Text;
            Assert.IsTrue(actualvalue.Contains("4"), actualvalue + " doesn't contains '4'");
            Task.Delay(2000).Wait();
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase3()
        {
            Console.WriteLine("GoGo test 3");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();
            Console.WriteLine("The page title is: \r\t- " + driver.Title);
            Console.WriteLine("The Panel headings are: ");
            foreach (IWebElement element in driver.FindElements(By.ClassName("panel-heading")))
            {
                Console.WriteLine("\t- " + element.Text);
            }
            driver.Quit();
        }
        [NUnit.Framework.Test]
        public void TestCase4()
        {
            Console.WriteLine("GoGo test 3");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();
            Console.WriteLine("The page title is: \r\t- " + driver.Title);
            Console.WriteLine("The Panel headings are: ");
            foreach (IWebElement element in driver.FindElements(By.ClassName("panel-heading")))
            {
                Console.WriteLine("\t- " + element.Text);
            }
            driver.Quit();
        }
        [NUnit.Framework.Test]
        public void TestCase5()
        {
            Console.WriteLine("Multiple select");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/table-pagination-demo.html");
            Task.Delay(2000).Wait();
            Console.WriteLine("The page title is: \r\t- " + driver.Title);
            Console.WriteLine("The Cells are: ");
            foreach (IWebElement element in driver.FindElements(By.ClassName("panel-heading")))
            {
                Console.WriteLine("\t- " + element.Text);
            }
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase6()
        {
            Console.WriteLine("Multiple select");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-select-dropdown-demo.html");
            Task.Delay(2000).Wait();
            IWebElement listElement = driver.FindElement(By.Id("multi-select"));
            SelectElement select = new SelectElement(listElement);
            select.SelectByValue("New Jersey");
            //select.SelectByValue("New York");
       
            IWebElement getAllSelected = driver.FindElement(By.Id("printAll"));
            getAllSelected.Click();
           // string getAllSelectedText = driver.FindElement(By.ClassName("getall-selected")).Text;
            //Assert.IsTrue(getAllSelectedText.Contains("New Jersey"), getAllSelectedText + " doesn't contains 'New Jersey'");
            Task.Delay(5000).Wait();
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase7()
        {
            Console.WriteLine("File download");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            FirefoxProfile profile = new FirefoxProfile();
            profile.SetPreference("browser.download.dir", @"C:\temp\");
            profile.SetPreference("browser.download.folderList", 2);
            profile.SetPreference("browser.download.manager.alertOnEXEOpen", false);
            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream doc xls pdf txt");
            profile.SetPreference("pdfjs.disabled", true );
            options.Profile = profile;
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/generate-file-to-download-demo.html");
            
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("textbox")).SendKeys("This is the text");
            driver.FindElement(By.Id("create")).Click();
            driver.FindElement(By.Id("link-to-download")).Click();
            Task.Delay(3000).Wait();
        
            driver.Quit();
            
        }
    }
}
