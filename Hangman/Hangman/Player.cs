using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Player
    {
        string name;
        int wins;
        int losses;

        public Player()
        {
            wins = 0;
            losses = 0;
            Console.Write("Please choose a player name\n");
            name = Console.ReadLine();
        }

        public Player(string n, int w, int l)
        {
            name = n;
            wins = w;
            losses = l;
        }
    }
}
