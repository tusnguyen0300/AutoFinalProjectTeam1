
namespace Scenario_Team1_Auto.DAO
{
    public class AssetDAO
    {
        public string assetId { get; set; }
        public string name { get; set; }
        public Category category { get; set; }
        public string specification { get; set; }
        public string installedDate { get; set; }
        public string state { get; set; }
        public AssetDAO(string assetId, string name, Category category, string specification, string installedDate, string state)
        {
            this.assetId = assetId;
            this.name = name;
            this.category = category;
            this.specification = specification;
            this.installedDate = installedDate;
            this.state = state;
        }
        public Dictionary<string, object> ConvertAssetData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["assetId"] = assetId;
            data["name"] = name;
            data["category"] = category.CategoryId;
            data["specification"] = specification;
            data["installedDate"] = installedDate;
            data["state"] = state;
            return data;

        }
        
    }
    public class ContentDAO
    {
        public List<AssetDAO> content { get; set; }
    }
    public class Category
    {
        public Category(long categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public long CategoryId { get; set; }

        public string Name { get; set; }
    }
    

}
