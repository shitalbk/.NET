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
    public partial class frmAddCreditCard : Form
    {
        public frmAddCreditCard()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close this form 
            // Program flow automatically goes back to the Main Form
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Step A - start Exception handling
            try
            {
                //Step1 - Create a Customer Object
                CreditCard objCreditCard = new CreditCard();
                //Set Object with parameters values
                objCreditCard.CardNumber = txtCardNumber.Text.Trim();
                objCreditCard.OwnerName = txtCardOwner.Text.Trim();
                objCreditCard.MerchantName = txtMerchantName.Text.Trim();
      //          objCreditCard.ExpDate = txtExpDate.Text.Trim();
                objCreditCard.HouseStreetAddress = txtHouseStreetAddress.Text.Trim();
                objCreditCard.City = txtCity.Text.Trim();
                objCreditCard.StateCode = txtState.Text.Trim();
                objCreditCard.ZipCode = txtZipCode.Text.Trim();
                objCreditCard.Country = txtCountry.Text.Trim();
         //       objCreditCard.CreditLimit = txtCreditLimit.Text.Trim();
          //      objCreditCard.ActivationStatus = txtActivationStatus.Text.Trim();

                //Call Card Object Insert()) method to execute INSERT query
                //Using the populated object's data to create Inser query

                bool success = objCreditCard.Insert();

                //Step 2-If validate card was added
                if (success)
                {
                    //Prompt user card was added
                    MessageBox.Show("Credit Card Added");
                    //Step 5-Clear all controls
                    txtCardNumber.Text = "";
                    txtCardOwner.Text = "";
                    txtMerchantName.Text = "";
                    txtExpDate.Text = "";
                    txtHouseStreetAddress.Text = "";
                    txtCity.Text = "";
                    txtState.Text = "";
                    txtZipCode.Text = "";
                    txtCountry.Text = "";
                    txtCreditLimit.Text = "";
                    txtActivationStatus.Text = "";

                }
                else
                {
                    //prompt user Credit Card was not added
                    MessageBox.Show("Error! Card was not added!");
                }
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (System.Exception)
            {
                //Step C- throw system exception since run time error has occured;
                MessageBox.Show("Error! Card was not added!");
            }
        }
    }
    
}
