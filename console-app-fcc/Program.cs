using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_fcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Your guess so far => {0}", guess.Length > 0 ? guess : "none" );
                    Console.Write("Enter the guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }
            }  while (guess != secretWord  && !outOfGuesses);

            switch(outOfGuesses)
            {
                case true:
                    Console.Write("You Lose!");
                    break;
                case false:
                    Console.Write("You Win!");
                    break;
                default:
                    Console.WriteLine("Game has started!");
                    break;
            }

            // Console.ReadLine() acts as prompt that watches, reads and returns for user input as string and also pauses the console without closing
            Console.ReadLine();
        }
    }
}
