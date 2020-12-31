using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_WebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            // Declare variables to store the username and password & to create our display string
            String username;
            String password;
            String output;

            // Set username & password variables with data entered by user in textboxes
            username = txtUsername.Text;
            password = txtPassword.Text;

            // Create concatenated formatted string
            output = "The username = " + username + "\n\n";
            output = output + " & the password = " + password + "\n\n";

            // Display output string - SET ASP.NET Message LABEL CONTROL with the output string
            lblMessage.Text = output;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txtUsername.Text = "";
            txtPassword.Text = "";

            // Clear the message label
            lblMessage.Text = "";
        }
    }
}