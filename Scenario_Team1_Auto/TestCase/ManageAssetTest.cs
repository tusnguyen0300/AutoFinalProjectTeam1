using NUnit.Framework;
using Scenario_Team1_Auto.DAO;
using Scenario_Team1_Auto.Services;
using Scenario_Team1_Auto.TestSetup;
using System.Xml.Linq;

namespace Scenario_Team1_Auto.TestCase
{
    [TestFixture]
    public class ManageAssetTest : NashNUnitAPITestSetup
    {
        
        AssetService assetService = new AssetService();
        [Test]
        public void GetListAssetTest() // admin is able to view assets list
        {
            ContentDAO expectedAssets = assetService.GetAssets(user.accessToken);

            for (int i = 0; i < expectedAssets.content.Count; i++)
            {
                TestContext.WriteLine(expectedAssets.content[i].assetId);
                TestContext.WriteLine(expectedAssets.content[i].name);
                TestContext.WriteLine(expectedAssets.content[i].specification);
                TestContext.WriteLine(expectedAssets.content[i].category.Name);
                TestContext.WriteLine(expectedAssets.content[i].installedDate);
                TestContext.WriteLine(expectedAssets.content[i].state);
            }
        }
        [Test]
        public void CreateNewAsset()// admin is able to create asset 
        {
            assetService.CreateNewAssetRequest(user.accessToken);
        }
    }
}
