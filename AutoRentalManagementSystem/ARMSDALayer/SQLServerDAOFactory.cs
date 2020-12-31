using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public class SQLServerDAOFactory : DALObjectFactoryBase
    {
        /***********************************************************************/
        //Name: ConnectionString() Method
        //Purpose: Centralized method that returns the Connection String for
        // MS SQLServer data access.
        //Parameter: None.
        //Return Value: string that contains the connection string.
        public static string ConnectionString()
        {
            return "Data Source =.\\SQLExpress; Initial Catalog = EZPLUSPROJECT; Integrated Security = True";
          //  return "Data Source=.\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        /***********************************************************************/
        //Name: GetRetailCustomerDAO() Method
        //Purpose: Method that returns the RetailCustomerDAO Data Access Object
        // that handles the data access for the RetailCustomer
        // class in the business object Layer.
        //Parameter: None.
        //Return Value: a new RetailCustomerDAO object.
      
        /***********************************************************************/
        //Name: GetCorporateCustomerDAO() Method
        //Purpose: Method that returns the CorporateCustomerDAO Data Access Object
        // that handles the data access for the CorporateCustomer
        // class in the business object Layer.
        //Parameter: None.
        //Return Value: a new CorporateCustomerDAO object.
       

        /***********************************************************************/
     //Name: GetCreditCardDAO() Method
     //Purpose: Method that returns the CreditCardDAO Data Access Object
     // that handles the data access for the CreditCard
     // class in the business object Layer.
     //Parameter: None.
     //Return Value: a new CreditCardDAO object.
     public override CreditCardDAO GetCreditCardDAO()
     {
     //return CreditCardDAO Data Access Object to perform CreditCard Data Access
     return new CreditCardDAO();
     }
     /***********************************************************************/
     //Name: GetCustomerUserAccountDAO() Method
     //Purpose: Method that returns the Product Data Access Object
     // that handles the data access for the Product
     // class in the business object Layer.
     //Parameter: None.
     //Return Value: a new CustomerUserAccountDAO object.
     


     }//End of class
    }//End of namespace


    
