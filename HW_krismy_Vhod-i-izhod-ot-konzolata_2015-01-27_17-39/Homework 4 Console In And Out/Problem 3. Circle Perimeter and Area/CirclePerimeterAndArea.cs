using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("A program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.\nEnter redius r: ");
            double r = double.Parse(Console.ReadLine());
            //double perimeter = (2 * r ) * Math.PI;
            //double area = Math.Pow(r, 2) * Math.PI;
           
            if(r>0)
            {
                Console.WriteLine("The circle perimeter is {0:F2}. And its srea is {1:F2}.", (2 * r) * Math.PI, Math.Pow(r, 2) * Math.PI);
            }
            else
            {
                Console.WriteLine("You have entered wrong values for r!");
            }
        }
    }