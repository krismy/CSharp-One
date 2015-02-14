using System;
// Write a program that finds the biggest of five numbers by using only five if statements.

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("A program that finds the biggest of five numbers. ");
            Console.Write("Enter number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter number d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter number e: ");
            double e = double.Parse(Console.ReadLine());
            bool isAbiggest = ((a >= b) && (a>= c) && (a >= d) && (a >= e));
            bool isBbiggest = ((b >= a) && (b >= c) && (b >= d) && (b >= e));
            bool isCbiggest = ((c >= a) && (c >= b) && (c >= d) && (c >= e));
            bool isDbiggest = ((d >= a) && (d >= b) && (d >= c) && (d >= e));

            if (isAbiggest)
            {
                Console.WriteLine("The biggest is: {0}", a);
            }
            else if (isBbiggest)
            {
                Console.WriteLine("The biggest is: {0}", b);
            }
            else if (isCbiggest)
            {
                Console.WriteLine("The biggest is: {0}", c);
            }
            else if (isDbiggest)
            {
                Console.WriteLine("The biggest is: {0}", d);
            }
            else
            {
                Console.WriteLine("The biggest is: {0}", e);
            }
        }
    }