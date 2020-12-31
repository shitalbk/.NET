using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerUserAccount
{
    class CustomerUserAccount
    {
        // Private INSTANCE Data declarations

        private string m_UserAccountID;
        private string m_Username;
        private string m_Password;
        private string m_Email;
        
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
        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }

        // Public CONTRUCTOR Declarations

        // Default CONSTRUCTOR Declarations
        private CustomerUserAccount()
        {
            m_UserAccountID = "209304";
            m_Username = "Goerge";
            m_Password = "PingPong";
            m_Email = "ping123@gmail.com";
        }

        // Parameterized CONSTRUCTOR Declarations
        private CustomerUserAccount(string username, string password, string email)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            m_UserAccountID = "";
        }

        /* Public DESTRUCTOR Method Declaration */
        ~ CustomerUserAccount()
        {
            // Created Destructor method
        }

        //  Public STATIC GetInstance() Method
        public static CustomerUserAccount GetInstance()
        {
            CustomerUserAccount objAccount1 = new CustomerUserAccount();
            return objAccount1;
        }

        //  Public STATIC(Overloaded) GetInstance(U, P, E) Method

        public static CustomerUserAccount GetInstance(string U, string P, string E)
        {
            CustomerUserAccount objAccount2 = new CustomerUserAccount(U, P, E);
            return objAccount2;
        }

        //  Public Authenticate(U,P) Method 
        public bool Authenticate(string U, string P)
        {
            if (m_Username == U && m_Password == P)
                return true;
            else
                return false;
        }
    }
}
