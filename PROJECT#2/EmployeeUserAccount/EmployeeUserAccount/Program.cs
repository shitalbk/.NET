using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUserAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Default & Parameterized Objects
            // Default Object
            EmployeeUserAccount objAccount1 = EmployeeUserAccount.GetInstance();
            // Parameterized Object
            EmployeeUserAccount objAccount2 = EmployeeUserAccount.GetInstance("Joe","111","joe@comp1.com");

            //Testing Default Object Constructor
            Console.WriteLine("Default Constructor!!!");
            Console.WriteLine(objAccount1.UserAccountID);
            Console.WriteLine(objAccount1.Username);
            Console.WriteLine(objAccount1.Password);
            Console.WriteLine(objAccount1.Email);
            Console.WriteLine();

            //Testing Parameterized Object Constructor
            Console.WriteLine("Parameterized Constructor!!!");
            Console.WriteLine(objAccount2.UserAccountID);
            Console.WriteLine(objAccount2.Username);
            Console.WriteLine(objAccount2.Password);
            Console.WriteLine(objAccount2.Email);
            Console.WriteLine();

            //Testing SETTING INSTANCE Properties
            objAccount1.UserAccountID = "10223424";
            objAccount1.Username = "Jolie";
            objAccount1.Password = "Moly";
            objAccount1.Email = "molly@aol.com";

            // Testing GETTING INSTANCE Properties by DISPLAYING CONTENT of each PROPERTY
            Console.WriteLine("Displaying objAccount1 Data that was SET & GET via the properties:");
            Console.WriteLine("UserAccount ID Number = {0}", objAccount1.UserAccountID);
            Console.WriteLine("Username = {0}", objAccount1.Username);
            Console.WriteLine("Password = {0}", objAccount1.Password);
            Console.WriteLine("Email = {0}", objAccount1.Email);
            Console.WriteLine();

            // Testing STATIC METHODS
            // Testing STATIC method GetInstance()

            EmployeeUserAccount.GetInstance();
            EmployeeUserAccount.GetInstance("Test", "Pass", "Emai");
            Console.WriteLine();

            // Testing Authenticate(U,P) Method 
            Console.WriteLine("Calling objAccount2 Authenticate() with correct data = Joe & 111");
            Console.WriteLine(objAccount2.Authenticate("Joe","111"));

            Console.WriteLine("Calling objAccount2 Authenticate() with wrong data = Mary & 3454345");
            Console.WriteLine(objAccount2.Authenticate("Mary", "3454345"));

            // TESTING CLASS DESTRUCTOR METHOD

            Console.WriteLine("Testing DESTRUCTOR METHOD at the end of the program when objects objAccount1,objAccount2 are deleted");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
