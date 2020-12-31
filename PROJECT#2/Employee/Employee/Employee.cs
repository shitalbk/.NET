using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    
    public class Employee
    {
        // Private INSTANCE Data declarations:
        private int m_EmployeeID;
        private string m_FirstName;
        private string m_LastName;
        private string m_SSNumber;
        private string m_BirthDate;
        private int m_Age;
        private string m_HouseStreetAddress;
        private string m_City;
        private string m_State;
        private string m_ZipCode;
        private string m_Country;
        private string m_Phone;
        private string m_JobTitle;
        private string m_Email;

        // Private STATIC Data declaration:
        private static int m_Count = 0;

        /* Public INSTANCE & STATIC PROPERTIES Declarations */

        // Public INSTANCE Properties Declarations
        public int EmployeeID
        {
            get { return m_EmployeeID; }
            set { m_EmployeeID = value; }
        }
        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }
        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }
        public string SSNumber
        {
            get { return m_SSNumber; }
            set { m_SSNumber = value; }
        }
        public string BirthDate
        {
            get { return m_BirthDate; }
            set { m_BirthDate = value; }
        }
        public int Age
        {
            get { return m_Age; }
        }
        public string HouseStreetAddress
        {
            get { return m_HouseStreetAddress; }
            set { m_HouseStreetAddress = value; }
        }
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        public string State
        {
            get { return m_State; }
            set { m_State = value; }
        }
        public string ZipCode
        {
            get { return m_ZipCode; }
            set { m_ZipCode = value; }
        }
        public string Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }
        public string Phone
        {
            get { return m_Phone; }
            set { m_Phone = value; }
        }
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
        public string JobTitle
        {
            get { return m_JobTitle; }
            set { m_JobTitle = value; }
        }

        // Public STATIC Properties Declarations
        public static int Count
        {
            get { return m_Count; }
            set { m_Count = value; }
        }


        /* Public CONSTRUCTORS Declarations (DEFAULT & PARAMETERIZED) */

        // Default Constructor Declaration
        public Employee()
        {
            m_EmployeeID = 0;
            m_FirstName = "";
            m_LastName = "";
            m_SSNumber = "";
            m_BirthDate = "00/00/0000";
            m_Age = 0;
            m_HouseStreetAddress = "";
            m_City = "";
            m_State = "";
            m_ZipCode = "";
            m_Country = "";
            m_Phone = "";
            m_JobTitle = "";
            m_Email = "";
            m_Count = m_Count++;    // Incrementing m_Count by 1
        }

        // Parameterized Constructor Declaration
        public Employee(int employee_id, string fName, string lName, string ssNumber, string birthDate, string houseAddress, string city,
            string state, string zipCode, string country, string phone, string jobTitle, string email)
        {
            this.EmployeeID = employee_id;
            this.FirstName = fName;
            this.LastName = lName;
            this.SSNumber = ssNumber;
            this.BirthDate = birthDate;
            this.HouseStreetAddress = houseAddress;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Country = country;
            this.Phone = phone;
            this.JobTitle = jobTitle;
            this.Email = email;
        }

        // Public DESTRUCTOR Declaration
        ~Employee()
        {
            // Creating destructor
        }

        /* Public INSTANCE METHODS Declarations  */

        //  Public Print Method()
        public void Print()
        {
            Console.WriteLine("Employee Information: ");
            Console.WriteLine("Employee ID = {0}", m_EmployeeID);
            Console.WriteLine("First Name = {0}", m_FirstName);
            Console.WriteLine("Last Name = {0}", m_LastName);
            Console.WriteLine("Social Security = {0}", m_SSNumber);
            Console.WriteLine("Birth Date = {0}", m_BirthDate);
            Console.WriteLine("Age = {0}", m_Age);
            Console.WriteLine("House Street Address = {0}", m_HouseStreetAddress);
            Console.WriteLine("City = {0}", m_City);
            Console.WriteLine("State = {0}", m_State);
            Console.WriteLine("Zip Code = {0}", m_ZipCode);
            Console.WriteLine("Country = {0}", m_Country);
            Console.WriteLine("Phone = {0}", m_Phone);
            Console.WriteLine("Job Title = {0}", m_JobTitle);
            Console.WriteLine("Email = {0}", m_Email);
        }

        // Helper Methods

        // Method to calculate age
        private static int CalculateAge(string strBirthDate)
        {
            //varible created to store the age
            int age;
            //Convert the birthdate string strBirthDate to DateTime object
            DateTime objBirthDate = Convert.ToDateTime(strBirthDate);
            //CALCULATE age, using .NET DateTime Structure to SUBTRACT the
            //current date year portion from Birthdate object Year portion
            age = DateTime.Now.Year - objBirthDate.Year;
            //Compare if today day of the year as a number is less than
            //the birthday day of the year as a number
            //If TRUE, subtract 1 day from the age, otherwise do nothing since
            //you already have the correct age
            //this calculation takes Leap Years into account within the DayOfYear property.
            if (DateTime.Now.DayOfYear < objBirthDate.DayOfYear)
                age = age - 1;

            return age;
        }
           


    }
}







