using System;
/*    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.

Examples:
n 	x 	S
3 	2 	2.75000
4 	3 	2.07407
5 	-4 	0.75781  */

    class CalculateFactorial
    {
        static void Main()
        {
            Console.WriteLine("A program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.");
            Console.Write("Enter a value for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for x: ");
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double S = 1;

            for (int i = 1; i<=x; i++ )
            {
                factorial *= i;
                S = 1 + factorial / Math.Pow((double)x, (double)i);
            }
            Console.WriteLine("S = {0:F5}", S);
        }
    }