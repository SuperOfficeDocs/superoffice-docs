using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  ContactRows newConRows = ContactRows.CreateNew();
  //Instantiate a ContactRow type
  ContactRow newContact = ContactRow.CreateNew();
  //Assign values to the instantiated ContactRow
  newContact.SetDefaults();
  newContact.Name = "EuroCenter";
  newContact.OrgNr = "1234523";
  newContact.Number1 = "7412885";
  //Adding the created Contacted to the Collection
  newConRows.Add(newContact);
  //Saving the ContactRows Collection
  newConRows.Save();
}