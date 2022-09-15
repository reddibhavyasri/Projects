using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProjectOndata
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playername);
        List<Player> GetAllPlayers();
    }
    
        public class OneDayTeam :Player, ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
          
       

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public void Remove(int playerId)
        {
            Player player = null;
            foreach(var item in oneDayTeam)
            {
                if(item.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully",item.PlayerId);
                    player= item;
                }
            }
            oneDayTeam.Remove(player);
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = null;
            foreach(var item in oneDayTeam)
            {
                if (item.PlayerId == playerId)
                {
                    player = item;
                    break;
                }
                else
                {
                    Console.WriteLine("Playerid not found");
                }

            }
            return player;
        }

        public Player GetPlayerByName(string playername)
        {
            Player player= null;
            foreach(var item in oneDayTeam)
            {
                if (item.PlayerName == playername)
                {
                    player= item;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Name not found");
                }
            }
            return player;
            
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }

       
    }
        
    



