using SuperOffice.CRM.Security;
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Entities;
using SuperOffice;

int contactId;

using (SoSession mySession = SoSession.Authenticate("SAL0",""))
{
  //Create a New Contact entity
  Contact contactEntity = Contact.CreateNew();
  //set default values
  contactEntity.SetDefaults();
  //Give a name
  contactEntity.Name = "Test ContactSentryPlugin";
  //Give a department name that ends with "_"
  contactEntity.Department = "enable plugin_";
  //Set a text for the info property
  contactEntity.Info.Text = "My own data";
  //retrive the Table right object for the contact
  TableRight tableRight = contactEntity.Row.Sentries.TableRight(contactEntity.TableInfo);
  //check to see if we have the update rights
  bool hasUpdate = tableRight.HasUpdate;
  // returns true, since we are owner

  //save the contact
  contactEntity.Save();
  //retrive the id of the saved contact
  contactId = contactEntity.ContactId;
}

//lets login with a different user
using (SoSession mySession = SoSession.Authenticate("adm0", ""))
{
  Contact contactEntity = Contact.GetFromIdxContactId(contactId);
  TableRight tableRight = contactEntity.Row.Sentries.TableRight(contactEntity.TableInfo);
  //lets check for the rights a different user
  bool hasUpdate = tableRight.HasUpdate;
  // returns false, since we are not owner, and ends in underscore
}

//lets login with the owner of the record again
using (SoSession mySession = SoSession.Authenticate("sal0", ""))
{
  Contact contactEntity = Contact.GetFromIdxContactId(contactId);
  TableRight tableRight = contactEntity.Row.Sentries.TableRight(contactEntity.TableInfo);
  //lets check for the rights of the owner
  bool hasUpdate = tableRight.HasUpdate;
  // returns true, since we are owner
}