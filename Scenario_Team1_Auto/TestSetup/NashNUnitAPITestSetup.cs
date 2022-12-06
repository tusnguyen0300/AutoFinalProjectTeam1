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
        public ChangePasswordFirstTimeService changePasswordFirstTimeService;

        [SetUp]
        public void SetUp()
        {
            nashAuthorizationService = new NashAuthorizationService();
            createUserService = new CreateUserService();
            changePasswordFirstTimeService = new ChangePasswordFirstTimeService();
            loginPage = new LoginPage(_driver);

            user = nashAuthorizationService.Login(Constant.ADMIN_USERNAME, Constant.ADMIN_PASSWORD);

            newUserInfo = createUserService.GetNewUserInfo(user.accessToken);

            string userName = newUserInfo.username;
            string password = CreateUserService.ConversePassword(userName,newUserInfo.birthDate);
            Console.WriteLine(userName);
            Console.WriteLine(password);

            user = nashAuthorizationService.Login(userName, password);

            changePasswordFirstTimeService.ChangePasswordRequest(user.accessToken,Constant.NEW_PASSWORD1);

            driverBaseAction.GoToURL(Constant.BASE_URL);

           
           

        }

        [TearDown]

        public void TearDown()
        {

        }
    }
}
