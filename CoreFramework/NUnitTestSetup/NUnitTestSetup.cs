using CoreFramework.DriverCore;
using CoreFramework.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using CoreFramework.Reporter;
using AventStack.ExtentReports;

namespace CoreFramework.NUnitTestSetup
{
    [TestFixture]
    public class NUnitTestSetup
    {
        public static IWebDriver? _driver;
        public WebDriverAction driverBaseAction;
        public ExtentReports? _extentReports;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            HtmlReport.createReport();
            HtmlReport.createTest(TestContext.CurrentContext.Test.ClassName);
        }
        [SetUp]
        public void SetUp()
        {
            HtmlReport.createNode(TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.Name);
            WebDriverManager_.InitDriver("chrome", 1920, 1080);
            _driver = WebDriverManager_.GetCurrentDriver();
            driverBaseAction = new WebDriverAction(_driver);
        }
        [TearDown]
        public void TearDown()
        {
           // _driver.Quit();
            TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            if (testStatus.Equals(TestStatus.Passed))
            {
            }
            else if (testStatus.Equals(TestStatus.Failed))
            {
            }
            HtmlReport.flush();
        }
    }
}