using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a find agent
  using(FindAgent findAgent = new FindAgent())
  {
    //create a ArchiveRestrictionInfo array
    ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[1];

    //set the properties here the name is the restriction that we are
    //going to filter the contacts
    restrictions[0] = new ArchiveRestrictionInfo("NumberOfActivities", "equals", "2");            
    ArchiveRestrictionInfo activityType = new ArchiveRestrictionInfo("SaintActivityType", "=", "-1");
    ArchiveRestrictionInfo activityDir = new ArchiveRestrictionInfo("SaintDirection", "=", "-1");
    ArchiveRestrictionInfo activityIntent = new ArchiveRestrictionInfo("SaintIntention", "=", "-1");
    restrictions[0].AddSubRestriction(activityType);
    restrictions[0].AddSubRestriction(activityDir);
    restrictions[0].AddSubRestriction(activityIntent);

    //using FindFromRestrictions method of the find agent retrive the contacts that match our restriction
    FindResults findResults = findAgent.FindFromRestrictions(restrictions, FindContactProvider.ProviderName, 200, 0);

    //now that we have got the results lets show it in the console
    ArchiveListItem[] resultRows = findResults.ArchiveRows;
    int rowNo = 1;
    foreach (ArchiveListItem listData in resultRows)
    {
      if (rowNo == 1)
      {
        foreach (KeyValuePair<string, ArchiveColumnData> column in listData.ColumnData)
        {
          if (rowNo == 1)
          {
            Console.Write(column.Key + "\t");
          }
          Console.WriteLine();
        }

        foreach (ArchiveColumnData data in listData.ColumnData.Values)
        {
          Console.Write(data != null && data.DisplayValue != null ? data.DisplayValue + "\t" : "-");
        }
        Console.WriteLine();
        ++rowNo;
      }
    }
  }
}