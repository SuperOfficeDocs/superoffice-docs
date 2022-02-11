var provider = ArchiveProviderFactory.Create(PersonProvider.ProviderName);
provider.SetDesiredColumns("firstName",
 "CountAll(firstName)",
 "Count(middleName)",
 "Sum(rank):HideDetail",
 "GroupBy(middleName):Header,Footer,1",
 "GroupBy(lastName):Header,Footer,2");
provider.SetDesiredEntities("person");
provider.SetPagingInfo(100, 0);
provider.SetRestriction(new ArchiveRestrictionInfo("contactId", "=", CultureDataFormatter.Encode(24)));

foreach (var row in provider.GetRows(AggregationProvider2.GrandTotalOption + "=true"))
{
  // ...
}