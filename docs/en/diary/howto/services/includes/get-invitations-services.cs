using SuperOffice;
using SuperOffice.CRM.ArchiveLists;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Create an instance of the InvitationProvider
  IArchiveProvider newInvPro = new InvitationProvider();

  //Set the order by rule for the Provider
  newInvPro.SetOrderBy(new ArchiveOrderByInfo("appointmentId", SuperOffice.Util.OrderBySortType.DESC));

  //Set the columns we want to retrive
  newInvPro.SetDesiredColumns("appointmentId", "date", "associate/contactFullName", "endDate" );

  //Set the page size
  newInvPro.SetPagingInfo(100, 0);

  //Add the restriction the provider should be based on
  newInvPro.SetRestriction( 
    new ArchiveRestrictionInfo("associateId", "=", "5"),
    new ArchiveRestrictionInfo("date",">",DateTime.Today.ToString()));

  //Looping through the provider in order to get the results we are going out of the loop
  int rowNo = 1;
  foreach (ArchiveRow archiveRow in newInvPro.GetRows())
  {
    if (rowNo == 1)
    {
      foreach (KeyValuePair<string, ArchiveColumnData> column in archiveRow.ColumnData)
      {
        Console.Write(column.Key + "\t");
      }
      Console.WriteLine();
    }
    // extract and display the displayValue of each cell
    // (you need to parse culturally sensitive values such as dates to get the correct client display format)
    foreach (ArchiveColumnData archiveCell in archiveRow.ColumnData.Values)
    {
      Console.Write(archiveCell.DisplayValue + "\t");
    }
    Console.WriteLine();
    ++rowNo;
  }
}