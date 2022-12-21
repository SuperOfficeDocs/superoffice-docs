using SuperOffice;
using SuperOffice.CRM.ArchiveLists;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  SuperOffice.CRM.ArchiveLists.IArchiveProvider personArchive = new PersonProvider();

  //Get the list of columns handled by this provider
  List<ArchiveColumnInfo> availableColumns = personArchive.GetAvailableColumns();

  //Get the list of Entities supported by this provider
  List<ArchiveEntityInfo> availableEntities = personArchiveGetAvailableEntities();

  //Display the list of column names and entity names in two list boxes
  foreach (ArchiveColumnInfo columninfo in availableColumns)
  {
    FieldsListBox.Items.Add(columninfo.Name);
  }
  foreach (ArchiveEntityInfo entityinfo in availableEntities)
  {
    entitiesListBox.Items.Add(entityinfo.Name);
  }

  //Set the columns that needs to be returned
  personArchive.SetDesiredColumns("personId", "fullName","personUdef:SuperOffice:6", "personUdef:SuperOffice:1");

  //set the paging properties of the provider.
  personArchive.SetPagingInfo(10, 0);
  personArchive.SetOrderBy(new ArchiveOrderByInfo("contactId", SuperOfficeUtil.OrderBySortType.DESC),
  new ArchiveOrderByInfo("personUdef:SuperOffice:6", SuperOffice.UtilOrderBySortType.ASC));

  //An array of restrictions with an implicit and in between them.
  personArchive.SetRestriction(new ArchiveRestrictionInfo("personId", ">","50"),
  new ArchiveRestrictionInfo("personUdef:SuperOffice:6", "=", "1"));

  //Display the retrieved data in another list box
  int rowNo = 1;
  foreach (ArchiveRow row in personArchive.GetRows())
  {
    if (rowNo == 1)
    {
      foreach (KeyValuePair<string, ArchiveColumnData>column inrowColumnData)
      {
        resultsListbox.Items.Add(column.Key);
      }
    }
    foreach (KeyValuePair<string, ArchiveColumnData> column inrowColumnData)
    {
      resultsListbox.Items.Add(column.Value.ToString());
    }
    ++rowNo;
  }
}