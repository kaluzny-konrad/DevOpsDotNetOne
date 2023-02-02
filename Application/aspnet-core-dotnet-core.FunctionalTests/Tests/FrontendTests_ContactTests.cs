using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using aspnet_core_dotnet_core.FunctionalTests.PageObjects;

namespace aspnet_core_dotnet_core.FunctionalTests
{
    [TestClass]
    public class FrontendTests_ContactTests : FrontendTests
    {
        [ClassInitialize]
        public static new void Initialize(TestContext testContext)
            => FrontendTests.Initialize(testContext);

        [TestMethod]
        public void TitleShouldBeCorrect()
        {
            try
            {
                var headerModule = new HeaderModule(_driver);
                var contactPage = headerModule.GetContactPage();

                var expectedTitle = "Contact";

                Assert.AreEqual(expectedTitle, _driver.Title);
            }
            catch (Exception ex) { LogError(ex); throw; }
        }
    }
}