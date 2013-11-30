using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Hangman
    {
        string word;
        char[] guessed;
        string letter;
        int body;
        List<char> tracker;        

        public Hangman()
        {
            tracker = new List<char>();
            body = 0;
            Console.Write("Please select a word to be guessed\n");
            word = Console.ReadLine().ToUpper();

            char[] replace;
            replace = new char[word.Length];

            for (int j = 0; j < word.Length; j++)
            {
                replace[j] = '_';
            }

            guessed = replace;
        }

        public void DisplayBlanks()
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.Write("\n");
        }

        public void DisplayGuessed()
        {
            char[] display = guessed;

            for (int i = 0; i < display.Length; i++ )
            {
                Console.Write(display[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        public void GuessLetter()
        {
            Console.Write("Please enter a letter: ");
            letter = Console.ReadLine().ToUpper();

            if (letter.Length != 1)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("\n\nYou have entered invalid input\n\n");
                GuessLetter();
            }

            if (tracker.Contains(letter[0]))
            {
                Console.Write("You have already guessed this letter\n\n");
                GuessLetter();
            }
            else
            {
                tracker.Add(letter[0]);
            }
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

        public bool CheckWord()
        {
            foreach (var i in guessed)
            {
                if (i == '_')
                {
                    return false;
                }
            }
            return true;
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

            for(int j=0; j<guessed.Length;j++)
            {
                replace[j] = guessed[j];
            }

            foreach (var i in indexList)
            {
                replace[i] = l[0];
            }

            guessed = replace;
        }

        public void AddBodyPart()
        {
            body++;
            if (body == 1)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("Your head was attached to the gallows\n");
            }
            else if (body == 2)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("Your chest was attached to the gallows\n");
            }
            else if (body == 3)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("Your left arm was attached to the gallows\n");
            }
            else if (body == 4)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("Your right arm was attached to the gallows\n");
            }
            else if (body == 5)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("Your left leg was attached to the gallows\n");
            }
            else if (body == 6)
            {
                Console.Clear();
                DisplayGuessed();
                Console.Write("Your right leg was attached to the gallows\n");
                Console.Write("You have died\n");
                Console.Write("\n\nThe word was ");
                Console.Write(word);
                Console.Write("\n\n");
            }
        }

        public string Word
        {
            get
            {
                return word;
            }
        }

        public string Letter
        {
            get
            {
                return letter;
            }
        }

        public char[] Guessed
        {
            get
            {
                return guessed;
            }
        }

        public int Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }

    }
}
