using NUnit.Framework;
using Scenario_Team1_Auto.PageObject;
using Scenario_Team1_Auto.Services;
using Scenario_Team1_Auto.TestSetup;

namespace Scenario_Team1_Auto.TestCase
{
    [TestFixture]
    public class LoginTest : NashNUnitAPITestSetup
    {
        [Test]
        public void AdminLogin() 
        {
            HomePage homePage = new HomePage(_driver);
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.Login(newUserInfo.username, Constant.NEW_PASSWORD1);
        }
    }
}
