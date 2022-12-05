using Scenario_Team1_Auto.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.TestData
{
    public class AssignmentTestData
    {

        public List<AssignmentDAO> testAssignmentRow = new List<AssignmentDAO>();
        public void CreateTestAssignmentRow()
        {
            testAssignmentRow.Add(new AssignmentDAO("", "", "", "", "", ""));
        }
    }
}
