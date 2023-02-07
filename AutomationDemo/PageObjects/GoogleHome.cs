using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationDemo.PageObjects
{
    public class GoogleHome
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public GoogleHome()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

        }
        public void NavigatetoGoogle()
        {
            var title = _driver.Title;
            _driver.Navigate().GoToUrl("www.google.com");
            Assert.AreEqual("", title);
        }
    }
}
