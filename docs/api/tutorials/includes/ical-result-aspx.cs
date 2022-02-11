int associd = 0;
int.TryParse(Request.QueryString["associd"], out associd);
string guid = Request.QueryString["guid"];
string souser = ConfigurationSettings.AppSettings["SOUser"];
string sopass = ConfigurationSettings.AppSettings["SOPass"];

using (SoSession sesh = SoSession.Authenticate(souser, sopass))
{
  AssociateRow assocRow = AssociateRow.GetFromIdxAssociateId(associd);
  if (assocRow.AssociateId == associd)
  {
    int fkDevId = Util.GetFkDevice("SO-iCal");
    if (guid == assocRow.ForeignKeyHelper.Get(fkDevId, "iCal"))
    {
      string tmpUri = Request.Url.AbsoluteUri;
      tmpUri = tmpUri.Replace("Result.aspx", "iCal.aspx");
      ResultInfo.InnerHtml = "<b>Success!</b> You can add the following link to Google Calendar: <br>" + "<a href=\"" + tmpUri + "\">" + tmpUri + "</a><br>\n" + "<p>Note that old links you may have created will stop working. Only one link is valid at a time.";
    }
  }
}