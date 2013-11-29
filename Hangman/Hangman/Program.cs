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
            string pause;
            string check;

            //Intro
            Console.Write("________Hangman_______\n\n");
            Console.Write("Developed by:\n");
            Console.Write("Josiah Evans and Jonathan Breedlove\n");

            //Input
            Console.Write("\n\nStart a new game?(yes/no):");
            check = Console.ReadLine();

            //Check user's input
            if( check == "yes" )
            {
                Console.Write("\n\nInput was yes\n\n");
            }
            else if (check == "no")
            {
                Console.Write("\n\nInput was no\n\n");
            }
            else
            {
                Console.Write("\n\nThat was not valid input\n\n");
            }
            
            pause = Console.ReadLine();
        }
    }
}