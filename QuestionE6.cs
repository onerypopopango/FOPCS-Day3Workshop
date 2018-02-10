using System;
using System.Threading;

namespace Day3Workshop
{
    class E6
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep

            Console.WriteLine("Perfect Numbers between 1 and 1000 are: ");

            for (int h = 1; h <= 1000; h++)
            {
                bool perfectnumber = false;
                int sum = 0;
                int r = 0;
                int i = 0;

                for (i = 1; i <= h; i++)
                {
                    r = h % i;

                    if ((i != h) &&(r == 0))
                    {
                        sum = sum + i;

                        if (sum == h)
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
                    Console.WriteLine(h);
                }
            }
        }
    }
}
