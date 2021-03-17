using System.Collections;

using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;

using (SuperOffice.SoSession mySession = SuperOffice.SoSession.Authenticate("sam", "sam"))
{
  //Parameter - providerName - The name of the archive provider to use
  string archiveProviderName = "ContactSelection";

  //Parameter - columns - An array of the names of the columns wanted.
  string[] archiveColumns = new string[] { "nameDepartment", "fullName", "contactId" };

  //Parameter - sortOrder - Sort order for the archive
  ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
  archiveSrtOrd[0] = new ArchiveOrderByInfo( "fullName", SuperOffice.Util.OrderBySortType.DESC );

  //Parameter - restriction - Archive restrictions
  ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[1];
  archiveRest[0] = new ArchiveRestrictionInfo("selectionId", "=", 58);

  //Parameter - entities - Which entities to include
  string[] desiredEntities = { "staticContact", "staticPerson", "dynamicContact" };

  //Parameter - page - Page number, page 0 is the first page
  int page = 1;

  //Parameter - pageSize - Page size
  int pageSize = 10;

  //Intializing an Archive Agent
  using(ArchiveAgent newArcAgt = new ArchiveAgent())
  {
    // Get a page of results for an archive list, explicitly specifying 
    // the restrictions, orderby and chosen columns
    ArchiveListItem[] newArcLstItm = newArcAgt.GetArchiveListByColumns(archiveProviderName, 
        archiveColumns, archiveSrtOrd, archiveRest, desiredEntities, page, pageSize);

    int rowNo = 1;

    foreach (ArchiveListItem archiveRow in newArcLstItm)
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
      // (you need to parse culturally sensitive values such as dates
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