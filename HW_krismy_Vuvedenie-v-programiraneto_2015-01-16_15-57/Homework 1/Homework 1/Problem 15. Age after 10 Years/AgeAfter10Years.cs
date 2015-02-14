using System;

    class AgeAfter10Years
    {
        static void Main()
        {
             Console.WriteLine("Type your date of birth (d m y):");
             var birthDay = DateTime.Parse(Console.ReadLine());
             int ageNow = DateTime.Today.Year - birthDay.Year;
            
                 if (birthDay > DateTime.Now)
                 {
                    Console.WriteLine("Incorrect date of birth!");
                 }
                 else
                    Console.WriteLine("You are {0} years old. \nYour age after 10 years will be {1}.", ageNow, ageNow + 10);
        }
    }
