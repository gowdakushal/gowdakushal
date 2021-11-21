using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_APP
{
    class SortingTeam : IComparer<Player>
    {

        public int Compare(Player x, Player y)
        {
            return x.TeamName.CompareTo(y.TeamName);
        }
    
    }
}
