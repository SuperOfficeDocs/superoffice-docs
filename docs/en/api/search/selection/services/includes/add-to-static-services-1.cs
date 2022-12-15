using SuperOffice.CRM.Security;
using SuperOffice.CRM.Services;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //create a Selection agent
  SelectionAgent selectionAgent = new SelectionAgent();

  //create a contact agent
  ContactAgent contactAgent = new ContactAgent();

  //retrieve the contact entity of the persons that you want to add as
  //members to the selection that you want
  ContactEntity myContact = contactAgent.GetContactWithPersons(21);
  if (myContact.Persons.Length > 0)
  {
    //create a array of ContactPersonIds and add the array to the selection
    ContactPersonId[] personId = new ContactPersonId[3];
    for (int i = 0; i<3; i++ )
    {
      personId[i] = new ContactPersonId();
      personId[i].ContactId = myContact.ContactId;
      personId[i].PersonId = myContact.Persons[i].PersonId;
    }
    //add the members to the selection
    selectionAgent.AddContactSelectionMembers(65, personId);
  }
}