using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            //string pause;
            string check = "yes";

            while (check == "yes")
            {
                Hangman hang;

                //Intro
                Console.Write("________Hangman_______\n\n");
                Console.Write("Developed by:\n");
                Console.Write("Josiah Evans and Jonathan Breedlove\n");

                //Input
                Console.Write("\n\nStart a new game?(yes/no):");
                check = Console.ReadLine();

                //Check user's input
                if (check == "yes")
                {
                    Console.Write("\n\nInput was yes\n\n");
                    hang = new Hangman();
                    hang.DisplayBlanks();

                    while (hang.Body < 6 && hang.CheckWord() == false)
                    {
                        hang.GuessLetter();
                        if (hang.CheckLetter(hang.Letter))
                        {
                            hang.FillInBlanks(hang.FindIndices(hang.Word, hang.Letter), hang.Letter);
                            hang.DisplayGuessed();
                        }
                        else
                        {
                            hang.AddBodyPart();
                        }
                    }
                }
                else if (check == "no")
                {
                    Console.Write("\n\nInput was no\n\n");
                }
                else
                {
                    Console.Write("\n\nThat was not valid input\n\n");
                }
                Console.Write("Would you like to play again? (yes/no)");
                check = Console.ReadLine();
            }
            //pause = Console.ReadLine();
        }
    }
}