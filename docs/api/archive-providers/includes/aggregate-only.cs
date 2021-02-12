// use selection provider to get all my completed activities this month
var provider = ArchiveProviderFactory.Create("appointmentdynamicselection");

// Set the aggregate functions to get how many of each, grouped by type
provider.SetDesiredColumns(
 "Count(appointmentId):HideDetail",
 "GroupBy(type):Footer,HideDetail"
 );
provider.SetDesiredEntities("appointment");
provider.SetPagingInfo(100, 0);

// specify the restrictions
provider.SetRestriction(
 new ArchiveRestrictionInfo("endDate", ">", CultureDataFormatter.EncodeDate(DateTime.Now.AddMonths(-1))),
 new ArchiveRestrictionInfo("associateId", "currentAssociate", ""),
 new ArchiveRestrictionInfo("completed", "set", "1"),
 new ArchiveRestrictionInfo("selectionId", "=", "-1")
 );

// fetch the rows
foreach (var row in provider.GetRows(""))
{
  var activityType = row.ColumnData["GroupBy(type):Footer,HideDetail"].RawValue.ToString();
  var activityCount = (int)row.ColumnData["Count(appointmentId):HideDetail"].RawValue;
}