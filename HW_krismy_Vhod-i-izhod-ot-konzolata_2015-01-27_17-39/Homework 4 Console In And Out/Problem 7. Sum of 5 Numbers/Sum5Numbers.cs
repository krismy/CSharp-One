using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
    class Sum5Numbers
    {
        static void Main()
        {
            Console.WriteLine("A program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.");
            Console.Write("Enter five numbers on single line, separated by a space: ");

            string[] entered = Console.ReadLine().Split(' ');
            double sum = 0;
            if (0 < entered.Length && entered.Length < 5)
            {
                for (int i = 0; i < entered.Length; i++)
                {
                    sum += Convert.ToDouble(entered[i]);
                    Console.WriteLine("Sum of numbers = {0}", sum);
                }
            }
            else
            {
                Console.WriteLine("Incorrect entry!");
            }
        }
    }