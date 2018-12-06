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
            string path = @"C:\temp\";
            profile.SetPreference("browser.download.dir", path);
            profile.SetPreference("browser.download.folderList", 2);
            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/plain");
            options.Profile = profile;
            //options.SetPreference("browser.download.folderList", 0);
            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/plain");
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/generate-file-to-download-demo.html");

            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("textbox")).SendKeys("This is the text");
            driver.FindElement(By.Id("create")).Click();
            driver.FindElement(By.Id("link-to-download")).Click();
            Task.Delay(3000).Wait();
            string text = System.IO.File.ReadAllText(path + "\\easyinfo.txt");
            Console.WriteLine("The file content:\n" + text);
            Assert.IsTrue(text.Equals("This is the text"), "The text is not contained");
            driver.Quit();
            System.IO.File.Delete(path + "\\easyinfo.txt");
        }
        private bool IsElementPresent(IWebDriver driver,By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        [NUnit.Framework.Test]
        public void TestCase8()
        {
            Console.WriteLine("Count columns and rows by navigating forward");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/table-pagination-demo.html");
            int nrColoane;
            nrColoane = driver.FindElements(By.XPath("/html/body/div[2]/div/div[2]/section/div/table/thead/tr/th")).Count();
            Console.WriteLine("Number of columns: " + nrColoane);
            int nrRanduri = 0;
            IWebElement nextLink = driver.FindElement(By.CssSelector("a[class='next_link']"));
            while (string.IsNullOrEmpty(nextLink.GetAttribute("style")))
            {
               nrRanduri += driver.FindElements(By.XPath("//*[@id=\"myTable\"]/tr[@style='display: table-row;']")).Count();
               nextLink.Click();
            }
            nrRanduri += driver.FindElements(By.XPath("//*[@id=\"myTable\"]/tr[@style='display: table-row;']")).Count();
            Console.WriteLine("atribut: " + nextLink.GetAttribute("style"));
            Console.WriteLine("Number of rows: " + nrRanduri);
            Task.Delay(3000).Wait();
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase9()
        {
            Console.WriteLine("Multiple select");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://money.rediff.com/gainers/bsc/daily/groupa");
            
            //Console.WriteLine("Number of columns: " + nrColoane);
            //int nrRanduri;
            //nrRanduri = driver.FindElements(By.XPath("//*[@id=\"myTable\"]/tr[*]")).Count();
            //Console.WriteLine("Number of columns: " + nrRanduri);
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase10()
        {
            Console.WriteLine("Get text from the iFrame");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.w3schools.com/html/tryit.asp?filename=tryhtml_iframe_height_width");
            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeResult")));
            driver.SwitchTo().Frame(driver.FindElement(By.TagName("iframe")));
            Console.WriteLine("The text is: " + driver.FindElement(By.TagName("h1")).Text);
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase11()
        {
            Console.WriteLine("Get text from all modal dialogs");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/javascript-alert-box-demo.html");
            driver.FindElement(By.ClassName("btn-default")).Click();
            Console.WriteLine("The text on the \"Java Script Alert Box\" is: " + driver.SwitchTo().Alert().Text);
            Assert.IsTrue(driver.SwitchTo().Alert().Text.Contains("I am an alert box!"), "Alert box wrong text");
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.ClassName("btn-lg")).Click();
            Console.WriteLine("The text on the \"Java Script Confirm Box\" is: " + driver.SwitchTo().Alert().Text);
            Assert.IsTrue(driver.SwitchTo().Alert().Text.Contains("Press a button!"), "Confirm box wrong text");
            driver.SwitchTo().Alert().Accept();
            driver.FindElement(By.XPath("//button[contains(.,'Click for Prompt Box')]")).Click();
            driver.SwitchTo().Alert().SendKeys("Cristian");
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("The text entered on the \"Java Script Confirm Box\" is: " + driver.FindElement(By.Id("prompt-demo")).Text);
            Assert.IsTrue(driver.FindElement(By.Id("prompt-demo")).Text.Contains("You have entered 'Cristian' !"), "Wrong name entered in the alert box");
            Task.Delay(3000).Wait();
            driver.Quit();
        }

        [NUnit.Framework.Test]
        public void TestCase12()
        {
            Console.WriteLine("Next sibling in table");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\Wirtek work\Automation\Curs Automation 2018 - Gabriel Carabat\GIT\csharp_automation\Homeworks\Cristian Olariu\Lectia3\Lectia3\Lectia3");
            FirefoxOptions options = new FirefoxOptions();
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://money.rediff.com/gainers/bsc/daily/groupa");
            int i = 0;
            foreach (IWebElement columnHeader in driver.FindElements(By.XPath("//*[@id=\"leftcontainer\"]/table/thead/tr/th")))
            {
                if (i == 0)
                {
                    Console.WriteLine(columnHeader.Text + " is " + driver.FindElement(By.XPath("//td[contains(.,'ICRA Ltd.')]")).Text);
                }
                else
                {
                    Console.WriteLine(columnHeader.Text + " is " + driver.FindElement(By.XPath("//td[contains(.,'ICRA Ltd.')]/following-sibling::td[" + i + "]")).Text);
                }
                i++;                
            }
            Task.Delay(3000).Wait();
            driver.Quit();
        }
    }
}
