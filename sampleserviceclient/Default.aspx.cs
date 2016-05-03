using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    samplebookreviewservicereference.SampleBookReviewServiceClient bsc = new samplebookreviewservicereference.SampleBookReviewServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillAuthorDropDown();
    }
    protected void FillAuthorDropDown()
    {
        string[] authors = bsc.GetAuthors();
        authorDropDownList.DataSource = authors;
        authorDropDownList.DataBind();
    }
    protected void BookButton_Click(object sender, EventArgs e)
    {
        string author = authorDropDownList.SelectedItem.Text;
        samplebookreviewservicereference.BookLite[] books = bsc.GetBooks(author);
        bookGridView.DataSource = books;
        bookGridView.DataBind();
     }



    protected void BookButton_Click1(object sender, EventArgs e)
    {

    }
}