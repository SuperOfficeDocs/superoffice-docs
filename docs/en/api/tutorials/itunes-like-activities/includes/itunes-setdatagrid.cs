using System.Collections;
using System.Collections.Specialized;
using SuperOffice.CRM.Services;
using SuperOffice;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Archives;
using SuperOffice.CRM.Globalization;
private void setDataGrid()
{
  // ------------------------------------------------------------------
  // Section 1 : Retrieve Activity information
  // ------------------------------------------------------------------

  // Setting the Parameters that need to be passed to the Agent method and retrieve activity information

  // Parameter - providerName - The name of the archive provider
  string providerName = ActivityArchiveProvider.ProviderName;

  //Parameter - columns - An array of the names of the columns wanted.
  string[] columns = new string[] { "date", "saleId", "appointmentId", "documentId", "sale/description", "appointment/description", "document/description", "project/name" };

  //Parameter - restriction - Archive restrictions
  DateTime to = DateTime.Now;
  DateTime from = to.AddMonths(-6);
  ArchiveRestrictionInfo date = new ArchiveRestrictionInfo("date", "Between", CultureDataFormatter.EncodeDate(from), CultureDataFormatter.EncodeDate(to));
  ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[1];
  restrictions[0] = date;

  //Parameter - sortOrder - Sort order for the archive
  ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
  archiveSrtOrd[0] = new ArchiveOrderByInfo("date", SuperOffice.Util.OrderBySortType.DESC);

  //Parameter - entities – which entities to be included
  string[] entities = new string[] { "document", "appointment", "sale" };

  //Parameter - page - Page number, page 0 is the first page
  //Parameter - pageSize - Page size 
  int page = 0;
  int pageSize = 500;

  // Create an ArchiveAgent object
  ArchiveAgent newActivity = AgentFactory.GetArchiveAgent();

  // Call the get ‘GetArchiveListByColumns’ method to retrieve the specified records
  ArchiveListItem[] activitytItems = newActivity.GetArchiveListByColumns(providerName, columns, archiveSrtOrd, restrictions, entities, page, pageSize);

  // ------------------------------------------------------------------
  // Section 2 : Convert activity information into ActivityData objects
  // ------------------------------------------------------------------

  ActivityData[] activityDataCollection = new ActivityData[activitytItems.Length];
  int count = 0;

  // iterate through the retrieved ArchiveListItems and create ActivityData objects
  foreach (ArchiveListItem item in activitytItems)
  {
    ListDictionary lstActivityInfo = new ListDictionary();

    // retrieve the column names and the data values for each ArchiveListItem and store in the ListDictionary
    foreach (KeyValuePair<string, ArchiveColumnData> column in item.ColumnData)
    {
      string displayValue = column.Value != null ? column.Value.DisplayValue.ToString() : "-";
      string key = column.Key;
      lstActivityInfo.Add(key, displayValue);
    }

    // check the Entity type and create the ActivityData object with the data extracted from the ArchiveListItem and store in the ActivityData array
    // activity type : Sale
    if (item.EntityName == "sale")
    {
      string saleId = lstActivityInfo["saleId"].ToString();
      // create an ActivityData object of type ‘Sale’
      ActivityData appData = new ActivityData(item.EntityName, saleId.Substring(1, saleId.Length - 2), lstActivityInfo["sale/description"].ToString(), lstActivityInfo["date"].ToString(), lstActivityInfo["project/name"].ToString());
      activityDataCollection[count] = appData;
    }
    // activity type : Appointment
    if (item.EntityName == "appointment") 
    {
      string appointmentId = lstActivityInfo["appointmentId"].ToString();

      // create an ActivityData object of type ‘Appointment’
      ActivityData appData = new ActivityData(item.EntityName, appointmentId.Substring(1, appointmentId.Length - 2), lstActivityInfo["appointment/description"].ToString(), lstActivityInfo["date"].ToString(), lstActivityInfo["project/name"].ToString());
      activityDataCollection[count] = appData;
    }

    // activity type : Document
    if (item.EntityName == "document")
    {
      string docummentId = lstActivityInfo["documentId"].ToString();

      // create an ActivityData object of type ‘Document’
      ActivityData appData = new ActivityData(item.EntityName, docummentId.Substring(1, docummentId.Length - 2), lstActivityInfo["document/description"].ToString(), lstActivityInfo["date"].ToString(), lstActivityInfo["project/name"].ToString());
      activityDataCollection[count] = appData;
    }

    count++;
    lstActivityInfo.Clear();
  }

  // set the array as the data source for the data grid
  this.grdActivityData.DataSource = activityDataCollection;
  }