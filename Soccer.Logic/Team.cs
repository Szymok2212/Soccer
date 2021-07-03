using System;
using System.Collections.Generic;
using System.Text;

namespace Soccer.Logic
{
     public class Team
    {

        public List<Player> Players { get; private set; }

        public string TeamName { get; set; }

        public Team(string teamName)
        {
            Players = new List<Player>();
            TeamName = teamName;
           
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

    }
}
