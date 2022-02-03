using SuperOffice;
using SuperOffice.CRM.Rows;
//Method that displays the Image description on the Listbox
private void DisplayImageList()
{
  using (SoSession newSoSession = SoSession.Authenticate("sam", "sam"))
  {
    //Retrieves a set of BinaryObjectRows whose MimeType = "image/jpeg"
    BinaryObjectRows newBinObjRws = BinaryObjectRows.GetFromIdxMimeType("image/jpeg");

    //Displays a list of Images Available
    foreach (BinaryObjectRow newBinObjRw in newBinObjRws)
    {
      //Display the image description in the Listbox
      listBox1.Items.Add(newBinObjRw.Description);
    }
  }
}