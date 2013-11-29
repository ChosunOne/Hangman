using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Hangman
    {
        string word;
        string guessed;


        public Hangman()
        {
            Console.Write("Please select a word to be guessed\n");
            word = Console.ReadLine();
        }

        public void DisplayBlanks()
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.Write("\n");
        }

        public string Word
        {
            get
            {
                return word;
            }
        }

    }
}
