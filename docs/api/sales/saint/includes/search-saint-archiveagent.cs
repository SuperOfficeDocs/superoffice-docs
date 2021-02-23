using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  // Retrieve an archive agent
  using(ArchiveAgent agent = new ArchiveAgent())
  {
    // Set the desired columns
    string[] columns = {"contactId","name", "department"};

    // Set the provider as FindContactProvider
    string provider = FindContactProvider.ProviderName;

    // Set the restriction
    ArchiveRestrictionInfo[] restriction = new ArchiveRestrictionInfo[1];
    restriction[0] = new ArchiveRestrictionInfo("saintstatus1", "set", "true");
    ArchiveListItem[] arcLstItm = agent.GetArchiveListByColumns(provider, columns, new ArchiveOrderByInfo[0], restriction, null, 0, 10);

    // extract and display the displayValue of each cell
    // (you need to parse culturally sensitive values such as dates to get the correct client display format)
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