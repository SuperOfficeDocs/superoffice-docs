using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{

  //Create an instance of the CustomSearch class
  ContactRows.CustomSearch myRows = new ContactRows.CustomSearch();

  //Get instances of ContactTableInfo and CounterValueTableInfo
  ContactTableInfo nweConTbl = TablesInfo.GetContactTableInfo();
  CounterValueTableInfo cvTable = TablesInfo.GetCounterValueTableInfo();

  //Join the contact table with with countervalue table
  myRows.JoinRestriction.InnerJoin(nweConTbl.ContactId.Equal(cvTable.ContactId));

  //Set Restrictions so that sale_status = 2 and amountClassId = 0 and totalReg > 2
  myRows.Restriction = cvTable.SaleStatus.Equal(S.Parameter(2)).
  And(cvTable.AmountClassId.Equal(S.Parameter(0))).
  And(cvTable.TotalReg.GreaterThan(S.Parameter((uint)2)));

  //Set IsDistinct property True to remove duplicates
  myRows.IsDistinct = true;
  ContactRows newRows = ContactRows.GetFromCustomSearch(myRows);

  //Display the returned rows
  foreach (ContactRow myRow in newRows)
  {
    listBox1.Items.Add(myRow.Name);
  }
}