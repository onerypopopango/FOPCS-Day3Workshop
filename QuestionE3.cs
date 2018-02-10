using System;
using System.Threading;

namespace Day3Workshop
{
    class E3
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep
            bool primenumber = true;

            Console.Write("Toss me a number above zero: ");
            int N = Int32.Parse(Console.ReadLine());
            int r = 0;

            for (int i = 1; i <= N; i++)
            {
                r = N % i;

                if ((i != 1) && (i != N) && (r == 0))
                {
                    primenumber = false;
                }
            }

            if (primenumber == true)
            {
                Console.WriteLine("The number is a prime number.");
            }

            else
            {
                Console.WriteLine("The number is not a prime number.");
            }
        }
    }
}
