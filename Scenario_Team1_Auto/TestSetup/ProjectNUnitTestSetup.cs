using CoreFramework.DriverCore;
using CoreFramework.NUnitTestSetup;
using NUnit.Framework;

namespace Scenario_Team1_Auto.TestSetup
{
    public class ProjectNUnitTestSetup : NUnitTestSetup
    {
        public WebDriverAction webDriverAction;
        
        [SetUp]
        public void SetUp()
        {
            driverBaseAction.GoToURL(Constant.BASE_URL);
        }
        [TearDown]
        public void TearDown()
        {
        }
    }
}

