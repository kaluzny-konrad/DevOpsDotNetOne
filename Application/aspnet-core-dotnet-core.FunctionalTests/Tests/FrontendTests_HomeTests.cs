using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace aspnet_core_dotnet_core.FunctionalTests
{
    [TestClass]
    public class FrontendTests_HomeTests : FrontendTests
    {
        [ClassInitialize]
        public static new void Initialize(TestContext testContext)
            => FrontendTests.Initialize(testContext);

        [TestMethod]
        public void TitleShouldBeCorrect()
        {
            try
            {
                var expectedTitle = "Home Page - ASP.NET Core";

                Assert.AreEqual(expectedTitle, _driver.Title);
            }
            catch (Exception ex) { LogError(ex); throw; }
        }
    }
}