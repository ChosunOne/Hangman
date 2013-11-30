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
            string check = "YES";

            while (check.ToUpper() == "YES")
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
                if (check.ToUpper() == "YES")
                {
                    Console.Write("\nInput was yes\n\n");
                    hang = new Hangman();

                    Console.Clear();

                    hang.DisplayBlanks();

                    while (hang.Body < 6 && hang.CheckWord() == false)
                    {
                        hang.GuessLetter();
                        if (hang.CheckLetter(hang.Letter))
                        {
                            hang.FillInBlanks(hang.FindIndices(hang.Word, hang.Letter), hang.Letter);
                            Console.Clear();
                            hang.DisplayGuessed();
                        }
                        else
                        {
                            hang.AddBodyPart();
                        }
                    }

                    if( hang.CheckWord() )
                    {
                        Console.Write("You have won!\n\n");
                    }
                }
                else if (check.ToUpper() == "NO")
                {
                    Console.Write("\n\nInput was no\n\n");
                }
                else
                {
                    Console.Write("\n\nThat was not valid input\n\n");        
                }

                Console.Write("Would you like to play again? (yes/no)");                
                check = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            //pause = Console.ReadLine();
        }
    }
}