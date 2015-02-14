using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter numers count: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter min value: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = int.Parse(Console.ReadLine());
            Random generator = new Random();

            if (min < max)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(generator.Next(min, max + 1) + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }