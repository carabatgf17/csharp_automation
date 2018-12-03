using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestCase2
    {
        [NUnit.Framework.Test]
        public void TestCase()
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver(@"C:\Users\gcarabat\Downloads\chromedriver_win32\chromedriver.exe");
            driver.Navigate().GoToUrl("http://www.google.com/");
            Task.Delay(2000).Wait();


            driver.Title.ToString();
            driver.PageSource.ToString();
            driver.Manage().Window.FullScreen();
            driver.Navigate().Refresh();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            

            IWebElement element = driver.FindElement(By.Id(""));
            bool isEnabled = element.Enabled;
            bool isDisplayed = element.Displayed;

            driver.FindElement(By.Id("")).Click();   // Button
            driver.FindElement(By.Id("")).Click();  // Link
            driver.FindElement(By.Id("")).SendKeys("");  // Textfield
          //  driver.FindElement(By.Id("")).getText();  // HTML Div element

            driver.FindElement(By.Name("")).SendKeys("");

            System.Drawing.Point locationOfElement = element.Location;
            Console.WriteLine("X cordinate : " + locationOfElement.X + "Y cordinate: " + locationOfElement.Y);

            
            element.Click();
            element.Submit();

            element.GetAttribute("");

            String textElement = element.Text;
            

            IWebElement frame = driver.FindElement(By.TagName(""));


            IWebElement cheese = driver.FindElement(By.LinkText(""));
            IWebElement partialLink = driver.FindElement(By.PartialLinkText(""));

            IList<IWebElement> inputs = driver.FindElements(By.XPath(""));


            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            alert.Dismiss();
            String textAlert = alert.Text;



            driver.FindElement(By.Id("")).SendKeys("");
            driver.FindElement(By.Id("")).Clear();
            driver.FindElement(By.LinkText("")).Click();


            IWebElement EducationDropDownElement = driver.FindElement(By.Name(""));
            IWebElement selectElement = driver.FindElement(By.Id(""));
            SelectElement oSelect = new SelectElement(selectElement);

            oSelect.SelectByText("");
            oSelect.SelectByIndex(0);
            oSelect.SelectByValue("");


            Assert.AreEqual("", driver.Title);
            String html_fragment = "Text assertion ";
            Assert.IsTrue(driver.PageSource.Contains(html_fragment));
            Assert.IsTrue(driver.FindElement(By.Name("")).Selected);
            Assert.IsTrue(driver.FindElement(By.Id("")).Enabled);
            Assert.AreEqual("First Label", driver.FindElement(By.Id("label_1")).Text);
            Assert.AreEqual("Second Span", driver.FindElement(By.Id("span_2")).Text);


            //driver.Quit();

        }
    }

}
