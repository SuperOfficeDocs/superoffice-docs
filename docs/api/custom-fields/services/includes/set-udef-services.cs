// Create a Contact Agent
IContactAgent agent = new ContactAgent();

// Get a Contact Entity through the Contact Agent
ContactEntity contactEntity = agent.GetContactEntity(int.Parse(txtContactId.Text.Trim()));
if (contactEntity != null)
{
  // Create a UserDefinedFieldInfoAgent
  UserDefinedFieldInfoAgent udefFieldInfoAgent = new UserDefinedFieldInfoAgent();

  // Get the UserDefinedFieldInfo of 'Udlist one' through the UserDefinedFieldInfoAgent
  UserDefinedFieldInfo udefFieldInfo = udefFieldInfoAgent.GetUserDefinedFieldFromFieldLabel("Udlist one", 7);

  // Get the ProgId of the udefField
  string progId = udefFieldInfo.ProgId;

  // Get the UserDefinedFields collection for the current contact
  StringDictionary dictionary = contactEntity.UserDefinedFields;

  // Set the selected value on the listbox to the udefField value
  dictionary[progId] = this.lstFieldList.SelectedValue.ToString();

  // Save the contact details
  agent.SaveContactEntity(contactEntity);
  MessageBox.Show("Contact details saved successfully.");
  this.clearContents();
}