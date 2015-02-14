﻿using System;
/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops*/
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a positive integer number n (1 <= n <= 20): ");
        int n = int.Parse(Console.ReadLine());
        int col = n;
        int row = n;

        if (n < 1||n>20)
        {
            Console.WriteLine("Invelid entry!");
        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < i + n; j++)
            {
                Console.Write("{0,-3}", j);
            }
            Console.WriteLine();
        }
    }
}