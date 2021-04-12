using SuperOffice.CRM.Security;
using SuperOffice.CRM.Services;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //create a Selection agent through the agent factory
  ISelectionAgent selectionAgent = AgentFactory.GetSelectionAgent();

  //create a contact agent through the agent factory
  IContactAgent contactAgent = AgentFactory.GetContactAgent();

  //retrieve the contact entity of the persons that you want to add as
  //members to the selection that you want
  ContactEntity myContact = contactAgent.GetContactWithPersons(21);
  if (myContact.Persons.Length > 0)
  {
    //we will create a array of ContactPersonIds and add the array
    //to the selection
    ContactPersonId[] personId = new ContactPersonId[3];
    for (int i = 0; i<3; i++ )
    {
      personId[i] = new ContactPersonId();
      personId[i].ContactId = myContact.ContactId;
      personId[i].PersonId = myContact.Persons[i].PersonId;
    }
    //now lets add the members to the selection that we want
    selectionAgent.AddContactSelectionMembers(65, personId);
  }
}