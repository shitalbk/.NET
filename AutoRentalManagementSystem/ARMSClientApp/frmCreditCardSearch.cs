using ARMSBOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public partial class frmCreditCardSearch : Form
    {
        public frmCreditCardSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Step A - start Exception handling
            try
            {
                //Step1 - Create a Credit Card Object
                CreditCard objCreditCard = new CreditCard();
                //Call CreditCard Object Load(ID) method to execute SELECT query
                //to the database and populate itself with the record returned
                //from the query
                bool success = objCreditCard.Load(txtCardNumber.Text.Trim());
                //Step 2-If validate card is found
                if (success)
                {
                    //Step 3-Then Data is extracted from credit card object & placed on textboxes
                    txtCardNo.Text = objCreditCard.CardNumber;
                    txtOwnerName.Text = objCreditCard.OwnerName;
                    txtMerchantName.Text = objCreditCard.MerchantName;
                    txtExpDate.Text = objCreditCard.ExpDate.ToString();
                    txtHouseStreetAddress.Text = objCreditCard.HouseStreetAddress; //convert to a string
                    txtCity.Text = objCreditCard.City;
                    txtStateCode.Text = objCreditCard.StateCode;
                    txtZipCode.Text = objCreditCard.ZipCode;
                    txtCountry.Text = objCreditCard.Country;
                    txtCreditLimit.Text = objCreditCard.CreditLimit.ToString();
                    txtActivationStatus.Text = objCreditCard.ActivationStatus.ToString();

                }
                else
                {
                    //Step 4-prompt user card not found
                    MessageBox.Show("Credit Card Not Found");
                    //Step 5-Clear all controls
                    txtCardNo.Text = "";
                    txtOwnerName.Text = "";
                    txtMerchantName.Text = "";
                    txtExpDate.Text = "";
                    txtHouseStreetAddress.Text = "";
                    txtCity.Text = "";
                    txtStateCode.Text = "";
                    txtZipCode.Text = "";
                    txtCountry.Text = "";
                    txtCreditLimit.Text = "";
                    txtActivationStatus.Text = "";
                }
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (System.Exception)
            {
                //Step C- throw system exception since run time error has occured;
                MessageBox.Show("Error in search!");
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
