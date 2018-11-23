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

        public static Utils util = new Utils();


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

        class CssClearOneInputField
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            [NUnit.Framework.Test]
            public void TestCase_CssClearOneInputField()
            {
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
                Task.Delay(2000).Wait();

                IWebElement aValueField = driver.FindElement(By.CssSelector("input[id=\"sum1\"]"));
                string aValue = "20";
                aValueField.SendKeys(aValue);

                IWebElement button = driver.FindElement(By.CssSelector("button[onclick=\"return total()\"]"));
                button.Click();

                IWebElement displayData = driver.FindElement(By.CssSelector("span[id=\"displayvalue\"]"));

                Assert.AreEqual(displayData.Text, "NaN");

                driver.Quit();

            }
        }

        class CssTwoFieldsChangeValueNoClear
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            [NUnit.Framework.Test]
            public void TestCase_CssTwoFieldsReplaceValue()
            {
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
                Task.Delay(2000).Wait();

                IWebElement aValueField = driver.FindElement(By.CssSelector("input[id=\"sum1\"]"));
                string aValue = "20";
                aValueField.SendKeys(aValue);

                IWebElement bValueField = driver.FindElement(By.CssSelector("input[id=\"sum2\"]"));
                string bValue = "10";
                bValueField.SendKeys(bValue);

                IWebElement getTotalButton = driver.FindElement(By.CssSelector("button[onclick=\"return total()\"]"));
                getTotalButton.Click();

                IWebElement displayResult = driver.FindElement(By.CssSelector("span[id=\"displayvalue\"]"));
                string sum = Convert.ToString(Convert.ToInt32(aValue) + Convert.ToInt32(bValue));

                Assert.AreEqual(sum, displayResult.Text);
                Task.Delay(2000).Wait();

                bValueField.SendKeys("0");
                bValue = bValue + "0";

                Assert.AreEqual(aValue, aValueField.GetAttribute("value"));
                Assert.AreEqual(bValue, bValueField.GetAttribute("value"));
                Assert.AreEqual(sum, displayResult.Text);

                Assert.AreEqual(sum, displayResult.Text);

                getTotalButton.Click();

                sum = Convert.ToString(Convert.ToInt32(aValue) + Convert.ToInt32(bValue));

                Assert.AreEqual(aValue, aValueField.GetAttribute("value"));
                Assert.AreEqual(bValue, bValueField.GetAttribute("value"));
                Assert.AreEqual(sum, displayResult.Text);

                driver.Quit();
            }
        }

        class XPathVerifyDefaultFieldText
        {
            public static FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\unu");
            public static FirefoxOptions options = new FirefoxOptions();
            public static IWebDriver driver = new FirefoxDriver(service, options, TimeSpan.FromMinutes(1));
            [NUnit.Framework.Test]

            public void TestCase_XPathVerifyDefaultFieldText()
            {

                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
                Task.Delay(2000).Wait();

                IWebElement messageField = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/div[1]/div[2]/form[1]/div[1]/input[1]"));
                Assert.AreEqual("Please enter your Message", messageField.GetAttribute("placeholder"));

                IWebElement aValueField = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/div[2]/div[2]/form[1]/div[1]/input[1]"));
                IWebElement bValueField = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[2]/div[2]/div[2]/form[1]/div[2]/input[1]"));

                Assert.AreEqual("Enter value", aValueField.GetAttribute("placeholder"));
                Assert.AreEqual("Enter value", bValueField.GetAttribute("placeholder"));

                driver.Quit();

            }
        }
    }
}

