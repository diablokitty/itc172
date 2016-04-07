using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //This is the function executed on the button click.
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetTimeTilBirthday();
    }


    //This function calculates the days and hours until the next date selected and returns a string with the result to the user.
    protected void GetTimeTilBirthday()
    {
        DateTime birthDay;
        if (BirthdayCalendar.SelectedDate <= DateTime.Now)
        {
            birthDay = DateTime.Now;
            ResultLabel.Text = "Please choose a date in the future.";

        }
        else
        {

            birthDay = BirthdayCalendar.SelectedDate;


            string name = NameTextBox.Text;

            TimeSpan daysTilBirthday = birthDay.Subtract(DateTime.Now);
            ResultLabel.Text = name + ", you have " + Math.Abs(daysTilBirthday.Days).ToString() + " days, and " + Math.Abs(daysTilBirthday.Hours).ToString() + " hours until your next birthday.";

        }
    }    

}
