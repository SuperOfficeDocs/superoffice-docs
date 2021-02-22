using System.IO;
using SuperOffice;
using SuperOffice.CRM.Services;

//Method that is invoked when an item is selected from the Listbox
private void listBox1_SelectedValueChanged(object sender, EventArgs e)
{
  using (SoSession newSoSession = SoSession.Authenticate("sam", "sam"))
  {
    //Retrieving the details of the selected image from the ListBox
    IMDOAgent newMDOAgt = new MDOAgent();
    SelectableMDOListItem[] newSelLstArr = newMDOAgt.GetSelectableListWithRestriction("ProjectImage", "", listBox1.SelectedItem.ToString());

    //Using the BLOB agent retrieving the selected image
    IBLOBAgent newBLOBAgt = new BLOBAgent();
    Stream newStream = newBLOBAgt.GetBlobStream(newSelLstArr[0].Id);
    pictureBox1.Image = Image.FromStream(newStream);
  }
}