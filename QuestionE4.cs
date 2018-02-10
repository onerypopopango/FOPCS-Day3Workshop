using System;
using System.Threading;

namespace Day3Workshop
{
    class E4
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep
            bool perfectnumber = false;
            int sum = 0;

            Console.Write("Toss me a number above zero: ");
            int N = Int32.Parse(Console.ReadLine());
            int r = 0;

            for (int i = 1; i <= N; i++)
            {
                r = N % i;

                if ((i != N) && (r == 0))
                {
                    sum = sum + i;

                    if (sum == N)
                    {
                        perfectnumber = true;
                    }

                    else
                    {
                        perfectnumber = false;
                    }

                }
            }

            if (perfectnumber == true)
            {
                Console.WriteLine("The number is a perfect number.");
            }

            else
            {
                Console.WriteLine("The number is not a perfect number.");
            }
        }
    }
}
