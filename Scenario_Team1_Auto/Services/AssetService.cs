using CoreFramework.APICore;
using Newtonsoft.Json;
using NUnit.Framework;
using Scenario_Team1_Auto.DAO;
using Scenario_Team1_Auto.PageObject;
using Scenario_Team1_Auto.TestData;
using Scenario_Team1_Auto.TestSetup;
using System.Security.Cryptography.X509Certificates;

namespace Scenario_Team1_Auto.Services
{
    public class AssetService 
    {
        private string getAssetPath = "/api/v1/admin/assets/";
        private string createAssetPath = "/api/v1/admin/assets/";
        public List<AssetDAO> testRecord = new List<AssetDAO>();    
        
        public APIResponse GetAssetRequest(string token)
        {
            APIResponse response = new APIRequest()
                .SetUrl(Constant.nashHost + getAssetPath)
                .AddHeader("Authorization","Bearer " + token)
                .Get();
            return response;
        }
        public ContentDAO GetAssets(string token)
        {
            APIResponse response = GetAssetRequest(token);
            Assert.True(response.responseStatusCode.Equals("OK"));
            var jsonResponse = response.responseBody;
            ContentDAO content = (ContentDAO)JsonConvert.DeserializeObject<ContentDAO>(jsonResponse);
            return content;
        }
        public APIResponse CreateNewAssetRequest(string token)
        {
            AssetTestData assetTestData = new AssetTestData();
            assetTestData.CreateTestAsset();
            testRecord = assetTestData.testAsset;
            var row = testRecord.ElementAtOrDefault(0);
            var dict = row?.ConvertAssetData(); 
            // bat mic team view di b nghe thaya khog

            var jsonBody = JsonConvert.SerializeObject(dict); // cho nay convert cai Dictionary thanh string theo dung cai m vua viet trong hamf ConvertAssetsData

            TestContext.WriteLine(jsonBody);

            APIResponse response = new APIRequest()
                    .SetUrl(Constant.nashHost + createAssetPath)
                    .AddHeader("Content-Type", "application/json")
                    .AddHeader("Authorization", "Bearer " + token)
                    .SetBody(jsonBody)
                    .Post();
                return response;
        }
       
    }
}
