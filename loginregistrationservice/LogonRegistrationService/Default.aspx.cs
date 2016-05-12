using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Login();
    }

    protected void Login()
    {
        LoginServiceReference.LoginServiceClient rs = new LoginServiceReference.LoginServiceClient();
        int key = rs.ReviewerLogin(userNameTextBox.Text, passwordTextBox.Text);
        if(key != 0)
        {
            errorLabel.Text = "Welcome";
                Session["Userkey"] = key;
        }
        else
        {
            errorLabel.Text = "Invalid Login";
        }
        
    }
}