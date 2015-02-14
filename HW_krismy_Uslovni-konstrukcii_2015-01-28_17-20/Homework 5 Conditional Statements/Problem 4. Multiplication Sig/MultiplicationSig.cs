using System;
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.


    class MultiplicationSig
    {
        static void Main()
        {
            Console.WriteLine("A program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.");
            Console.Write("Enter first number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number c: ");
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;
            bool isProductPositive = product>0;

            if(isProductPositive)
            {
                Console.WriteLine("+");
            }
            else
            {
                if (product==0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
        }
    }