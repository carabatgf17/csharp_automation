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


        public IWebElement GetElementByID(String id, IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            return element;
        }

        public void ClickElementById(String id, IWebDriver driver)
        {
            GetElementByID(id,driver).Click();
        }
    }
}
