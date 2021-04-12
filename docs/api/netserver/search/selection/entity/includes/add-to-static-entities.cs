using SuperOffice.CRM.Security;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //retrieve the contact that owns the persons we want to add as members
  //to our static selection
  Contact myContact = Contact.GetFromIdxContactId(21);

  //retrieve the selection that we want to add members to
  Selection staticSelection = Selection.GetFromIdxSelectionId(65);

  //lets loop through the persons of the contact and the them to the
  // selection as its members
  int i = 0;
  if (myContact.Persons.Count > 0)
  {
    foreach (Person myPerson in myContact.Persons)
    {
      //create a new selection member row
      SelectionMemberRow newRow =
      SelectionMemberRow.CreateNew();

      //set the default values
      newRow.SetDefaults();

      //assign the contact ID
      newRow.ContactId = myContact.ContactId;

      //assign the person ID
      newRow.PersonId = myPerson.PersonId;

      //add rows of the selection member rows collection one by
      // one to the retrieved static selection entity
      staticSelection.SelectionMembers.Add(newRow);
      i++;
    }
  }
  //finally save the selection entity
  staticSelection.Save();
}