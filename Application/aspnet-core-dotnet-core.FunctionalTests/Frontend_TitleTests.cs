using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SampleWebApplication.FunctionalTests
{
    [TestClass]
    public class Frontend_TitleTests : FrontendTests
    {
        [ClassInitialize]
        public static new void Initialize(TestContext testContext) 
            => FrontendTests.Initialize(testContext);

        [TestMethod]
        public void TitleShouldBeCorrect()
        {
            try { TitleShouldBeCorrect_RunTest(); }
            catch(Exception ex) { LogError(ex); throw; }
        }

        private void TitleShouldBeCorrect_RunTest()
        {
            var expectedTitle = "Home Page - ASP.NET Core";
            _driver.Navigate().GoToUrl(_webAppUrl);
            Assert.AreEqual(expectedTitle, _driver.Title);
        }
    }
}