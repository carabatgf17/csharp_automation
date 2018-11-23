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
    class TestSingleInputField
    {
        public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
        public static FirefoxOptions options = new FirefoxOptions();
        public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));


        [NUnit.Framework.Test]
        public void TestCase_TestSingleInputField()
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();

            IWebElement inputField = driver.FindElement(By.Id("user-message"));
            string testData = "Test data";
            inputField.SendKeys(testData);

            IWebElement showMessageButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[2]/form/button"));
            showMessageButton.Click();

            IWebElement displayData = driver.FindElement(By.Id("display"));
            Assert.AreEqual(testData, displayData.Text);
            Task.Delay(2000).Wait();
            driver.Quit();
        }

        class TestTwoInputFields
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            [NUnit.Framework.Test]
            public void TestCase_TestTwoInputFields()
            {
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
                Task.Delay(2000).Wait();

                IWebElement aValueField = driver.FindElement(By.Id("sum1"));
                string aValue = "20";
                aValueField.SendKeys(aValue);

                IWebElement bValueField = driver.FindElement(By.Id("sum2"));
                string bValue = "10";
                bValueField.SendKeys(bValue);

                int sum = (Convert.ToInt32(aValue) + Convert.ToInt32(bValue));

                IWebElement getTotalButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div[2]/form/button"));
                getTotalButton.Click();

                IWebElement displaySum = driver.FindElement(By.Id("displayvalue"));

                Assert.AreEqual(Convert.ToString(sum), displaySum.Text);

                Task.Delay(2000).Wait();
                driver.Quit();
            }
        }

        class ClearOneInputField
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            [NUnit.Framework.Test]
            public void TestCase_ClearOneInputField()
            {
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
                Task.Delay(2000).Wait();

                IWebElement inputField = driver.FindElement(By.Id("user-message"));
                string testData = "Test data";
                inputField.SendKeys(testData);

                IWebElement showMessageButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[2]/form/button"));
                showMessageButton.Click();

                IWebElement displayData = driver.FindElement(By.Id("display"));

                inputField.Clear();
                Assert.IsEmpty(inputField.Text);

                string testDataAfterClear = "Data was cleared";
                inputField.SendKeys(testDataAfterClear);

                showMessageButton.Click();

                Assert.AreEqual(testDataAfterClear, displayData.Text);

                Task.Delay(2000).Wait();
                driver.Quit();
            }

        }
    }
}
