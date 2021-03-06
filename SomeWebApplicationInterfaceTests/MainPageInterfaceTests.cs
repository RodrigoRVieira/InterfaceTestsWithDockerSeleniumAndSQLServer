using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using OpenQA.Selenium;

namespace SomeWebApplicationInterfaceTests
{
    [TestClass]
    public class MainPageInterfaceTests : BaseTest
    {
        [TestMethod]
        public void ShouldDisplayPrivacyContentOnClick()
        {
            // Arrange
            WebDriver.Manage().Window.Maximize();

            // Act
            WebDriver.Navigate().GoToUrl("http://somewebapplication");

            // Policy link
            WebDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a")).Click();

            var policyText = WebDriver.FindElement(By.XPath("/html/body/div/main/h1")).Text;
            
            TakeScreenshot("Privacy.png");

            // Assert
            Assert.IsTrue(policyText.Equals("Privacy Policy"));
        }

        [ClassInitialize()]
        public static void Initialize(TestContext testContext)
        {
            SeleniumInitialize();
        }

        [ClassCleanup()]
        public static void CleanUp()
        {
            SeleniumCleanUp();
        }        
    }
}
