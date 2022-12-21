using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Archives;
using(SuperOffice.SoSession mySession =
SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Instantiating a Selection Provider
  IArchiveProvider selPro = new SelectionProvider();

  //Setting the order of the Returned rows
  selPro.SetOrderBy(new ArchiveOrderByInfo("contactId", SuperOffice.Util.OrderBySortType.DESC));

  //Selecting the Columns that should be displayed
  selPro.SetDesiredColumns("selectionId", "contactId", "name", "nameDepartment");

  //Setting the paging properties of the window
  selPro.SetPagingInfo(100, 0);

  //Setting the query restrictions
  selPro.SetRestriction(new ArchiveRestrictionInfo("selectionId", "=", "58"));

  //Retrieving the Rows returned by the Provider
  int rowNo = 1;
  foreach (ArchiveRow row in selPro.GetRows())
  {
    if (rowNo == 1)
    {
      Console.Write("RowNo\t");
      foreach (KeyValuePair<string, ArchiveColumnData> column in row.ColumnData)
      {
        Console.Write(column.Key + "\t");
      }
      Console.WriteLine();
    }

    Console.Write(rowNo.ToString() + ": " + row.EntityName + "/" + row.PrimaryKey.ToString() 
      + "s:" + row.StyleHint + " l:" + row.LinkHint + "\t");

    foreach (KeyValuePair<string, ArchiveColumnData> column in row.ColumnData)
    {
      string displayValue = column.Value != null ? column.Value.ToString() : "-";
      Console.Write(displayValue + "\t");
    }
    Console.WriteLine();
    ++rowNo;
  }
  selPro.Close();
}