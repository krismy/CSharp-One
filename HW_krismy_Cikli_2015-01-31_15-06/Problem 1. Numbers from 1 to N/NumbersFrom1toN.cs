using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

class NumbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("A program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.\n");
        Console.Write("Enter a positive integer number n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}