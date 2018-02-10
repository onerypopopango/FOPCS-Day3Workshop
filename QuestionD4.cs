using System;
using System.Threading;

namespace Day3Workshop
{
    class D4
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            string input = Console.ReadLine();
            int n = Int32.Parse(input);
            double N = Double.Parse(input);

            Random rnd = new Random();
            double G = rnd.Next(1, n);

            double difference = Math.Abs(0.00001);       //google Double.Equals Method (Double)

            while (Math.Abs(N - (G * G)) >= difference)
            {
                G = ((G + (N / G)) / 2);
            }

            Console.WriteLine("The square root of your number is: {0:#.###}", G);

        }
    }
}
