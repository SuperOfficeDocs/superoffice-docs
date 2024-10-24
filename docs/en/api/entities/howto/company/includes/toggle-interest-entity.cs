using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Lists;

using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Setting the Interest name to be searched
  string searchIntrsName = "Sams Interests";

  //Retrieve a Contact
  Contact newContact= Contact.GetFromIdxContactId(10);

  //Search and find the contact interests by interest name
  ISoListItem newIntrstItm = newContact.InterestHelper.RootItems.Find(delegate(ISoListItem ISOLstItm)
  {
    return ISOLstItm.Name.Equals(searchIntrsName,StringComparison.InvariantCultureIgnoreCase);
  }
  );

  //Check whether the Interest has been found
  if (newIntrstItm != null && newIntrstItm.Id > 0)
  {
    //Sets the Interest to true or false
    newContact.InterestHelper.SetItemSelection(newIntrstItm.Id, true);
  }
}