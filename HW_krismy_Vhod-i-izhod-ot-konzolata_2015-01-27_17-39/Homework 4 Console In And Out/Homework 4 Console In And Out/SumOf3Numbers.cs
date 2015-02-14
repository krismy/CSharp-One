using System;
//Write a program that reads 3 real numbers from the console and prints their sum.
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Enter first number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Their sum is: {0}", a + b + c);
        }
    }