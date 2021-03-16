using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.mdControls;

using SuperOffice;
using SuperOffice.CRM.Services;

public partial class Appointments : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if(!IsPostBack)
      this.tblid.Visible = false;
    else
      this.tblid.Visible = true;
  }

  protected void datesBtn_Click(object sender, EventArgs e)
  {
    using (SoSession mySession = SoSession.Authenticate(Session["UserName"].ToString().Trim(), Session["passWord"].ToString().Trim()))
    {
      //retrieve user inputs and store them in variables
      TextBox ai = form1.FindControl("assoicateID") as TextBox;
      TextBox ad = form1.FindControl("activeDate") as TextBox;
      TextBox ed = form1.FindControl("endDate") as TextBox;

      //converting the values to the format required by the method
      int personID = int.Parse(ai.Text);
      DateTime activeDate = DateTime.Parse(ad.Text);
      DateTime endDate = DateTime.Parse(ed.Text);

      //retrive the appointments list using the Agent
      IAppointmentAgent newAppAgt = AgentFactory.GetAppointmentAgent();

      ActivityInformationListItem[] newAppArr = newAppAgt.GetActivityInformationListByDatesAndAssociate(activeDate, endDate, 103);

      //Displaying the Appointments between a given date range of and Associate
      for (int i = 0; i < newAppArr.Length; i++)
      {
        //Instantiate table rows and table cells
        HtmlTableCell tblcelldate = new HtmlTableCell();
        HtmlTableCell tblcellday = new HtmlTableCell();
        HtmlTableRow tblrow = new HtmlTableRow();

        //Assigning data to the table
        tblcelldate.Controls.Add(new LiteralControl(newAppArr[i].Date.Date.ToString("dd/MM/yyyy")));
        tblcellday.Controls.Add(new LiteralControl(newAppArr[i].Date.DayOfWeek.ToString()));
        tblrow.Controls.Add(tblcelldate);
        tblrow.Controls.Add(tblcellday);
        tblid.Controls.Add(tblrow);
        datesBtn.Visible = false;
      }
    }
  }
}