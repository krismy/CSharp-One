using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Petya";
            string lastname = "Ivanova";
            byte age = 22;
            char gender = 'f';
            ulong personalID = 8306112507;
            int emploeeNumber = 27560001;

            Console.WriteLine("Employee info:\n{0} {1} \nAges: {2} \nGender: {3} \nPersonal ID: {4} \nEmploee Number: {5}", firstName, lastname,age,gender,personalID,emploeeNumber);
        }
    }