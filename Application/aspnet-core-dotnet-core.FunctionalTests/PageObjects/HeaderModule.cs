using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace aspnet_core_dotnet_core.FunctionalTests.PageObjects
{
    public class HeaderModule
    {
        private readonly RemoteWebDriver _driver;
        public HeaderModule(RemoteWebDriver driver) => _driver = driver;

        public ContactPage GetContactPage()
        {
            var contactPageBy = By.XPath("//a[contains(text(),'Contact')]");
            _driver.FindElement(contactPageBy).Click();
            return new ContactPage(_driver);
        }
    }
}