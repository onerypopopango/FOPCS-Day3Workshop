using System;
using System.Threading;

namespace Day3Workshop
{
    class F1a
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep

            Console.WriteLine("Write down a sentence or phrase: ");
            string input = Console.ReadLine().ToLower();                //takes input and converts all into lower case
            int vowels = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string r = input.Substring(i,1);

                if ((r == "a") || (r == "e") || (r == "i") || (r == "o") || (r == "u"))
                {
                    vowels++;
                }
            }

            Console.WriteLine("Number of vowels found = " + vowels);
        }
    }
}
