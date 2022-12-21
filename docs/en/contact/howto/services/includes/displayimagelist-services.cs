using SuperOffice;
using SuperOffice.CRM.Services;

//Method that displays the Image Name on the Listbox
private void DisplayImageList()
{
  using (SoSession newSoSession = SoSession.Authenticate("sam", "sam"))
  {
    //Select a list of Project Images using the MDOAgent
    MDOAgent newMDOAgt = new MDOAgent();
    SelectableMDOListItem[] newSelLstArr = newMDOAgt.GetSelectableList("ProjectImage", true, "", false);

    foreach (SelectableMDOListItem newSelLst in newSelLstArr)
    {
      //Display the image name in the Listbox
      listBox1.Items.Add(newSelLst.Name);
    }
  }
}