﻿using System;
// Write a program that finds the biggest of three numbers.
/*Examples:
    a 	b 	    c 	    biggest
    5 	2 	    2 	    5
    -2 	-2 	    1 	    1
    -2 	4 	    3 	    4
    0 	-2.5 	5   	5
-0.1 	-0.5 	-1.1 	-0.1
 */ 
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("A program that finds the biggest of three numbers.");
            Console.Write("Enter first number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third number c: ");
            double c = double.Parse(Console.ReadLine());
            
            if ((a>=b) && (b>=c))
            {
                Console.WriteLine(a);
            }
            else if((b>=a)&&(a<=c)&&(c<=b))
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }