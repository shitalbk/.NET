using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Default & Parameterized Objects
            Employee obj1 = new Employee();
            Employee obj2 = new Employee(110, "Shital", "BK", "822129876", "09/08/1987", "54 Flatbust Avenue", "Brooklyn",
            "NY", "98712", "Unites States", "9092341234", "Painter", "shitalbk@gmail.com");

            // Testing Default Object Constructor
            Console.WriteLine("Testing Constructor and Print() method");
            Console.WriteLine("Default Constructor");
            Console.WriteLine();
            obj1.Print();
            Console.WriteLine();
            Console.WriteLine("Parameterized Constructor");
            //Testing Parameterized Object Constructor
            obj2.Print();
            Console.WriteLine();
            /* Testing each INSTANCE PROPERTY by SETTING & GETTING appropriate values:  */

            // Testing SETTING INSTANCE Properties
            obj1.EmployeeID = 101;
            obj1.FirstName = "Harry";
            obj1.LastName = "Goose";
            obj1.SSNumber = "232323232";
            obj1.BirthDate = "09/03/1998";
            obj1.HouseStreetAddress = "34 Panama Street";
            obj1.City = "Queens";
            obj1.State = "NY";
            obj1.ZipCode = "11234";
            obj1.Country = "United States";
            obj1.Phone = "9332343322";
            obj1.Email = "harrygoose@aol.com";
            obj1.JobTitle = "Painter";
            Console.WriteLine();

            // Testing GETTING STATIC Properties by DISPLAYING CONTENT of each PROPERTY
            Console.WriteLine("Displaying obj1 Data that was SET & GET via the properties:");
            Console.WriteLine("EmployeeID = {0}",obj1.EmployeeID);
            Console.WriteLine("FirstName = {0}", obj1.FirstName);
            Console.WriteLine("LastName = {0}", obj1.LastName);
            Console.WriteLine("Social Security Number = {0}", obj1.SSNumber);
            Console.WriteLine("Date Of Birth = {0}", obj1.BirthDate);
            Console.WriteLine("HouseStreetAddress = {0}", obj1.HouseStreetAddress);
            Console.WriteLine("City = {0}", obj1.City);
            Console.WriteLine("State = {0}", obj1.State);
            Console.WriteLine("ZipCode = {0}", obj1.ZipCode);
            Console.WriteLine("Country = {0}", obj1.Country);
            Console.WriteLine("Phone = {0}", obj1.Phone);
            Console.WriteLine("Email = {0}", obj1.Email);
            Console.WriteLine("JobTitle = {0}", obj1.JobTitle);
            Console.WriteLine();

            // Testing STATIC Properties
            // TESTING the STATIC Properties by setting & getting STATIC Data
            //STEP1-SETTING STATIC Count Property to 1
            Employee.Count = 1;
            //STEP2-GETTING STATIC Count PropertY
            Console.WriteLine("Displaying Employee Class Count value SET to 1 = {0}", Employee.Count);
            Console.WriteLine();

            // Testing any of the variations of INSTANCE Methods by CALLING them and verifying the actions they are
            //programmed to take
            obj1.Print();
            
            Console.ReadLine();
            






        }
    }
}
