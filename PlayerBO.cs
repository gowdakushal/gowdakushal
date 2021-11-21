using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_APP
{
    class PlayerBO
    {
        public Player[] SearchBYTeamName(Player[] playerList)
        {
            //Player[] results=null;
            SortingTeam s1 = new SortingTeam();
            Array.Sort(playerList, s1);
            //results = playerList;
            return playerList;
        }
        public Player[] SearchBYBattingStyle(Player[] playerList)
        {
            Player[] results = null;
            SortingPlayers sp = new SortingPlayers();
            Array.Sort(playerList, sp);
            Array.Reverse(playerList);
            results = playerList;
            return results;
        }
    }
}
