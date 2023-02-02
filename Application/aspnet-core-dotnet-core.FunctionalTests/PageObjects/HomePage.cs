using OpenQA.Selenium.Remote;

namespace aspnet_core_dotnet_core.FunctionalTests.PageObjects
{
    public class HomePage
    {
        private readonly RemoteWebDriver _driver;
        public HomePage(RemoteWebDriver driver) => _driver = driver;


    }
}