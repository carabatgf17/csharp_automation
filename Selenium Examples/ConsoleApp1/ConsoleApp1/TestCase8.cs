using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class TestCase8
    {
        
        [Test]
        public void TestCaseDownload()
        {


            FirefoxOptions options = new FirefoxOptions();
            options.SetPreference("browser.download.folderList", 0);

            //https://www.sitepoint.com/mime-types-complete-list/
            // https://www.seleniumeasy.com/selenium-tutorials/how-to-download-a-file-with-webdriver

            //options.SetPreference("browser.download.dir", "C:\\Windows\\temp");
            //options.SetPreference("browser.download.manager.showWhenStarting", false);
            //options.SetPreference("browser.download.useDownloadDir", true);
            //options.SetPreference("browser.download.manager.alertOnEXEOpen", false);
            //options.SetPreference("browser.helperApps.neverAsk.saveToDisk",
            //"application/msword, application/binary, application/ris, text/csv, image/png, application/pdf," +
            //"text / html, text / plain, application / zip, application / x - zip, application / x - zip - compressed, " +
            //"application / download,application / octet - stream");

            options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "text/plain");

            //options.SetPreference("pdfjs.disabled", true);  // disable the built-in PDF viewer


            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\gcarabat\source\repos\ConsoleApp1\ConsoleApp1");
            IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/generate-file-to-download-demo.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Charts Demo'])[1]/following::div[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Charts Demo'])[1]/following::div[2]")).Click();
            driver.FindElement(By.Id("textbox")).Click();
            driver.FindElement(By.Id("textbox")).Clear();
            driver.FindElement(By.Id("textbox")).SendKeys("aaaaa");
            driver.FindElement(By.Id("create")).Click();
            driver.FindElement(By.Id("link-to-download")).Click();


            Task.Delay(2000).Wait();
            //SendKeys.SendWait(@"{Enter}");


        }



    }

}
