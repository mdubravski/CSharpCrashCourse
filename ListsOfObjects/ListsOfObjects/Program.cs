using System;
using System.Collections.Generic;

namespace ListsOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>();

            playerList.Add(new Player("@michael"));
            playerList.Add(new Player("@peter"));
            playerList.Add(new Player("@jacob"));

            foreach (Player p in playerList) 
            {
                Console.WriteLine(p);
            } 


            Console.ReadKey();
        }
    }

    class Player 
    {
        public string username;

        public Player(string username) 
        {
            this.username = username;
        }

        public override string ToString() 
        {
            return username;
        }
    }
}
