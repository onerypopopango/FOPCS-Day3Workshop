using System;
using System.Threading;

namespace Day3Workshop
{
    class E1a
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a number: ");
            int N = Int32.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("The factorial of your number is {0}", factorial);

            //factorials higher than 16 returns a negative answer...
        }
    }
}
