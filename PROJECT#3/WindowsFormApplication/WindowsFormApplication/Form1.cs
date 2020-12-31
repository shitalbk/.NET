using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Declare variables to store the username & password & to create our display string
            String username;
            String password;
            String output;

            // Set username & password variables with data entered by user in textboxes
            username = txtUsername.Text;
            password = txtPassword.Text;

            // Create concatenated formatted string
            output = "The username = " + username + "\n\n";
            output = output + "The password = " + password + "\n\n";

            // Display output string using MessageBox
            MessageBox.Show(output);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
