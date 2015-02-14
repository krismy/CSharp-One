using System;
    //Write a program that reads 3 numbers:
    //    integer a (0 <= a <= 500)
    //    floating-point b
    //    floating-point c
    //The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    //    The number a should be printed in hexadecimal, left aligned
    //    Then the number a should be printed in binary form, padded with zeroes
    //    The number b should be printed with 2 digits after the decimal point, right aligned
    //    The number c should be printed with 3 digits after the decimal point, left aligned.

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter first number integer a (0 <= a <= 500): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point c: ");
            double c = double.Parse(Console.ReadLine());

            if ((0 <= a) && (a <= 500))
            {
                string aHex = Convert.ToString(a, 16);
                string aBin = Convert.ToString(a, 2).PadLeft(10, '0');
                Console.WriteLine("{0,-10}|{1,-10}|{2,10:f2}|{3,-10:F3}", aHex, aBin, b, c);
            }
            else
            {
                Console.WriteLine("You have entered a number out of range!");
            }
        }
    }