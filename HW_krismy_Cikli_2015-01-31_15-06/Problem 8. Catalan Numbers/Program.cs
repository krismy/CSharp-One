using System;
using System.Numerics;

/* In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
   Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). */

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter a value for n (0 <= n <= 100): ");
            int n = int.Parse(Console.ReadLine());
            //Console.Write("Enter a value for k: ");
            //int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger nFact = 1;
            BigInteger nFactX2 = 1;
            BigInteger nFactPlus1 = 1;

            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }

            for (int j = 1; j <= (2 * n); j++ )
            {
                nFactX2 *= j;
            }
            for (int k = 1; k <= (n+1); k++)
            {
                nFactPlus1 *= k;
            }
            result = nFactX2 / (nFactPlus1 * nFact);

                Console.WriteLine(result);
        }
    }