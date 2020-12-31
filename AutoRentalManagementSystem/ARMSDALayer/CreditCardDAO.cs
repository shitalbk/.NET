using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET Data Access Classes
using System.Data;
//SQL Client Provider
using System.Data.SqlClient;



namespace ARMSDALayer
{
   public  class CreditCardDAO : ICreditCardDAO
    {

        // CreditCardDAO Class GetRecordByID(string Key) Data Access Method
        public CreditCardDTO GetRecordByID(string key)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "SELECT * FROM CreditCard WHERE CardNumber = @CardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = key;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();
                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Create Data Transfer Object
                    CreditCardDTO objDTO = new CreditCardDTO();
                    //Step 8a-Call Read() Method to point and read the first record
                    objDR.Read();
                    //Step 8b-Extract data from a row s Object Populates itself.
                    //IMPORTANT! Note that data must be extracted in the ORDER
                    //in which the QUERY RETURNS THE DATA.
                    objDTO.CardNumber = Convert.ToString(objDR.GetInt32(0));
                    objDTO.OwnerName = objDR.GetString(1);
                    objDTO.MerchantName = objDR.GetString(2);
                    objDTO.ExpDate = objDR.GetDateTime(3);
                    objDTO.HouseStreetAddress = objDR.GetString(4);
                    objDTO.City = objDR.GetString(5);
                    objDTO.StateCode = objDR.GetString(6);
                    objDTO.ZipCode = objDR.GetString(7);
                    objDTO.Country = objDR.GetString(8);
                    objDTO.CreditLimit = objDR.GetDecimal(9);
                    objDTO.ActivationStatus = Convert.ToBoolean(objDR.GetString(10));
                    //Step 8b- Return Data Transfer Object
                    return objDTO;
                }
                //Step 9 - Terminate ADO Objects
                objDR.Close();
                objDR = null;
                objCmd.Dispose();
                objCmd = null;
                //Step10- return null since no data found
                return null;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetRecordByID(key) Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetRecordByID


        // CreditCardDAO Class Insert(CreditCardDTO objDTO) Data Access Method

        public bool Insert(CreditCardDTO objDTO)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL;
                strSQL = "INSERT INTO CreditCard (CardNumber,OwnerName,MerchantName,ExpDate,";
                strSQL = strSQL + "HouseStreetAddress,City,StateCode,ZipCode,Country,";
                strSQL = strSQL + "CreditLimit,ActivationStatus)";
                strSQL = strSQL + "VALUES(@CardNumber,@OwnerName,@MerchantName,@ExpDate,";
                strSQL = strSQL + "@HouseStreetAddress,@City,@StateCode,@ZipCode,@Country,";
                strSQL = strSQL + "@CreditLimit,@ActivationStatus);";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the INSERT QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = objDTO.CardNumber;
                objCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = objDTO.OwnerName;
                objCmd.Parameters.Add("@MerchantName", SqlDbType.VarChar).Value = objDTO.MerchantName;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@HouseStreetAddress", SqlDbType.VarChar).Value = objDTO.HouseStreetAddress;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = objDTO.CreditLimit;

                string Status;


                if (objDTO.ActivationStatus == true)
                    Status = "True";
                else
                    Status = "False";



                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.VarChar).Value = Status;

                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }
                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Insert(CreditCardDTO objDTO) Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Insert


        // Public CreditCardDAO Class InsertChildObjectOfAParent (int parentKey, CreditCardDTOobjDTO) Data Access Method requirements

        public bool InsertChildObjectOfAParent(string parentKey, CreditCardDTO objDTO)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL;
                //Step 4-This is a multi-query where two INSERT statements are executed one after the other
                //The first inserts into the CreditCard table, the second adds a row to the
                //Person_CreditCard Table to complete the association betweeen the Person and the
                //Credit Card they own. Note spaces within the string for formatting the query
                strSQL = "INSERT INTO CreditCard (CardNumber,OwnerName,MerchantName,ExpDate,";
                strSQL = strSQL + "HouseStreetAddress,City,StateCode,ZipCode,Country,";
                strSQL = strSQL + "CreditLimit,ActivationStatus)";
                strSQL = strSQL + "VALUES(@CardNumber,@OwnerName,@MerchantName,@ExpDate,";
                strSQL = strSQL + "HouseStreetAddress,@City,@StateCode,@ZipCode,@Country,";
                strSQL = strSQL + "@CreditLimit,@ActivationStatus);";
                strSQL = strSQL + " INSERT INTO CustomerCreditCard (CustomerID,CardNumber)";
                strSQL = strSQL + "VALUES (@CustomerID,@CardNumber);";

                //Step 5-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 6-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 7-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the INSERT QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = objDTO.CardNumber;
                objCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = objDTO.OwnerName;
                objCmd.Parameters.Add("@MerchantName", SqlDbType.VarChar).Value = objDTO.MerchantName;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@HouseStreetAddress", SqlDbType.VarChar).Value = objDTO.HouseStreetAddress;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.VarChar).Value = objDTO.StateCode;
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = objDTO.CreditLimit;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;
               objCmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = parentKey;
                //Step 8-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 9-validate if INSERT QUERY was successful
                if (intRecordsAffected == 2)
                {
                    //Step 9a-Return true
                    return true;
                }
                //Step 10 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO InsertChildObjectOfAParent (Key,CreditCardDTO objDTO) Method: { 0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Insert

        // Public CreditCardDAO Class Update(CreditCardDTO objDTO) Data Access Method requirements
        public bool Update(CreditCardDTO objDTO)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL;
                strSQL = "UPDATE CreditCard";
                strSQL = strSQL + " SET OwnerName=@OwnerName,";
                strSQL = strSQL + "MerchantName=@MerchantName,";
                strSQL = strSQL + "ExpDate=@ExpDate,";
                strSQL = strSQL + "HouseStreetAddress=@HouseStreetAddress,";
                strSQL = strSQL + "City=@City,";
                strSQL = strSQL + "StateCode=@StateCode,";
                strSQL = strSQL + "ZipCode=@ZipCode,";
                strSQL = strSQL + "Country=@Country,";
                strSQL = strSQL + "CreditLimit=@CreditLimit,";
                strSQL = strSQL + "ActivationStatus=@ActivationStatus";
                strSQL = strSQL + " WHERE CardNumber=@CardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = objDTO.OwnerName;
                objCmd.Parameters.Add("@MerchantName", SqlDbType.VarChar).Value = objDTO.MerchantName;
                objCmd.Parameters.Add("@ExpDate", SqlDbType.VarChar).Value = objDTO.ExpDate;
                objCmd.Parameters.Add("@HouseStreetAddress", SqlDbType.VarChar).Value = objDTO.HouseStreetAddress;
                objCmd.Parameters.Add("@City", SqlDbType.VarChar).Value = objDTO.City;
                objCmd.Parameters.Add("@StateCode", SqlDbType.Char).Value = objDTO.StateCode.ToCharArray();
                objCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = objDTO.ZipCode;
                objCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = objDTO.Country;
                objCmd.Parameters.Add("@CreditLimit", SqlDbType.Decimal).Value = objDTO.CreditLimit;
                objCmd.Parameters.Add("@ActivationStatus", SqlDbType.Bit).Value = objDTO.ActivationStatus;
                objCmd.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = objDTO.CardNumber;
                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }
                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Update(CreditCardDTO objDTO) Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Insert

        // Public CreditCardDAO Class Delete(string Key) Data Access Method requirements
        public bool Delete(string key)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "DELETE FROM CreditCard WHERE CardNumber = @CardNumber;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                //IMPORTANT! Parameter TOKENS @XXXXX name must match same name Used in the UPDATE QUERY
                //AND IN LISTED IN THE ORDER LISTED IN INSERT QUERY! NOTE WE ARE ASSIGNING ALL OBJECT'S DATA
                objCmd.Parameters.Add("@CardNumber", SqlDbType.VarChar).Value = key;
                //Step 7-Execute ACTION-Query, Test result and throw exception if failed
                int intRecordsAffected = objCmd.ExecuteNonQuery();
                //Step 8-validate if INSERT QUERY was successful
                if (intRecordsAffected == 1)
                {
                    //Step 8a-Return true
                    return true;
                }
                //Step 9 - Terminate ADO Objects
                objCmd.Dispose();
                objCmd = null;
                //Step10-return false
                return false;
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO Delete(key) Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of Delete


        // Public CreditCardDAO Class GetAllRecords() Data Access Method requirements

        public List<CreditCardDTO> GetAllRecords()
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "SELECT * FROM CreditCard;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();

                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<CreditCardDTO> colRecordList = new List<CreditCardDTO>();
                    //Step 10-Loop through the Collection to Add Data Transfer Object
                    while (objDR.Read())
                    {
                        //10a-Create Data Transfer Object
                        CreditCardDTO objDTO = new CreditCardDTO();
                        //10b-Populate Data Transfer Object with DataReader records
                        //IMPORTANT! Note that data must be extracted in the ORDER
                        //in which the QUERY RETURNS THE DATA.
                        objDTO.CardNumber = objDR.GetString(0);
                        objDTO.OwnerName = objDR.GetString(1);
                        objDTO.MerchantName = objDR.GetString(2);
                        objDTO.ExpDate = objDR.GetDateTime(3);
                        objDTO.HouseStreetAddress = objDR.GetString(4);
                        objDTO.City = objDR.GetString(5);
                        objDTO.StateCode = objDR.GetString(6);
                        objDTO.ZipCode = objDR.GetString(7);
                        objDTO.Country = objDR.GetString(8);
                        objDTO.CreditLimit = objDR.GetDecimal(9);
                        objDTO.ActivationStatus = objDR.GetBoolean(10);
                        //Step 10c-Add Data Transfer Object to the collection
                        colRecordList.Add(objDTO);
                    }//End of loop
                     //Step 11-Return the collection
                    return colRecordList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllRecords() Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllRecords

        // Public CreditCardDAO Class GetAllKeys() Data Access Method requirements
        public List<string> GetAllKeys()
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string
                string strSQL = "SELECT CardNumber FROM CreditCard;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();
                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<string> colKeyList = new List<string>();
                    //Step 10-Loop through the Collection & Add results from the first column of DataReader
                    while (objDR.Read())
                    {
                        //Step 10a-Add Data Transfer Object to the collection
                        colKeyList.Add(objDR.GetString(0));
                    }//End of loop
                     //Step 11-Return the collection
                    return colKeyList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllKeys() Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllKeys

        // Public CreditCardDAO Class GetAllChildRecordsOwnedByParent(int ParentKey) Data Access Method requirements
        public List<CreditCardDTO> GetAllChildRecordOwnedByParent(string ParentKey)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string. Note spaces between SELECT, FROM, WHERE & AND clauses
                string strSQL;
                strSQL = "SELECT CreditCard.CardNumber,CreditCard.OwnerName,";
                strSQL = strSQL + "CreditCard.MerchantName,CreditCard.ExpDate,";
               strSQL = strSQL + "CreditCard.HouseStreetAddress,CreditCard.City,CreditCard.StateCode,";
                strSQL = strSQL + "CreditCard.ZipCode,CreditCard.Country,";
                strSQL = strSQL + "CreditCard.CreditLimit,CreditCard.ActivationStatus)";
                strSQL = strSQL + " FROM CreditCard, CustomerCreditCard";
                strSQL = strSQL + " WHERE CreditCard.CardNumber = CustomerCreditCard.CardNumber";
                strSQL = strSQL + " AND CustomerCreditCard.CustomerID = @CustomerID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = ParentKey;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();
                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<CreditCardDTO> colRecordList = new List<CreditCardDTO>();
                    //Step 10-Loop through the Collection & Add Data Transfer Object (DTO)
                    while (objDR.Read())
                    {
                        //10a-Create Data Transfer Object
                        CreditCardDTO objDTO = new CreditCardDTO();
                        //10b-Populate Data Transfer Object with DataReader records
                        //IMPORTANT! Note that data must be extracted in the ORDER
                        //in which the QUERY RETURNS THE DATA.
                        objDTO.CardNumber = objDR.GetString(0);
                        objDTO.OwnerName = objDR.GetString(1);
                        objDTO.MerchantName = objDR.GetString(2);
                        objDTO.ExpDate = objDR.GetDateTime(3);
                        objDTO.HouseStreetAddress = objDR.GetString(4);
                        objDTO.City = objDR.GetString(5);
                        objDTO.StateCode = objDR.GetString(6);
                        objDTO.ZipCode = objDR.GetString(7);
                        objDTO.Country = objDR.GetString(8);
                        objDTO.CreditLimit = objDR.GetDecimal(9);
                        objDTO.ActivationStatus = objDR.GetBoolean(10);
                        //Step 10c-Add Data Transfer Object to the collection
                        colRecordList.Add(objDTO);
                    }//End of loop
                     //Step 11-Return the collection
                    return colRecordList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllChildKeysOwnedByParent() Method: {0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllChildRecordsOwnedByParent

        // Public CreditCardDAO Class GetAllChildKeysOwnedByParent(int ParentKey) Data Access Method requirements
        public List<string> GetAllChildKeysOwnedByParent(string ParentKey)
        {
            //Step 1-Create Connection, assign Connection to string
            SqlConnection objConn = new SqlConnection(SQLServerDAOFactory.ConnectionString());
            //Step A-Start Error Trapping
            try
            {
                //Step 2-Open connection
                objConn.Open();
                //Step 3-Create SQL string. Note spaces between SELECT, FROM, WHERE & AND clauses
                string strSQL;
                strSQL = "SELECT CreditCard.CardNumber";
                strSQL = strSQL + " FROM CreditCard, CustomerCreditCard";
                strSQL = strSQL + " WHERE CreditCard.CardNumber = CustomerCreditCard.CardNumber";
                strSQL = strSQL + " AND CustomerCreditCard.CustomerID = @CustomerID;";

                //Step 4-Create Command object, pass query and connection object
                SqlCommand objCmd = new SqlCommand(strSQL, objConn);
                //Step 5-SET CommandType Property to text since we have a query string & NOT a Stored-Procedure
                //For stored procedures syntax is objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandType = CommandType.Text;
                //Step 6-Add Parameter to. NOTE WE ARE ASSIGNING METHOD PARAMETER
                objCmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = ParentKey;
                //Step 7-Create DATAREADER POINTER & Execute Query via
                //COMMAND OBJECT ExecuteReader Method which returns a populated
                //DATAREADER OBJECT with the results of the query
                SqlDataReader objDR = objCmd.ExecuteReader();
                //Step 8-Test to make sure there is data in the DataReader Object
                if (objDR.HasRows)
                {
                    //Step 9-Test Create a Generic List Collection Object of Data Transfer Objects
                    List<string> colKeyList = new List<string>();
                    //Step 10-Loop through the Collection & Add results from the first column of DataReader
                    while (objDR.Read())
                    {
                        //Step 10a-Add Data Transfer Object to the collection
                        colKeyList.Add(objDR.GetString(0));
                    }//End of loop
                     //Step 11-Return the collection
                    return colKeyList;
                }
                else
                {
                    //Step 12 - Terminate ADO Objects
                    objDR.Close();
                    objDR = null;
                    objCmd.Dispose();
                    objCmd = null;
                    //Step13-return null since no records found
                    return null;

                }//End of if/else
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (Exception objE)
            {
                //Step C- throw system exception since run time error has occurred.
                throw new Exception("Unexpected Error in CreditCardADO GetAllChildKeysOwnedByParent() Method:{0} " + objE.Message);
            }
            finally
            {
                //Step 11-Terminate connection
                objConn.Close();
                objConn.Dispose();
                objConn = null;
            }
        }//End of GetAllChildKeysOwnedByParent

    }
}
