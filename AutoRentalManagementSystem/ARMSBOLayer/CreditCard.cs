using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   //For file access code library
using ARMSDALayer;

namespace ARMSBOLayer
{
   public class CreditCard
    {
        // PRIVATE INSTANCE AND STATIC DATA MEMBERS DECLARATION
        private string m_CardNumber;
        private string m_OwnerName;
        private string m_MerchantName;
        private DateTime m_ExpDate;
        private string m_HouseStreetAddress;
        private string m_City;
        private string m_StateCode;
        private string m_ZipCode;
        private string m_Country;
        private decimal m_CreditLimit;
        private bool m_ActivationStatus;

        // PUBLIC INSTANCE AND STATIC PROPERTIES DECLARATION
        public string CardNumber
        {
            get { return m_CardNumber; }
            set { m_CardNumber = value; }
        }
        public string OwnerName
        {
            get { return m_OwnerName; }
            set { m_OwnerName = value; }
        }
        public string MerchantName
        {
            get { return m_MerchantName; }
            set { m_MerchantName = value; }
        }
        public DateTime ExpDate
        {
            get { return m_ExpDate; }
            set { m_ExpDate = value; }
        }
        public string HouseStreetAddress
        {
            get { return m_HouseStreetAddress; }
            set { m_HouseStreetAddress = value; }
        }
     /*   public string AddressLine2
        {
            get { return m_AddressLine2; }
            set { m_AddressLine2 = value; }
        } */
        public string City
        {
            get { return m_City; }
            set { m_City = value; }
        }
        public string StateCode
        {
            get { return m_StateCode; }
            set { m_StateCode = value; }
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
        public decimal CreditLimit
        {
            get { return m_CreditLimit; }
            set { m_CreditLimit = value; }
        }
        public bool ActivationStatus
        {
            get { return m_ActivationStatus; }
        }

        /* Public CONSTRUCTORS Declarations (DEFAULT & PARAMETERIZED) */

        // Default Constructor Declaration
        public CreditCard()
        {
            m_CardNumber = "";
            m_OwnerName = "";
            m_MerchantName = "";
            m_ExpDate = new DateTime().Date;
            m_HouseStreetAddress = "";
           // m_AddressLine2 = "";
            m_City = "";
            m_StateCode = "";
            m_ZipCode = "";
            m_Country = "";
            m_CreditLimit = 0.0M;
            m_ActivationStatus = true;
        }

        // Parameterized Constructor Declaration

        public CreditCard(string card_number,string card_ownername,string merchant_name,DateTime exp_date,string house_streetaddress
            , string city,string state,string zip_code,string country, decimal credit_limit)
        {
            this.CardNumber = card_number;
            this.OwnerName = card_ownername;
            this.m_MerchantName = merchant_name;
            this.ExpDate = exp_date;
            this.HouseStreetAddress = house_streetaddress;
         //   this.AddressLine2 = address_line2;
            this.City = city;
            this.StateCode = state;
            this.ZipCode = zip_code;
            this.Country = country;
            this.CreditLimit = credit_limit;
            m_ActivationStatus = true;

        }

        // Public DESTRUCTOR Declaration
        ~CreditCard()
        {
            // Creating destructor
        }

        // PUBLIC INSTANCE METHOD DECLARATIONS

        // PUBLIC PRINT METHOD
        public void Print()
        {
            //Step 1-Create object to open/create file for appending
            StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);

            //Step 2-Write person's data to printer file
            objPrinterFile.WriteLine("The Credit Card Information: ");
            objPrinterFile.WriteLine("Credit Card Number = {0}", m_CardNumber);
            objPrinterFile.WriteLine("Credit Card Name = {0}", m_OwnerName);
            objPrinterFile.WriteLine("Merchant Company Name = {0}", m_MerchantName);
            objPrinterFile.WriteLine("Expiration Date = {0}", m_ExpDate);
            objPrinterFile.WriteLine("Billing Address Line 1 = {0}", m_HouseStreetAddress);
           // objPrinterFile.WriteLine("Billing Address Line 2 = {0}", m_AddressLine2);
            objPrinterFile.WriteLine("Billing City = {0}", m_City);
            objPrinterFile.WriteLine("Billing StateCode = {0}", m_StateCode);
            objPrinterFile.WriteLine("Billing Zipcode = {0}", m_ZipCode);
            objPrinterFile.WriteLine("Billing Country = {0}", m_Country);
            objPrinterFile.WriteLine("Credit Limit = {0}", m_CreditLimit);
            objPrinterFile.WriteLine("Activation Status = {0}", m_ActivationStatus);

            objPrinterFile.WriteLine();
            objPrinterFile.WriteLine();

            //Step 3-Close file
            objPrinterFile.Close();

        }

        // Method that activates the credit card
        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }

        // Method that deactivates the credit card
        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }


        // PUBLIC DATA ACCESS METHOD DECLARATIONS

        // PUBLIC LOAD(KEY) METHOD
        public bool Load(string key)
        {
            return DALayer_Load(key);
        }

        // PUBLIC INSERT METHOD
        public bool Insert()
        {
            return DALayer_Insert();
        }

        // PUBLIC InsertCreditCardOfACustomer (custKey) Method

        public bool InsertCreditCardOfACustomer(string custKey)
        {
            return DALayer_InsertCreditCardOfACustomer(custKey);
        }

        // PUBLIC UPDATE METHOD
        public bool Update()
        {
            return DALayer_Update();
        }

        // PUBLIC DELETE METHOD
        public bool Delete(string key)
        {
            return DALayer_Delete(key);    
        }

        // Protected DALayer_Load(key) Data Access Method

        protected bool DALayer_Load(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();
                //Step 3-call the CreditCardDAO Data Access Object to do the work
                CreditCardDTO objCreditCardDTO = objCreditCardDAO.GetRecordByID(key);
                //Step 4- test if DTO object exists & populate this object with DTO object's properties
                //and return a true or return a False if no DTO object exists.
                if (objCreditCardDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object
                    this.CardNumber = objCreditCardDTO.CardNumber;
                    this.OwnerName = objCreditCardDTO.OwnerName;
                    this.MerchantName = objCreditCardDTO.MerchantName;
                    this.ExpDate = objCreditCardDTO.ExpDate;
                    this.HouseStreetAddress = objCreditCardDTO.HouseStreetAddress;
                 //   this.AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.City = objCreditCardDTO.City;
                    this.StateCode = objCreditCardDTO.StateCode;
                    this.ZipCode = objCreditCardDTO.ZipCode;
                    this.Country = objCreditCardDTO.Country;
                    this.CreditLimit = objCreditCardDTO.CreditLimit;
                  //  this.ActivationStatus = objCreditCardDTO.ActivationStatus;
                    //Handle activation status accordingly using methods
                    //since ActivationStutus property is read only
                    if (objCreditCardDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    //Step 4c-Returns a true since this class object has been populated.
                    return true;
                }
                else
                {
                    //Step 5- No object returned from DALayer, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of method

        // Protected DALayer_Insert() Data Access Method
        protected bool DALayer_Insert()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();
                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();
                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CardNumber = this.CardNumber;
                objCreditCardDTO.OwnerName = this.OwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.HouseStreetAddress = this.HouseStreetAddress;
              //  objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditLimit = this.CreditLimit;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;

                //Step 5-call the CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.Insert(objCreditCardDTO);
                //Step 6- test if insert to database was successful return true,
                //otherwise return false
                if (inserted == true)
                {
                    //Step 6b-Returns a true since this class object has been inserted & marked as old.
                    return true;
                }
                else
                {
                    //Step 7- No record inserted, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }
        }//End of method

        // Protected DALayer_InsertCreditCardOfACustomer(customerKey) Data Access Method
        protected bool DALayer_InsertCreditCardOfACustomer(string parentKey)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();
                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();
                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CardNumber = this.CardNumber;
                objCreditCardDTO.OwnerName = this.OwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.HouseStreetAddress = this.HouseStreetAddress;
              //  objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditLimit = this.CreditLimit;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;
                //Step 5-call the CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.InsertChildObjectOfAParent(parentKey, objCreditCardDTO);
                //Step 6- test if insert to database was successful & MARK the object as old return true,
                //otherwise return false
                if (inserted == true)
                {
                    //Step 6b-Returns a true since this class object has been inserted.
                    return true;
                }
                else
                {
                    //Step 7- No record inserted, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_InsertCreditCardOfACustomer () Method: {0}" + objE.Message);
            }
        }//End of method

        // Protected DALayer_Update() Data Access Method
        protected bool DALayer_Update()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();
                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();
                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CardNumber = this.CardNumber;
                objCreditCardDTO.OwnerName = this.OwnerName;
                objCreditCardDTO.MerchantName = this.MerchantName;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.HouseStreetAddress = this.HouseStreetAddress;
              //  objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.StateCode = this.StateCode;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
              //  objCreditCardDTO.CreditLimit = this.CreditLimit;
             //  objCreditCardDTO.ActivationStatus = this.ActivationStatus;
                //Step 5-call the CreditCardDAO Data Access Object to do the work
                bool updated = objCreditCardDAO.Update(objCreditCardDTO);
                //Step 6- test if update to database was successful & MARK the object as old return true,
                //otherwise return false
                if (updated == true)
                {
                    //Step 6b-Returns a true since this class object has been updated.
                    return true;
                }
                else
                {
                    //Step 7- No record updated, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }//End of method

        // Protected DALayer_Delete(key) Data Access Method
        protected bool DALayer_Delete(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                DALObjectFactoryBase objSQLDAOFactory = DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objSQLDAOFactory.GetCreditCardDAO();
                //Step 3-call the CreditCardDAO Data Access Object to do the work
                bool deleted = objCreditCardDAO.Delete(key);
                //Step 4- Test if delete to database was successful & MARK the object as NEW since
                //deleted from database and NEW in memory and return a true, otherwise return false
                if (deleted == true)
                {
                    //Step 4a-THE CURRENT DATA IN THE OBJECT NO LONGER EXISTS IN DATABASE SINCE IT WAS JUST
                    //DELETED MUST BE MARKED AS NEW IN MEMORY THUS READY TO BE INSERTED BACK IF NECESSARY
                 //   base.MarkNew();
                    //Step 4b-Returns a true since this class object has been deleted & marked as NEW.
                    return true;
                }
                else
                {
                    //Step 5-No record deleted, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception.
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }//End of method



    } //End of Class
}  //End of Namespace
