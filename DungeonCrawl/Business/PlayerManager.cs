using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class PlayerManager
    {
        public PlayerManager()
        {

        }

        public List<Player> GetsAllPlayers()
        {
            return PlayerDA.GetsAllPlayers();
        }

        public void AddsPlayer(Player p)
        {
            PlayerDA.AddsPlayer(p);
        }

        public void DeletesPlayer(Player p)
        {
            PlayerDA.DeletesPlayer(p);
        }
    }
}
