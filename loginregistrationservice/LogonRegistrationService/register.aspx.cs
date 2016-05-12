using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        RegisterReviewer();
    }

    protected void RegisterReviewer()
    {
        LoginServiceReference.LoginServiceClient lsc = new LoginServiceReference.LoginServiceClient();
        LoginServiceReference.Reviewer r = new LoginServiceReference.Reviewer();
        r.ReviewerLastName = lastNameTextBox.Text;
        r.ReviewerFirstName = firstNameTextBox.Text;
        r.ReviewerEmail = emailTextBox.Text;
        r.ReviewerUserName = emailTextBox.Text;
        r.ReviewPlainPassword = passwordTextBox.Text;

        bool result = lsc.RegisterReviewer(r);

        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Registration failed, please try again.";
        }

    }
}