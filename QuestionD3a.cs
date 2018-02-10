using System;
using System.Threading;

namespace Day3Workshop
{
    class D3a
    {
        static void Main(string[] args)
        {
            int millisecond = 1000;                 //set timer for thread.sleep
            int guesses = 0;

            Random rnd = new Random();              //sets a random generator, not a static method (eg Console.Writeline). Random.Next does not work

            int secret = rnd.Next(0, 10);           //random number between 1 and 9 ==> (1 <= secret < 10)
            bool correctguess = false;              //create a flag (THIS SEEMS REALLY IMPORTANT! REMEMBER IT!)

            Console.WriteLine("I'm thinking of a number between 0 and 9...");
            Thread.Sleep(millisecond);

            Console.Write("Can you guess which number I'm thinking of: ");
            string input = Console.ReadLine();

            while (!correctguess)
            {
                for (guesses = 1; guesses > 0; guesses++)
                {
                    if (input == secret.ToString())
                    {
                        correctguess = true;                //changes the flag
                        Console.WriteLine("Nice guess!");
                        Console.WriteLine("You've guessed {0} times.", guesses);
                        break;
                    }

                    else
                    {
                        Console.Write("Sorry, guess again: ");
                        input = Console.ReadLine();
                    }
                }
            }

        }
    }
}
