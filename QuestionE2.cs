using System;
using System.Threading;

namespace Day3Workshop
{
    class E2
    {
        static void Main(string[] args)
        {
            int timing1 = 1000;         //for thread.sleep
            double inverse = 0, sqrt = 0, square = 0;

            Console.WriteLine("Are you ready?");
            Thread.Sleep(timing1);
            Console.WriteLine("Here we go...");
            Thread.Sleep(timing1);

            Console.WriteLine();
            Console.WriteLine("NO\t\tINVERSE\t\tSQRT\t\tSQUARE");
            Console.WriteLine("===========================================================");

            for (double i = 1; i <= 10; i++)
            {
                inverse = (1 / i);
                sqrt = Math.Sqrt(i);
                square = Math.Pow(i, 2);

                Console.WriteLine("{0:0.0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}", i, inverse, sqrt, square);
            }

        }
    }
}
