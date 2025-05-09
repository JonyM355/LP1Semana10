using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    public class Program
    {
        private static void Main()
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>
            {
                new Player(PlayerClass.Tank, "Ana"),
                new Player(PlayerClass.Slayer, "Paulo"),
                new Player(PlayerClass.Tank, "Ana") // Duplicado
            };

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
