﻿using System;
using System.Threading;

namespace Day3Workshop
{
    class F2
    {
        static void Main(string[] args)
        {
            //int timing1 = 1000;         //for thread.sleep

            Console.WriteLine("Write down a word or sentence: ");
            string Str = Console.ReadLine();                //takes input and converts all into lower case
            string input = Str.ToLower();
            bool palindrome = false;

            string r, t;

            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < (input.Length/2); i++)
                {
                    r = input.Substring(i, 1);

                    for (int j = (input.Length - 1); j >= (input.Length / 2); j--)
                    {
                        t = input.Substring(j, 1);

                        if (r == t)
                        {
                            palindrome = true;
                        }

                        else
                        {
                            palindrome = false;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < (input.Length / 2); i++)
                {
                    r = input.Substring(i, 1);

                    for (int j = (input.Length - 1); j > (input.Length / 2); j--)
                    {
                        t = input.Substring(j, 1);

                        if (r == t)
                        {
                            palindrome = true;
                        }

                        else
                        {
                            palindrome = false;
                        }
                    }
                }
            }

            if (palindrome == true)
            {
                Console.WriteLine("\"{0}\" is a palindrome!", Str);   
            }

            else
            {
                Console.WriteLine("\"{0}\" isn't a palindrome...", Str);
            }
        }
    }
}
