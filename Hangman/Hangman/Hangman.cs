using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Hangman
    {
        bool addPart;
        string word;
        char[] guessed;
        string letter;
        int body;
        List<char> tracker;        

        public Hangman()
        {
            addPart = false;
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

        public Hangman(string w)
        {
            addPart = false;
            tracker = new List<char>();
            body = 0;
            word = w.ToUpper();

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

        public string ReturnGuessed()
        {
            char[] display;
            string output;
            display = new char[guessed.Length * 2];
            for (int i = 0, j = 0; i < guessed.Length; i++)
            {
                display[j] = guessed[i];
                display[j + 1] = ' ';
                j += 2;
            }
            output = new string(display);
            return output;
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

        public void DisplayMenu()
        {
            string option;
            Console.Clear();
            if (addPart)
            {
                AddBodyPart();
                addPart = false;
            }
            DisplayGuessed();
            Console.Write("Would you like to Guess a:");
            Console.Write("\nWord   (1) ");
            Console.Write("\nLetter (2) \n");
            option = Console.ReadLine();
            if (option == "1" || option.ToUpper() == "WORD")
            {
                if (GuessWord())
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        guessed[i] = word[i];
                    }
                }
                else
                {
                    AddBodyPart();
                }
            }
            else if (option == "2" || option.ToUpper() == "LETTER")
            {
                GuessLetter();
            }
            else
            {
                DisplayMenu();
            }
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

            if (CheckLetter(letter))
            {
                FillInBlanks(FindIndices(word, letter), letter);
                Console.Clear();
                DisplayGuessed();
            }
            else
            {
                addPart = true;
            } 
        }

        public string GuessLetter(string l)
        {
            string output;
            letter = l.ToUpper();
            if (letter.Length != 1)
            {
                output = "You have entered invalid input.";
                return output;
                
            }

            if (tracker.Contains(letter[0]))
            {
                output = "You have already guessed this letter.";
                return output;
            }
            else
            {
                tracker.Add(letter[0]);
            }

            if (CheckLetter(letter))
            {
                FillInBlanks(FindIndices(word, letter), letter);
                ReturnGuessed();
            }
            else
            {
                output = HangBodyPart();
                return output;
            }

            output = ReturnGuessed();
            return output;
        }

        public bool GuessWord()
        {
            string guess;
            Console.Clear();
            DisplayGuessed();
            Console.Write("Guess the word\n");
            guess = Console.ReadLine().ToUpper();
            if (guess == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GuessWord(string w)
        {
            string guess;
            guess = w.ToUpper();
            if (guess == word)
            {
                return true;
            }
            else
            {
                return false;
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
                Console.Write("Your head was attached to the gallows\n");
            }
            else if (body == 2)
            {
                Console.Clear();
                Console.Write("Your chest was attached to the gallows\n");
            }
            else if (body == 3)
            {
                Console.Clear();
                Console.Write("Your left arm was attached to the gallows\n");
            }
            else if (body == 4)
            {
                Console.Clear();
                Console.Write("Your right arm was attached to the gallows\n");
            }
            else if (body == 5)
            {
                Console.Clear();
                Console.Write("Your left leg was attached to the gallows\n");
            }
            else if (body == 6)
            {
                Console.Clear();
                Console.Write("Your right leg was attached to the gallows\n");
                Console.Write("You have died\n");
                Console.Write("\n\nThe word was ");
                Console.Write(word);
                Console.Write("\n\n");
            }
        }

        public string HangBodyPart()
        {
            string output;
            body++;
            if (body == 1)
            {
                output = "Your head was attached to the gallows.";
                return output;
            }
            else if (body == 2)
            {
                output = "Your chest was attached to the gallows.";
                return output;
            }
            else if (body == 3)
            {
                output = "Your left arm was attached to the gallows.";
                return output;
            }
            else if (body == 4)
            {
                output = "Your right arm was attached to the gallows.";
                return output;
            }
            else if (body == 5)
            {
                output = "Your left leg was attached to the gallows.";
                return output;
            }
            else if (body == 6)
            {
                output = "Your right leg was attached to the gallows. You have died.";
                return output;
            }
            else
            {
                output = "An error has occurred.  Somehow body has become a value of " + Convert.ToString(body);
                return output;
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
            set
            {
                guessed = value;
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
