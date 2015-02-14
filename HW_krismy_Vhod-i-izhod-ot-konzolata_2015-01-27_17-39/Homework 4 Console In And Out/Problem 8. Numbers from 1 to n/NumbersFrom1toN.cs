using System;
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("A program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.\n\nEnter integer number n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }