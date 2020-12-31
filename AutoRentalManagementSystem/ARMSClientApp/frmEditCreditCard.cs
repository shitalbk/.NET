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
    public partial class frmEditCreditCard : Form
    {
        #region "Modular-level Declarations"
        //Create Credit card object POINTER only
        private CreditCard objCreditCard;
        #endregion "Modular-level Declarations"
        public frmEditCreditCard()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Step A - start Exception handling
            try
            {
                //**** PART 1 - SEARCH-GET CREDIT CARD RECORD ****
                //Step1 - Create a Credit Card Object by assiging pointer to new object
                objCreditCard = new CreditCard();
                //Call Credit Card Object Load(ID) method to execute SELECT query
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
            //**** PART 2 - UPDATE CREDIT CARD RECORD ****
            //Step A - start Exception handling
            try
            {
                //Step1 -Set Object with parameters values
                objCreditCard.CardNumber = txtCardNo.Text.Trim();
                objCreditCard.OwnerName = txtOwnerName.Text.Trim();
                objCreditCard.MerchantName = txtMerchantName.Text.Trim();
              //  objCreditCard.ExpDate = txtExpDate.Text.Trim();
                objCreditCard.HouseStreetAddress = txtHouseStreetAddress.Text.Trim();
                objCreditCard.City = txtCity.Text.Trim();
                objCreditCard.StateCode = txtStateCode.Text.Trim();
                objCreditCard.ZipCode = txtZipCode.Text.Trim();
                objCreditCard.Country = txtCountry.Text.Trim();
             //   objCreditCard.CreditLimit = txtCreditLimit.Text.Trim();
             //   objCreditCard.ActivationStatus = txtActivationStatus.Text.Trim();




                //Step2-Call Credit Card Object Insert()) method to execute INSERT query
                //Using the populated object's data to create Inser query
                bool success = objCreditCard.Update();
                //Step 3-If validate credit card was added
                if (success)
                {
                    //Step4-Prompt user credit card was added
                    MessageBox.Show("Credit Card Updated");
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
                else
                {
                    //Step6-prompt user card was not added
                    MessageBox.Show("Error! Credit Card was not Updated!");
                }
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (System.Exception)
            {
                //Step C- throw system exception since run time error has occured;
                MessageBox.Show("Error! Credit Card was not Updated!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
