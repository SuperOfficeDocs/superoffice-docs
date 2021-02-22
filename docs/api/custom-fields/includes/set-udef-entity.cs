Contact contact = Contact.GetFromIdxContactId(int.Parse(txtContactId.Text.Trim()));
if (contact != null)
{
  // Get the prodId of the udefField of interest
  string progId= contact.UdefHelper.GetProgIdFromFieldLabel("companydropdownlistbox");

  // Modify the value for the udef field for the current contact to the selected value
  contact.UdefHelper.SetValue(progId,this.lstFieldList.SelectedValue);

  // Save the contact details
  contact.Save();
  MessageBox.Show("Contact details saved successfully.");
}