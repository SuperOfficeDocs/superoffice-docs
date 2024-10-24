protected void LoginSubmit_ServerClick(object sender, EventArgs e)
{
  SoSession sesh = SoSession.Authenticate(Username.Value, Password.Value);
  if (sesh.IsOpen)
  {
    string guid = Guid.NewGuid().ToString();
    int id = sesh.Principal.AssociateId;
    AssociateRow assoc = AssociateRow.GetFromIdxAssociateId(id);
    int fkDevId = Util.GetFkDevice("SO-iCal");
    assoc.ForeignKeyHelper.Set( fkDevId, "iCal",  guid );
    assoc.ForeignKeyHelper.Save();
    sesh.Close();
    string url = string.Format("Result.aspx?associd={0}&guid={1}", id, guid );
    Response.Redirect( url );
  }
  else
    Result.InnerText = "Unable to log in to SuperOffice as " + Username.Value;
  }
  catch(Exception)
  {
    Result.InnerText = "Unable to log in to SuperOffice as " + Username.Value;
  }
}