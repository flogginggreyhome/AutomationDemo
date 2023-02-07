using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationDemo;
using NUnit.Framework;

namespace AutomationDemo.TestSuite1
{
    [TestFixture]
    public class Tests
    {
        
        TestSteps steps = new TestSteps();
        [SetUp]
        public void StartUp()
        {
            steps.StartUp();
        }

        [Test]
        [Category ("test")]
        public void Test1()
        {
           
            steps.NavigatetoGoogle();
            steps.SearchQuery();

        }

        [TearDown] 
        public void TearDown() 
        { 
            steps.Quit();
        }
        
    }
}