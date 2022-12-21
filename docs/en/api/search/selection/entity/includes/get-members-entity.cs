using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Create an Instance of the Selection Entity
  Selection newSelection = Selection.GetFromIdxSelectionId(58);

  // Looping through the Selection Member property to retrieve the Selected members
  foreach (SelectionMemberRow selMem in newSelection.SelectionMembers)
  {
    //retrieve the Contact information for a given Contact_id
    ContactRow newConRow = ContactRow.GetFromIdxContactId(selMem.ContactId);
    int selMemSelId = selMem.SelectionId;
    int selMemConId = selMem.ContactId;
    string selMemName = newConRow.Name;
    string selMemNameDept = newConRow.NameDepartment;

    //Creating the output
    Console.Write("SelectionId" + "\t" + "ContactId" + "\t" + "Name" + "\t" + "NameDepartment");
    Console.WriteLine();
    Console.Write(selMemSelId + "\t");
    Console.Write(selMemConId + "\t");
    Console.Write(selMemName + "\t");
    Console.Write(selMemNameDept + "\t");
    Console.WriteLine();
  }
}