using System;

   //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
   // Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:
//program 	user
//Company name: 	Telerik Academy
//Company address: 	31 Al. Malinov, Sofia
//Phone number: 	+359 888 55 55 555
//Fax number: 	2
//Web site: 	http://telerikacademy.com/
//Manager first name: 	Nikolay
//Manager last name: 	Kostov
//Manager age: 	25
//Manager phone: 	+359 2 981 981

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Enter company info");
            Console.Write("Company name: ");
            string compName = Console.ReadLine();
            Console.Write("Company address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Website: ");
            string site = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();
            string na = "N/A";

            if(compName==string.Empty)
            {
                Console.WriteLine("Ivalid entry");
            }
            if (address == string.Empty)
            {
                address = na;
            }
            if (companyPhone == string.Empty)
            {
                companyPhone = na;
            }
            if (fax == string.Empty)
            {
                fax =na;
            }
            if (managerAge==string.Empty)
            {
                managerAge = na;
            }
            if (managerPhone == string.Empty)
            {
                managerPhone = na;
            }

            Console.WriteLine("\n{0}\nAddress: {1}\nPhone: {2}\nFax: {3}\nWeb Site: {4}\nManager: {5} {6} ({7}, {8})", compName, address,companyPhone, fax, site, managerFirstName, managerLastName, managerAge, managerPhone );
        }
    }