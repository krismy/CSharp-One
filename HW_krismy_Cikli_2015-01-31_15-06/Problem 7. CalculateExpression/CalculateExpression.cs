using System;

/*
    In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 (also known as the number of combinations) is calculated by the following formula: formula For example, 
 there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

    class CalculateExpression
    {
        static void Main()
        {
            Console.WriteLine("A program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).\n");
            Console.Write("Enter a value for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for k: ");
            int k = int.Parse(Console.ReadLine());
            int diff = n - k;
            int diffFakt = 1;
            double result = 1;

            if (k > 1 && k < n && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;
                }
                for (int j=1; j<=n-k; j++)
                {
                    diffFakt *= j;
                }
                //Console.WriteLine(diff);
                //Console.WriteLine(diffFakt);
                Console.WriteLine(result / diffFakt);
            }
            else
            {
                Console.WriteLine("Number(s) out of range!");
            }
        }
    }