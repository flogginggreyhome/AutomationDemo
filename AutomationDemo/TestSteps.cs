using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium.Chrome;

namespace AutomationDemo
{

    public class TestSteps
    {

        IWebDriver _driver = new ChromeDriver();

        public TestSteps()
        {
        }

        public void StartUp()
        {
            WebDriverWait _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _driver.Navigate().GoToUrl("www.google.com");
            _driver.Manage().Window.Maximize();
        }

        public void NavigatetoGoogle()
        {

        }
    }
}
