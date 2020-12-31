using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeUserAccount
{
   public class EmployeeUserAccount
    {
        // Private INSTANCE Data declarations
        private string m_UserAccountID;
        private string m_Username;
        private string m_Password;
        private string m_Email;

        /* Public INSTANCE & STATIC PROPERTIES Declarations */

        // Public INSTANCE Properties Declarations
        public string UserAccountID
        {
            get { return m_UserAccountID; }
            set { m_UserAccountID = value; }
        }
        public string Username
        {
            get { return m_Username; }
            set { m_Username = value; }
        }
        public string  Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        /* Public CONSTRUCTORS Declarations (DEFAULT & PARAMETERIZED) */

        // Default Constructor Declaration
        private EmployeeUserAccount()
        {
            m_Username = "Borey";
            m_Password = "HashCode";
            m_Email = "hash@aol.com";
            m_UserAccountID = Guid.NewGuid().ToString();
            Console.WriteLine("Hello");
        }

        // Parameterized Constructor Declaration
        private EmployeeUserAccount(string username, string password, string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            m_UserAccountID = Guid.NewGuid().ToString();   // GUID Object, Created, Converted to STRING and assigned in ONE STEP!
            Console.WriteLine("Testing");
        }

        // Public DESTRUCTOR Declaration
        ~ EmployeeUserAccount()
        {
            // Created empty destructor
        }

        // Public STATIC GetInstance() Method to create DEFAULT OBJECT
        public static EmployeeUserAccount GetInstance()
        {
            EmployeeUserAccount objAccount1 = new EmployeeUserAccount();
            return objAccount1;
            
        }

       //  Public STATIC (Overloaded) GetInstance(U, P, E) Method to create Parameterized Object

        public static EmployeeUserAccount GetInstance(string U,string P,string E)
        {
            EmployeeUserAccount objAccount2 = new EmployeeUserAccount(U,P,E);
            return objAccount2;
        }

        //  Public Authenticate(U,P) Method 

        public bool Authenticate(string U, string P)
        {
            if (U == this.m_Username && P == this.m_Password)
                return true;
            else
                return false;
        }




    }
}
