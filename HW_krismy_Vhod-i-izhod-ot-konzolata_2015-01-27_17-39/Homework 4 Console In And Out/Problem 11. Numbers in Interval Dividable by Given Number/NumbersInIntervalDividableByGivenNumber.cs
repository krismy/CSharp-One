using System;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("A program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.");
        Console.Write("Enter first positive number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second positive number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        for (int i = Math.Min(firstNumber, secondNumber); i <= Math.Max(firstNumber, secondNumber); i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}