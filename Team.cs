using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_APP
{
    class Team
    {

        string teamName;
        string country;

        public Team()
        {
        }

        public Team(string teamName, string country)
        {
            TeamName = teamName;
            Country = country;
        }

        public string TeamName { get => teamName; set => teamName = value; }
        public string Country { get => country; set => country = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            Team obj_team = (Team)obj;
            return this.TeamName.Equals(obj_team.TeamName);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
