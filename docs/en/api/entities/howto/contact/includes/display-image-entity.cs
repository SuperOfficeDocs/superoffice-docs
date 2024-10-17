using System.IO;
using SuperOffice;
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice.CRM.Data;
//Method that is invoked when a item is selected from the Listbox
private void listBox1_SelectedValueChanged(object sender, EventArgs e)
{
  using (SoSession newSoSession = SoSession.Authenticate("sam", "sam"))
  {
    //Instantiate a BinaryRowObject CustomSearch
    BinaryObjectRow.CustomSearch newCusSearch = new BinaryObjectRow.CustomSearch();

    //Instantiate BinaryObjectTableInfo class using the created CustomSearch
    BinaryObjectTableInfo newBinObjTabInf = newCusSearch.TableInfo;

    //Restricts the BinaryObjectTableInfo
    newCusSearch.Restriction = newBinObjTabInf.Description.Equal(
      S.Parameter(listBox1.SelectedItem.ToString())).
      And(newBinObjTabInf.MimeType.Equal(S.Parameter("image/jpeg")));

    //Retrieves the BinaryObjectRow based on the CustomSearch
    BinaryObjectRow newBinObjRw = BinaryObjectRow.GetFromCustomSearch(newCusSearch);

    //Gets the BinaryObjectRow's image into the stream and display it
    Stream newStream = newBinObjRw.BinaryData;
    pictureBox1.Image = Image.FromStream(newStream);
  }
}