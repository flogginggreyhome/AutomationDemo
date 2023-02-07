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
using AutomationDemo.PageObjects;

namespace AutomationDemo
{

    public class TestSteps
    {

        IWebDriver _driver;
       


        public TestSteps()
        {
        }

        public void StartUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _driver.Manage().Window.Maximize();
        }
        public void Quit()
        {
            _driver.Quit();
        }

        public void NavigatetoGoogle()
        {
            GoogleHome searchPage = new GoogleHome(_driver);
            searchPage.NavigatetoGoogle();
        }

        public void SearchQuery()
        {
            GoogleHome searchPage = new GoogleHome(_driver);
            searchPage.SearchQuery();

        }
    }
}
