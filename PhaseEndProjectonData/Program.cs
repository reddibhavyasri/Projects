using System;
using System.Activities.Expressions;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProjectOndata
{
    public class Program
    {


        static void Main(string[] args)
        {
            asnmnt:
            Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players:");
            int Number = Convert.ToInt32(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    OneDayTeam onedayteam1 = new OneDayTeam();
                    if (OneDayTeam.oneDayTeam.Count <= OneDayTeam.oneDayTeam.Capacity)
                    {
                        Console.WriteLine("Enter Player ID");
                        onedayteam1.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        onedayteam1.PlayerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        onedayteam1.PlayerAge = Convert.ToInt32(Console.ReadLine());
                        onedayteam1.Add(onedayteam1);
                    }
                    else
                    {
                        Console.WriteLine("You cannot add more than 11 Players.");
                    }
                    break;
                case 2:
                    OneDayTeam onedayteam2 = new OneDayTeam();
                    Console.WriteLine("Enter Player ID to Remove:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    onedayteam2.Remove(id);
                    break;
                case 3:
                    OneDayTeam onedayteam3 = new OneDayTeam();
                    Console.WriteLine("Enter Player ID:");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    Player player1 = onedayteam3.GetPlayerById(id1);
                    Console.WriteLine("Player ID: " + player1.PlayerId);
                    Console.WriteLine("Player Name: " + player1.PlayerName);
                    Console.WriteLine("Player Age: " + player1.PlayerAge);
                    break;
                case 4:
                    OneDayTeam onedayteam4 = new OneDayTeam();
                    Console.WriteLine("Enter Player Name:");
                    string name = Console.ReadLine();
                    Player player2 = onedayteam4.GetPlayerByName(name);
                    Console.WriteLine("Player ID: " + player2.PlayerId);
                    Console.WriteLine("Player Name: " + player2.PlayerName);
                    Console.WriteLine("Player Age: " + player2.PlayerAge);
                    break;
                case 5:
                    Console.WriteLine("All Players details:");
                    List<Player> all = new List<Player>();
                    OneDayTeam onedayteam5 = new OneDayTeam();
                    all = onedayteam5.GetAllPlayers();
                    foreach (var item in all)
                    {
                        Console.WriteLine("Player ID: " + item.PlayerId);
                        Console.WriteLine("Player Name: " + item.PlayerName);
                        Console.WriteLine("Player Age: " + item.PlayerAge);
                    }
                    break;
                
            }
            Console.WriteLine("Do you want to continue (yes/no)?");
            string num = Console.ReadLine();
            if (num == "yes")
            {
                goto asnmnt;
            }
            else if (num == "no")
            {
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
    }
