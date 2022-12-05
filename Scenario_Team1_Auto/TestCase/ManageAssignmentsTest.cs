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
    public class ManageAassignments : NashNUnitAPITestSetup
    {
        [Test]
        public void ViewAllAassignment() // admin view Aassignments Page, Assignments List and detail of Aassignments
        {
            LoginPage loginPage = new LoginPage(_driver);
            HomePage homePage = new HomePage(_driver);
            ManageAssignmentsPage manageAssignmentsPage = new ManageAssignmentsPage(_driver);

            string userName = Constant.ADMIN_USERNAME;
            string password = Constant.ADMIN_PASSWORD;

            loginPage.Login(userName, password);

            homePage.GetManageAassignmentsPage();

            manageAssignmentsPage.VerifyManageAssignmentsPageDisplay();

            manageAssignmentsPage.GetAssignmentList();


            manageAssignmentsPage.GetDetailOfRandomAssignment();
            manageAssignmentsPage.VerifyAssignmentPopupDisplay();
        }
    }
}
