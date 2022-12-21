using SuperOffice.CRM.Security;
using SuperOffice.CRM.Services;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //create a Selection agent
  SelectionAgent selectionAgent = new SelectionAgent();

  //create an array of ContactPersonIds and add the array to the selection
  ContactPersonId[] personId = new ContactPersonId[3];
  personId[0] = new ContactPersonId();
  personId[0].ContactId = 21;
  personId[0].PersonId = 55;

  personId[1] = new ContactPersonId();
  personId[1].ContactId = 23;
  personId[1].PersonId = 59;

  personId[2] = new ContactPersonId();
  personId[2].ContactId = 35;
  personId[2].PersonId = 83;

  //add the members to the selection
  selectionAgent.AddContactSelectionMembers(65, personId);
}