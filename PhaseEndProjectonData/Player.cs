using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProjectOndata
{
    public class Player
    {
        private int playerid;
        public int PlayerId
        {
            get { return playerid; }
            set { playerid = value; }
        }
        private string playername;
        public string PlayerName
        {
            get { return playername; }
            set { playername = value; }
        }
        private int playerage;
        public int PlayerAge
        {
            get { return playerage; }
            set
            {
                playerage = value;
            }
        }
    }
}
