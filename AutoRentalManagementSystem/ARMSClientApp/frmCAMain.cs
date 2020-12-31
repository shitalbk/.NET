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
    public partial class frmCAMain : Form
    {
        public frmCAMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCAMain_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Close this form 
            this.Close();
        }

        private void btnCardSearch_Click(object sender, EventArgs e)
        {
            // Declare object of Credit Card Search Form
            frmCreditCardSearch objCS = new frmCreditCardSearch();

            // Hide this form 
            this.Hide();

            objCS.ShowDialog();

            this.Show();
        }

        private void btnCardRegister_Click(object sender, EventArgs e)
        {
            // Declare object of Credit Card Registration to Add the Credit Card 
            frmAddCreditCard objAC = new frmAddCreditCard();

            // Hide this form
            this.Hide();

            objAC.ShowDialog();

            this.Show();
        }

        private void btnCardUpdate_Click(object sender, EventArgs e)
        {
            // Declare object of Credit Card Update to Edit the Credit Card Info
            frmEditCreditCard objCU = new frmEditCreditCard();

            // Hide this form 
            this.Hide();

            objCU.ShowDialog();

            this.Show();
        }

        private void btnCardDelete_Click(object sender, EventArgs e)
        {
            // Declare object of Credit Card Delete to Delete the Credit Card Info
            frmDeleteCreditCard objCD = new frmDeleteCreditCard();

            // Hide this form
            this.Hide();

            objCD.ShowDialog();

            this.Show();
        }
    }
}
