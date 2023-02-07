using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationDemo;

namespace AutomationDemo.TestSuite1
{
    [TestFixture]
    public class Tests
    {
        public TestSteps TestSteps;

        [SetUp]
        protected void SetUp()
        {
            TestSteps = new TestSteps();
        }

        [Test]
        [Category ("test")]
        public void Test1()
        {
            TestSteps.StartUp();
            TestSteps.NavigatetoGoogle();

        }
    }
}