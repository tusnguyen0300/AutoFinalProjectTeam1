using CoreFramework.NUnitTestSetup;
using NUnit.Framework;
using Scenario_Team1_Auto.DAO;
using Scenario_Team1_Auto.Services;

namespace Scenario_Team1_Auto.TestSetup
{
    public class NashNUnitAPITestSetup : NUnitTestSetup
    {
        public NashUserDAO user;
        public AssetService assetService;
        public NashAuthorizationService nashAuthorizationService;
        [SetUp]
        public void SetUp()
        {
            nashAuthorizationService = new NashAuthorizationService();
            assetService = new AssetService();
            user = nashAuthorizationService.Login(Constant.ADMIN_USERNAME, Constant.ADMIN_PASSWORD);


///////




        }
        [TearDown]
        public void TearDown()
        {

            
        }
    }
}
