using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 - Create variables
            string username;
            string password;

            // Step 2 - Prompt user to enter username
            Console.WriteLine("Please enter username: ");

            // Step 3 - Get user input & assign to username variable
            username = Console.ReadLine();

            // Step 4 - Prompt user to enter password
            Console.WriteLine("Please enter a password: ");

            // Step 5 - Get user input & assign to password variable
            password = Console.ReadLine();

            // Step 6 - display results
            Console.WriteLine("The username you entered is {0}", username);
            Console.WriteLine("The password you entered is {0}", password);
            Console.ReadLine();
            
        }
    }
}
