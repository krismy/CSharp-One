using System;
using System.Linq;
/*  You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc. */

    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by space: ");
            int[] line = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
            long oddProduct = 1;
            long evenProduct = 1;

            for (int i = 0; i < line.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= line[i];
                }
                else
                {
                    evenProduct *= line[i];
                }
            }
            if (oddProduct == evenProduct) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }