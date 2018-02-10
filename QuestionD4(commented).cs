using System;
using System.Threading;

namespace Day3Workshop
{
    class D4Comment
    {
        static void Main(string[] args)
        {
            //a.Take as input the number (N) for finding the square root
            Console.Write("Give me a number: ");
            string input = Console.ReadLine();
            int n = Int32.Parse(input);
            double N = Double.Parse(input);

            //b.Take a random number between 1 and N using the function RND.Let the integer be
            //called a Guess, G (not necessarily an integer).
            Random rnd = new Random();
            double G = rnd.Next(0, n);

            //c. If the Guess is correct then G*G should be N.
            double G2 = G * G;
            double difference = Math.Abs(N * .00001);       //google Double.Equals Method (Double)

            //d. If not use the following formula iteratively until G*G approximates to N to an accuracy of
            //5 decimal places:
            //G = ((G + (N/G)) / 2)
            while (Math.Abs(N - G2) >= difference)
            {
                G = ((G + (N / G)) / 2);
                G2 = G * G;
            }

            Console.WriteLine("The square root of your number is: {0:#.###}", G);

        }
    }
}
