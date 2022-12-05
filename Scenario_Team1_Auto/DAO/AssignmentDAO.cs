using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.DAO
{
    public class AssignmentDAO
    {
      
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public string AssignedDate { get; set; }
        public string State { get; set; }

        public AssignmentDAO(string assetCode, string assetName, string assignedTo, string assignedBy, string assignedDate, string state)
        {
          
            AssetCode = assetCode;
            AssetName = assetName;
            AssignedTo = assignedTo;
            AssignedBy = assignedBy;
            AssignedDate = assignedDate;
            State = state;
        }
    }
}
