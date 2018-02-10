using System;

namespace Day3Workshop
{
    class D2
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, X = 0, Y = 0;

            Console.Write("Give me a number, A: ");
            A = Int32.Parse(Console.ReadLine());

            Console.Write("Now give me another, B: ");
            B = Int32.Parse(Console.ReadLine());

            int a = A, b = B;


            while (a != b)
            {
                if (a > b)
                {
                    X = a - b;
                    a = X;
                }

                else if (b > a)
                {
                    X = b - a;
                    b = X;
                }
            }

            Y = (A * B) / X;

            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("HCF = {0}", X);
            Console.WriteLine("LCM = {0}", Y);
        }
    }
}
