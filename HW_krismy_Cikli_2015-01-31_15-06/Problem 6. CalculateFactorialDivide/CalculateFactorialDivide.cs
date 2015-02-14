using System;
//    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
   // Use only one loop.

    class CalculateFactorialDivide
    {
        static void Main()
        {
            Console.WriteLine("A program that calculates n! / k! for given n and k (1 < k < n < 100).\n");
            Console.Write("Enter a value for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value for k: ");
            int k = int.Parse(Console.ReadLine());
            int diff = n-k;
            double result = 1;

            if(k>1 && k<n && n<100)
            {
                for (int i= k+1; i <= n; i++) 
                {
                    result *= i;
                }
            }
            else
            {
                Console.WriteLine("Number(s) out of range!");
            }
            Console.WriteLine(result);
        }
    }