using CoreFramework.APICore;
using Newtonsoft.Json;
using NUnit.Framework;
using Scenario_Team1_Auto.DAO;
using Scenario_Team1_Auto.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.Services
{
    public class NashAuthorizationService
    {
        private string loginPath = "/api/v1/auth/login";
       
        public APIResponse LoginRequest(string username, string password)
        {
           string body = "{\"username\":\"" + username + "\",\"password\":\"" + password + "\"}";
           
            TestContext.WriteLine(body);
            APIResponse response = new APIRequest()
                .SetUrl(Constant.BASE_HOST + loginPath)
                .AddHeader("Content-Type", "application/json")
                .SetBody(body)
                .Post();
            return response;
        }

        public NashUserDAO? Login(string  username, string password)
        {
            APIResponse response = LoginRequest(username, password);
            Assert.True(response.responseStatusCode.Equals("OK"));

            NashUserDAO? user = (NashUserDAO) JsonConvert.DeserializeObject<NashUserDAO>(response.responseBody);
            TestContext.WriteLine(user?.accessToken);
            return user;
        }
    }
}
