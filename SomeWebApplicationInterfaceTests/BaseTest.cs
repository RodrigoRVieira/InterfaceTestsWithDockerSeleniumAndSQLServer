using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

using System.IO;

namespace SomeWebApplicationInterfaceTests
{
    public abstract class BaseTest
    {
        protected static IWebDriver WebDriver { get; set; }

        protected void TakeScreenshot(string fileName)
        {
            WebDriver.TakeScreenshot().SaveAsFile($"/images/{fileName}");
        }

        protected static void SeleniumInitialize()
        {
            WebDriver = new ChromeDriver(new ChromeOptions() { });
        }

        protected static void SeleniumCleanUp()
        {
            WebDriver.Quit();
        }
    }
}