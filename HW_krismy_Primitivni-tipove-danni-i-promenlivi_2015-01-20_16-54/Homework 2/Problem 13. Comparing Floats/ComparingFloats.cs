using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Enter first digit:");
            double firstDigit = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second digit:");
            double secondDigit = double.Parse(Console.ReadLine());
            double difference = Math.Abs(firstDigit-secondDigit);
            double eps = 0.000001;

            if(difference<=eps)
            {
                Console.WriteLine("The numbers are equal or almost equal!");            
            }

            if (difference > eps)
            {
                Console.WriteLine("The numbers are not equal!");
            }         
        }
    }
