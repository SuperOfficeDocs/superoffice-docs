using SuperOffice;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Rows;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  // Create an instance of the FindContactProvider
  FindContactProvider myProvider = new FindContactProvider();

// Select the return fields
  myProvider.SetDesiredColumns("contactId");

  // Set restrictions
  myProvider.SetRestriction(new ArchiveRestrictionInfo("saintSaleStatus", "=", "2"));

  //Display the retrieved data on the console
  int rowNo = 1;
  foreach (ArchiveRow row in myProvider.GetRows())
  {
    if (rowNo == 1)
    {
      Console.Write("RowNo\t");
      foreach (KeyValuePair<string, ArchiveColumnData> column in row.ColumnData)
        Console.Write(column.Key + "\t");
      Console.WriteLine();
    }
    Console.Write(rowNo.ToString() + ": " + row.EntityName + "/" + row.PrimaryKey.ToString() + "s:" + row.StyleHint + " l:" + row.LinkHint + "\t");
    foreach (KeyValuePair<string, ArchiveColumnData> column in row.ColumnData)
    {
      string displayValue = column.Value != null ? column.Value.ToString() : "-";
      Console.Write(displayValue + "\t");
    }
    Console.WriteLine();
    ++rowNo;
  }
  myProvider.Close();
}