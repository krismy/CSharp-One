using System;

class PrintLongSequence
{
    static void Main()
    {
        int i;

        for (i = 2; i < 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
                Console.Write(i * (-1) + ", ");
        }
        Console.WriteLine("\n");
    }
} 
