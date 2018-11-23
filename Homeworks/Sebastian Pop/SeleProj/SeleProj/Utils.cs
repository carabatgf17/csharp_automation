using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleProj
{
    public class Utils
    {


        public IWebElement GetElementByID(IWebDriver driver, String id)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            return element;
        }

        public void ClickElementById(IWebDriver driver, String id)
        {
            GetElementByID(driver, id).Click();
        }

        public void ClickElementByCss(IWebDriver driver, String css)
        {
            GetElementByID(driver, css).Click();
        }

        public static void GoToSimpleDemoForm(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/basic-first-form-demo.html");
            Task.Delay(2000).Wait();
        }
    }
}
