﻿using System;
/*Write a program that applies bonus score to given score in the range [1…9] by the following rules:

    If the score is between 1 and 3, the program multiplies it by 10.
    If the score is between 4 and 6, the program multiplies it by 100.
    If the score is between 7 and 9, the program multiplies it by 1000.
    If the score is 0 or more than 9, the program prints “invalid score”.
*/

    class BonusScore
    {
        static void Main()
        {
            Console.Write("Enter score in the range [1…9]: ");
            int score = int.Parse(Console.ReadLine());
            bool firstRange = (1<=score)&&(score<=3);
            bool secondRange = (4<=score)&&(score<=6);
            bool thirdRange = (7<=score)&&(score<=9);
            int result = 1;

            if (firstRange)
            {
                result = score * 10;
                Console.WriteLine("The result is {0}.", result);
            }
            else if (secondRange)
            {
                result = score * 100;
                Console.WriteLine("The result is {0}.", result);
            }
            else if (thirdRange)
            {
                result = score * 1000;
                Console.WriteLine("The result is {0}.", result);
            }
            else 
            {
                Console.WriteLine("Invalid score!");
            }
        }
    }