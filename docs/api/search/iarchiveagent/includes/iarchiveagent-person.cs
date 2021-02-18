using System.Collections;

using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;

using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Setting the Parameters that need to be passed to Agent method 
  //Parameter - providerName - The name of the archive provider to use
  string archiveProviderName = "person";

  //Parameter - columns - An array of the names of the columns wanted.
  string[] archiveColumns = new string[] { "fullName", "firstName", "personNumber", "position", "academic", "personId", "contactId" };

  //Parameter - sortOrder - Sort order for the archive
  ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
  archiveSrtOrd[0] = new ArchiveOrderByInfo("personNumber", SuperOffice.Util.OrderBySortType.DESC);

  //Parameter - restriction - Archive restrictions
  ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[1];
  archiveRest[0] = new ArchiveRestrictionInfo("contactid", "=", "2");

  //Parameter - entities - Which entities to include
  string[] desiredEntities = { "person", "retiredPerson" };

  //Parameter - page - Page number, page 0 is the first page
  int page = 1;

  //Parameter - pageSize - Page size
  int pageSize = 10;

  //Initializing an Archive Agent
  using(ArchiveAgent newArcAgt = new ArchiveAgent())
  {
    //Get a page of results for an archive list, explicitly specifying the restrictions, orderby, and chosen columns
    ArchiveListItem[] arcLstItm = newArcAgt.GetArchiveListByColumns(archiveProviderName, archiveColumns, archiveSrtOrd, archiveRest, desiredEntities, page, pageSize);

    int rowNo = 1;

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

      // extract and display the displayValue of each cell (you need to parse culturally sensitive values such as dates
      // to get the correct client display format)
      foreach (ArchiveColumnData archiveCell in archiveRow.ColumnData.Values)
      {
          Console.Write(archiveCell.DisplayValue + "\t");
      }
      Console.WriteLine();
      ++rowNo;
    }
  }
}