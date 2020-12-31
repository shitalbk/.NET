using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    public class CreditCardDTO
    {

        #region "PUBLIC PROPERTIES DECLARATIONS"
        /******************************************************************
        Public INSTANCE & STATIC PROPERTIES Declarations
        ******************************************************************/
        //Public INSTANCE Properties Declarations
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public string MerchantName { get; set; }
        public DateTime ExpDate { get; set; }
        public string HouseStreetAddress { get; set; }
      //  public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public decimal CreditLimit { get; set; }
        public bool ActivationStatus { get; set; }
        #endregion
    } //End of Interface
} //End of Namespace

