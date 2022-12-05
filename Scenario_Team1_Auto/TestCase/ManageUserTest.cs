using NUnit.Framework;
using Scenario_Team1_Auto.PageObject;
using Scenario_Team1_Auto.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.TestCase
{
    [TestFixture]
    public class ManageUserTest : NashNUnitAPITestSetup
    {
        [Test]
        public void GetManageUserPage() // admin view ManageUser Page , Users List and detail of User
        {
            LoginPage loginPage = new LoginPage(_driver);
            HomePage homePage = new HomePage(_driver);
            ManagaUserPage managaUserPage = new ManagaUserPage(_driver);

            string adminUserName = Constant.ADMIN_USERNAME;
            string adminPassword = Constant.ADMIN_PASSWORD;

            loginPage.Login(adminUserName, adminPassword);

            homePage.GetManageUserPage();

            managaUserPage.VerifyManageUserPageDisplay();

            managaUserPage.GetUserList();
            managaUserPage.GetDetailOfRandomUser();
            managaUserPage.VerifyPopupDisplay();

        }
    }
}
