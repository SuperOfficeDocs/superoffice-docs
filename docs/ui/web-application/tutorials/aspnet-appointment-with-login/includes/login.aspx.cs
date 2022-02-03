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

public partial class Login : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {

  }
  protected void LoginBtn_Click(object sender, EventArgs e)
  {
    //Retriving the user name and password and assigning them to Session variables
    //UserName
    TextBox un = soLogin.FindControl("UserName") as TextBox;
    Session["UserName"] = un.Text;

    //Password
    TextBox pw = soLogin.FindControl("Password") as TextBox;
    Session["passWord"] = pw.Text;

    using (SoSession mySession = SoSession.Authenticate(Session["UserName"].ToString(), Session["passWord"].ToString()))
    {
      //Transfering to the Appointments page
      Server.Transfer("Appointments.aspx");
    }
  }
}