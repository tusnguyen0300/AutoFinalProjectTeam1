
namespace Scenario_Team1_Auto.DAO
{
    public class UserListDAO
    {
        public string assetId { get; set; }
        public string name { get; set; }
       
        public string specification { get; set; }
        public string installedDate { get; set; }
        public string state { get; set; }
        public Location location { get; set; }
        public UserListDAO(string assetId, string name, string specification, string installedDate, string state, Location location)
        {
            this.assetId = assetId;
            this.name = name;
            
            this.specification = specification;
            this.installedDate = installedDate;
            this.state = state;
            this.location = location;
        }
        public Dictionary<string, object> ConvertAssetData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["assetId"] = assetId;
            data["name"] = name;
            data["location"] = location.City;
            data["specification"] = specification;
            data["installedDate"] = installedDate;
            data["state"] = state;
            return data;

        }
        
    }
    public class ListContentDAO
    {
        public List<UserListDAO> content { get; set; }
    }
    public class Location
    {
        public Location(long locationId, string city)
        {
            LocationId = locationId;
            City = city;
        }

        public long LocationId { get; set; }

        public string City { get; set; }
    }
    

}
