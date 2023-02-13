using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiate a ContactRow type
  ContactRow newContact = ContactRow.CreateNew();

  //Assign values to the instantiated ContactRow
  newContact.SetDefaults();
  newContact.Name = "EuroCenter";
  newContact.OrgNr = "1234523";
  newContact.Number1 = "7412885";

  //Saving the ContactRow
  newContact.Save();
}