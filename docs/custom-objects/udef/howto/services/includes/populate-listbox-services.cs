using SuperOffice;
using SuperOffice.CRM.Services;

using (SoSession newSession = SoSession.Authenticate("p", "p"))
{
  if (!(String.IsNullOrEmpty(txtContactId.Text.Trim())))
  {
    // Create a Contact Agent
    ContactAgent agent = new ContactAgent();

    // Get a Contact Entity through the Contact Agent
    ContactEntity contactEntity = agent.GetContactEntity(int.Parse(txtContactId.Text.Trim()));
    if (contactEntity != null)
    {
      this.lblContactName.Text = contactEntity.Name;

      // Create a UserDefinedFieldInfoAgent
      UserDefinedFieldInfoAgent udefFieldInfoAgent = new UserDefinedFieldInfoAgent();

      // Get the UserDefinedFieldInfo of 'Udlist one' through the UserDefinedFieldInfoAgent
      UserDefinedFieldInfo udefFieldInfo = udefFieldInfoAgent.GetUserDefinedFieldFromProgId("SuperOffice:12", 7);

      // Create MDOAgent
      MDOAgent mdoAgent = new MDOAgent();

      // Get the MDOListItems array for the given udef field - Udlist one
      MDOListItem[] userDefinedListItems = mdoAgent.GetList("udlist", true, udefFieldInfo.UDListDefinitionId.ToString(), false);

      // Set the list items
      this.lstFieldList.DataSource = userDefinedListItems;
      this.lstFieldList.DisplayMember = "Name";
      this.lstFieldList.ValueMember = "Id";
    }
  }
  else
  {
    MessageBox.Show("Please enter the contact ID.");
  }
}