using System;

namespace Day3Workshop
{
    class D1
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Guess a number. Any number: ");

            while (num != 88) 
            {
                num = Int32.Parse(Console.ReadLine());
                if (num == 88) { break; }
                Console.Write("Guess again: ");
            }

            Console.WriteLine("Lucky you...");
        }

    }
}
