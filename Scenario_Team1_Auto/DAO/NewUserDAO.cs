using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.DAO
{
    public class NewUserDAO
    {
        public string username { get; set; }
        public string birthDate { get; set; }

        public NewUserDAO(string username, string birthDate)
        {
            this.username = username;
            this.birthDate = birthDate;
        }
    }
}
