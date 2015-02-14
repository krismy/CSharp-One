using System;
//Write an if-statement that takes two double variables a and b and exchanges 
//their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("A program that exchanges two double variables values if the first one is bigger.");
            Console.Write("Enter first number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number b: ");
            double b = double.Parse(Console.ReadLine());
            double c = a+b;
            bool check = a>b;

            if(check)
            {
                a = c - a;
                b = c - b;
            }
           
            Console.WriteLine(a + " " + b);
        }
    }