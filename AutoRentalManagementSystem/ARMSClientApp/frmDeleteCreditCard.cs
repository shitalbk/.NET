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
    public partial class frmDeleteCreditCard : Form
    {
        public frmDeleteCreditCard()
        {
            InitializeComponent();
        }

        private void frmDeleteCreditCard_Load(object sender, EventArgs e)
        {

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
                //Step1 - Create a Credit Card Object

                CreditCard objCreditCard = new CreditCard();

                //Call Credit Card Object Load(ID) method to execute SELECT query
                //to the database and populate itself with the record returned
                //from the query
                bool success = objCreditCard.Delete(txtIDNumber.Text.Trim());
                //Step 2-If validate credit card is found
                if (success)
                {
                    //Step4-Prompt user credit card was deleted
                    MessageBox.Show("Credit Card Deleted");
                }
                else
                {
                    //Step 4-prompt user credit card not found
                    MessageBox.Show("Credit card Not Found");
                    //Step 5-Clear all controls
                    txtIDNumber.Text = "";
                }
            }//End of try
             //Step B-Trap for BO, App & General Exceptions
            catch (System.Exception)
            {
                //Step C- throw system exception since run time error has occured;
                MessageBox.Show("Error Deleting Credit Card!");
            }

        }
    }
}
