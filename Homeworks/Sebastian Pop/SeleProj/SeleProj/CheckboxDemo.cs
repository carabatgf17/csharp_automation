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
    class SimpleCheckbox
    {
        public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
        public static FirefoxOptions options = new FirefoxOptions();
        public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
        [NUnit.Framework.Test]
        public void Testcase_SimpleCheckbox()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-checkbox-demo.html");
            Task.Delay(2000).Wait();

            IWebElement simpleCheckbox = driver.FindElement(By.Id("isAgeSelected"));
            simpleCheckbox.Click();

            IWebElement successCheckedMessage = driver.FindElement(By.Id("txtAge"));
            
            Assert.AreEqual("Success - Check box is checked", successCheckedMessage.Text);

            simpleCheckbox.Click();
            Assert.IsEmpty(successCheckedMessage.Text);

            driver.Quit();
            
        }

        class MultipleCheckbox
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            [NUnit.Framework.Test]

            public void Testcase_MultipleCheckbox()
            {
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-checkbox-demo.html");
                Task.Delay(2000).Wait();

                IWebElement checkAllButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/div[2]/div[2]/input[1]"));
                Assert.AreEqual("Check All", checkAllButton.GetAttribute("value"));

                IWebElement firstCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/div[1]/label"));
                firstCheckbox.Click();
                Task.Delay(1000).Wait();

                IWebElement secondCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/div[2]/label/input"));
                secondCheckbox.Click();
                Task.Delay(1000).Wait();

                IWebElement thirdCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/div[3]/label/input"));
                thirdCheckbox.Click();
                Task.Delay(1000).Wait();

                IWebElement forthCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/div[4]/label/input"));
                forthCheckbox.Click();        
                Task.Delay(1000).Wait();

                Assert.AreEqual("Uncheck All", checkAllButton.GetAttribute("value"));

                thirdCheckbox.Click();
                Assert.AreEqual("Check All", checkAllButton.GetAttribute("value"));

                checkAllButton.Click();
                Assert.AreEqual("Uncheck All", checkAllButton.GetAttribute("value"));

                checkAllButton.Click();
                Assert.AreEqual("Check All", checkAllButton.GetAttribute("value"));

                driver.Quit();

            }
        }

        class CssMultipleCheckbox
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("D:/unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));

            [NUnit.Framework.Test]

            public void Testcase_CssMultipleCheckbox()
            {
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-checkbox-demo.html");
                Task.Delay(2000).Wait();

                IWebElement firstCheckbox = driver.FindElement(By.CssSelector("div.checkbox:nth-child(3) > label:nth-child(1) > input:nth-child(1)"));
                firstCheckbox.Click();
                Task.Delay(2000).Wait();

                IWebElement checkAllButton_CssSelector = driver.FindElement(By.CssSelector("#check1"));
                Assert.AreEqual("Check All", checkAllButton_CssSelector.GetAttribute("value"));


                IWebElement checkAllButton_CssPath = driver.FindElement(By.CssSelector("html body div#easycont.container-fluid.text-center div.row div.col-md-6.text-left div.panel.panel-default div.panel-body input#check1.btn.btn-primary"));
                Assert.AreEqual("Check All", checkAllButton_CssPath.GetAttribute("value"));

                //Why? Doesnt work. selects first checkbox on the page instead of second in the bundle

                IWebElement secondCheckbox = driver.FindElement(By.CssSelector("html body div#easycont.container-fluid.text-center div.row div.col-md-6.text-left div.panel.panel-default div.panel-body div.checkbox label"));
                secondCheckbox.Click();
                Task.Delay(2000).Wait();

                firstCheckbox.Click();               

                driver.Quit();
            }
        }
    }
}
