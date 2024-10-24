using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Lists;
using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Retrieve a Contact Based on the Contact ID
  Contact newContact = Contact.GetFromIdxContactId(10);

  //Get the list of heading items that are currently selected,
  // (have link rows to the parent entity)
  List<ISoListHeading> newLstHdItms = newContact.InterestHelper.SelectedHeadingItems;

  //Get the list of root items that are currently selected,
  // (have link rows to the parent entity)
  List<ISoListItem> newLstItms = newContact.InterestHelper.SelectedRootItems;
}