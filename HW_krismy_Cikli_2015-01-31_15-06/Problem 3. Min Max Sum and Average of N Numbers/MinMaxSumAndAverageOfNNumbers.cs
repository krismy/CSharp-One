using System;

/*  Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
    the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. */

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter a positive integer number n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        double average = 0;
        Console.WriteLine("Enter values for the n numbers: ");
        if (n >= 0)
        {

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                average = sum / 2;
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                          
            }

            Console.WriteLine("sum = {0}\nmin = {1}\nmax = {2}\naverage = {3:F2}", sum, min, max,average);
        }
        else
        {
            Console.WriteLine("not in range");
        }
    }
}