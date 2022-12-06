using CoreFramework.NUnitTestSetup;
using NUnit.Framework;
using Scenario_Team1_Auto.DAO;
using Scenario_Team1_Auto.PageObject;
using Scenario_Team1_Auto.Services;

namespace Scenario_Team1_Auto.TestSetup
{
    public class NashNUnitAPITestSetup : NUnitTestSetup
    {
        public NashUserDAO user;
        public NewUserDAO newUserInfo;
       
        public NashAuthorizationService nashAuthorizationService;
        public CreateUserService createUserService;
        public LoginPage loginPage;
        [SetUp]
        public void SetUp()
        {
            nashAuthorizationService = new NashAuthorizationService();
            createUserService = new CreateUserService();
            loginPage = new LoginPage(_driver);

            user = nashAuthorizationService.Login(Constant.ADMIN_USERNAME, Constant.ADMIN_PASSWORD);
            newUserInfo = createUserService.GetNewUserInfo(user.accessToken);

            string userName = newUserInfo.username;
            string password = CreateUserService.ConversePassword(newUserInfo.birthDate);
            Console.WriteLine(userName);
            Console.WriteLine (password);

            driverBaseAction.GoToURL(Constant.BASE_URL);

            loginPage.Login(userName,userName +"@" + password);
            loginPage.ChangePasswordForTheFirstTime(Constant.NEW_PASSWORD1);

        }

        [TearDown]

        public void TearDown()
        {

        }
    }
}
