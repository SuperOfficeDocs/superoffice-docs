using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.mdControls;
public partial class Time2Holiday : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    //Display the current date
    TextBox txtCurDate = soPanel.FindControl("txtCurrDateValue") as TextBox;
    txtCurDate.Text = System.DateTime.Now.ToString();

    //Add values to the drop down list
    if (!IsPostBack)
    {
      ddlHoliday.Items.Add("Christmas");
      ddlHoliday.Items.Add("New Year");
      ddlHoliday.Items.Add("Summer Equinox");
    }
  }
  protected void LoginBtn_Click(object sender, EventArgs e)
  {
    //Varable Declaration
    //Current Date related varables
    DateTime currentDate = DateTime.Today.Date;
    int currentYear = DateTime.Today.Year;

    //Holidays related variables
    DateTime christmas = new DateTime(currentYear, 12, 25);
    DateTime newYear = new DateTime(currentYear + 1, 1, 1);
    DateTime sumEqui = new DateTime(currentYear, 6, 20);

    //Variable related to the number of days in between
    TimeSpan numberOfDays;
    int numberDays = 0;

    //DropDownlist instantiation
    DropDownList newHolidayList = soPanel.FindControl("ddlHoliday") as DropDownList;

    //TextBox instantiation which is used to display the numbers
    TextBox txtNumDays = soPanel.FindControl("txtNumberOfDaysValue") as TextBox;

    //Calculation of the Number of days in between
    //If the Holiday is Christmas
    if (newHolidayList.SelectedValue.Equals("Christmas"))
    {
      numberOfDays = christmas - currentDate;
      if (numberOfDays.Days < 0)
      {
        numberDays = 365 + numberOfDays.Days;
        txtNumDays.Text = numberDays.ToString() + " days to Christmas";
      }
      else
        txtNumDays.Text = numberOfDays.Days.ToString() + " days to Christmas";
    }

    //If the holiday is the new year Date
    if (newHolidayList.SelectedValue.Equals("New Year"))
    {
      numberOfDays = newYear - currentDate;
      txtNumDays.Text = numberOfDays.Days.ToString() + " days to New Year";
    }

    //If the Holiday is Summer Equinox
    if (newHolidayList.SelectedValue.Equals("Summer Equinox"))
    {
      numberOfDays = sumEqui - currentDate;
      if (numberOfDays.Days < 0)
      {
        numberDays = 365 + numberOfDays.Days;
        txtNumDays.Text = numberDays.ToString();
      }
      else
        txtNumDays.Text = numberOfDays.Days.ToString() + " days to Summer Equinox";
    }
  }
}