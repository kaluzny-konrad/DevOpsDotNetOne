using OpenQA.Selenium.Remote;

namespace aspnet_core_dotnet_core.FunctionalTests.PageObjects
{
    public class ContactPage
    {
        private readonly RemoteWebDriver _driver;
        public ContactPage(RemoteWebDriver driver) => _driver = driver;


    }
}