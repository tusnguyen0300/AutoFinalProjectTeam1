using Scenario_Team1_Auto.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.TestData
{
    public class AssetTestData
    {
       public List<AssetDAO> testAsset = new List<AssetDAO>();
        
       public void CreateTestAsset()
       {
            var category = new Category(1, "Monitor");
            testAsset.Add(new AssetDAO("", "Sang Personal Computer", category, "Sang Imac 2021 Pro", "2022-11-30", "NOT_AVAILABLE"));
       }
    }
    
}
