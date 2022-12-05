using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.DAO
{
    public class CreateUserDAO
    {
        public string birthDate { get; set; }
        public string createdAt { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string lastName { get; set; }
        public string role { get; set; }

        public CreateUserDAO(string birthDate, string createdAt, string firstName, string gender, string lastName, string role)
        {
            this.birthDate = birthDate;
            this.createdAt = createdAt;
            this.firstName = firstName;
            this.gender = gender;
            this.lastName = lastName;
            this.role = role;
        }

    }
}
