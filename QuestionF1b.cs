using System;
using System.Threading;

namespace Day3Workshop
{
    class F1b
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep

            Console.WriteLine("Write down a sentence or phrase: ");
            string input = Console.ReadLine().ToLower();                //takes input and converts all into lower case
            int vowels = 0;
            int A = 0, E = 0, I = 0, O = 0, U = 0; 

            for (int i = 0; i < input.Length; i++)
            {
                string r = input.Substring(i,1);

                if ((r == "a") || (r == "e") || (r == "i") || (r == "o") || (r == "u"))
                {
                    vowels++;

                    switch (r)
                    {
                        case "a":
                            A++;
                            break;

                        case "e":
                            E++;
                            break;

                        case "i":
                            I++;
                            break;

                        case "o":
                            O++;
                            break;

                        case "u":
                            U++;
                            break;

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("Number of vowels found = " + vowels);
            Console.WriteLine("A = {0} times", A);
            Console.WriteLine("E = {0} times", E);
            Console.WriteLine("I = {0} times", I);
            Console.WriteLine("O = {0} times", O);
            Console.WriteLine("U = {0} times", U);
        }
    }
}
