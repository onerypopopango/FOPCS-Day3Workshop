using System;
using System.Threading;

namespace Day3Workshop
{
    class E5
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep
            bool primenumber = true;

            Console.WriteLine("Prime Numbers between 5 and 10000 are: ");
            int r = 0;

            for (int i = 5; i <= 10000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    r = i % j;

                    if ((j != 1) && (j != i) && (r == 0))
                    {
                        primenumber = false;
                    }

                }

                if (primenumber == true)
                {
                    Console.WriteLine(i);
                }

                else

                {
                    primenumber = true;     //reset switch
                }

            }
        }
    }
}
