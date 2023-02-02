using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

using aspnet_core_dotnet_core.FunctionalTests.PageObjects;

namespace aspnet_core_dotnet_core.FunctionalTests
{
    public class FrontendTests
    {
        protected static Uri _webAppUrl;
        protected RemoteWebDriver _driver;

        public static void Initialize(TestContext testContext)
        {
            _webAppUrl = new Uri(testContext.Properties["webAppUrl"].ToString());
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver = GetChromeDriver();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            _driver.Navigate().GoToUrl(_webAppUrl);
        }

        [TestCleanup]
        public void TestClean()
        {
            _driver.Quit();
        }

        private RemoteWebDriver GetChromeDriver()
        {
            var path = Environment.GetEnvironmentVariable("ChromeWebDriver");
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            options.AddArgument("--headless");

            if (string.IsNullOrWhiteSpace(path)) return new ChromeDriver(options);
            else return new ChromeDriver(path, options, TimeSpan.FromSeconds(300));
        }

        protected static void LogError(Exception ex)
        {
            Console.Write("##vso[task.logissue type=error;]Test SampleFunctionalTest1 failed with error: " + ex.ToString());
        }
    }
}