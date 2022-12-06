using CoreFramework.APICore;
using Newtonsoft.Json;
using NUnit.Framework;
using Scenario_Team1_Auto.DAO;
using Scenario_Team1_Auto.TestData;
using Scenario_Team1_Auto.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.Services
{
    public class ChangePasswordFirstTimeService
    {
        private string createUserPath = "/api/v1/auth/change-password";
        public void ChangePasswordRequest(string token,string newPassword)
        {
            string body = "{\"oldPassword\":null, \"newPassword\" : \"" + newPassword + "\"}";

            TestContext.WriteLine(body);

            APIResponse response = new APIRequest()
                    .SetUrl(Constant.BASE_HOST + createUserPath)
                    .AddHeader("Content-Type", "application/json")
                    .AddHeader("Authorization", "Bearer " + token)
                    .SetBody(body)
                    .Patch();
        }
    }
}
