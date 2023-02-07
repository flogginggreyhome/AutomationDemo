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
       
        WebDriverWait _wait;
        IWebDriver _driver;

        public const string URL = "https://www.google.com";
        
        public GoogleHome(IWebDriver _driver)
        {
            this._driver = _driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
       
        public void NavigatetoGoogle()
        {
            _driver.Navigate().GoToUrl(URL);
            //_driver.Url = URL;
            var title = _driver.Title;
            Console.WriteLine(title);
            Assert.AreEqual("Google", title);
            Console.WriteLine(title + " equals " + _driver.Title);
        }

        public void SearchQuery()
        {
            try
            {
                IWebElement searchBar = _wait.Until(d => d.FindElement(By.Name("q")));
                searchBar.SendKeys("lambda test");
                searchBar.Submit();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message + " SearchQuery");
            }
            
            
        }
    }
}
