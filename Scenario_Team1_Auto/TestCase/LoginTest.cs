using NUnit.Framework;
using Scenario_Team1_Auto.PageObject;
using Scenario_Team1_Auto.TestSetup;

namespace Scenario_Team1_Auto.TestCase
{
    [TestFixture]
    public class LoginTest : ProjectNUnitTestSetup

    {
        [Test]
        public void AdminLogin() // admin login, verify authority of admin, change password, login with newpassword, reset password, logout, staff login, verify authority of staff, logout 
        {
            LoginPage loginPage = new LoginPage(_driver);
            HomePage homePage = new HomePage(_driver);
            string adminUserName = Constant.ADMIN_USERNAME;
            string adminPassword = Constant.ADMIN_PASSWORD;
            string newPassword = Constant.NEW_PASSWORD;

            loginPage.Login(adminUserName, adminPassword);
            homePage.VerifyAdminAccessAuthority();

            homePage.ChangePassword(adminPassword, newPassword);
            loginPage.Login(adminUserName, newPassword);

            homePage.ChangePassword(newPassword, adminPassword);
            loginPage.Login(adminUserName, adminPassword);
            homePage.Logout();

           
        }
        [Test]
        public void StaffLogin()
        {
            LoginPage loginPage = new LoginPage(_driver);
            HomePage homePage = new HomePage(_driver);
            string staffUserName = Constant.STAFF_USERNAME;
            string staffPassword = Constant.STAFF_PASSWORD;

            loginPage.Login(staffUserName, staffPassword);
            homePage.VerifyStaffAccessAuthority();
            homePage.Logout();
        }

    }
}
