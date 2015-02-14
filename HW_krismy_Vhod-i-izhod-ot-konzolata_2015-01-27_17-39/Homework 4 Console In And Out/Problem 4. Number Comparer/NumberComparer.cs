using System;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("A program that gets two numbers from the console and prints the greater of them.\n\nEnter first number value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number value: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("The greater number is " + Math.Max(a, b));
        }
    }