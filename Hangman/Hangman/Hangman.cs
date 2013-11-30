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
        string letter;

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

        public void GuessLetter()
        {
            Console.Write("Please enter a letter: ");
            letter = Console.ReadLine();
        }

        public bool CheckLetter( string l )
        {
            char guess = l[0];

            foreach (var i in word)
            {
                if(i == guess)
                {
                    return true;
                }
            }

            return false;
        }

        public List<int> FindIndices( string w, string l )
        {
            int count = 0;
            List<int> indexAry;
            indexAry = new List<int>();

            foreach( var i in word )
            {
                if( i == l[0] )
                {
                    indexAry.Add(count);
                }

                count++;
            }

            return indexAry;
        }

        public void FillInBlanks( List<int> indexList, string l )
        {
            char[] replace;
            int length = guessed.Length;
            replace = new char[length];
            int count = 0;

            foreach(var j in guessed)
            {
                replace[j] = guessed[count];
                count++;
            }

            foreach (var i in indexList)
            {
                replace[i] = l[0];
            }

            guessed = replace.ToString();
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
