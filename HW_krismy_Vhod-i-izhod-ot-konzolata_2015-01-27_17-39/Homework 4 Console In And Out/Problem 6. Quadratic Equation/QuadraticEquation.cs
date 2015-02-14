using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("A Program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots)\n\nEnter a value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for c: ");
            double c = double.Parse(Console.ReadLine());
            double D = (Math.Pow(b, 2) - (4 * a * c));
            double x1 = ((-b)+ Math.Sqrt(D)) / (2 * a);
            double x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
 
            if(D>0)
            {
                Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                Console.WriteLine("There is one root: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }