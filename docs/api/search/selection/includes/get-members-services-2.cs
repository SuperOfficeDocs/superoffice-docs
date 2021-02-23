using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Intializing an Archive Agent
  using(ArchiveAgent newArcAgt = new ArchiveAgent())
  {
    //Setting the Parameters

    //Parameter - Required columns
    string[] archiveColumns = new string[] { "contactId", "personId", "selectionId" };

    //Parameter - restriction - Archive restrictions
    ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[1];
    archiveRest[0] = new ArchiveRestrictionInfo("selectionId", "=", 58);

    //Parameter - page - Page number, page 0 is the first page
    int page = 0;

    //Parameter - pageSize – Number of records displayed per page
    int pageSize = 10;

    // Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns
    ArchiveListItem[] arcLstItm = newArcAgt.GetArchiveListByColumns( "ContactSelection", archiveColumns, new ArchiveOrderByInfo[0],  archiveRest, null, page, pageSize);

    int rowNo = 1;
    //Display the results in the console window
    foreach (ArchiveListItem archiveRow in arcLstItm)
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
        if (archiveCell != null)
        {
          Console.Write(archiveCell.DisplayValue + "\t");
        }
        else
        {
          Console.Write(" " + "\t");
        }
      }
      Console.WriteLine();
      ++rowNo;
    }
  }
}