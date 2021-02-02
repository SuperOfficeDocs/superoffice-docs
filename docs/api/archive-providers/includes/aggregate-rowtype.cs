var provider = ArchiveProviderFactory.Create(PersonProvider.ProviderName);

provider.SetDesiredColumns(
 "firstName",
 "middleName",
 "lastName",
 "rank",
 "Sum(rank)",
 "CountAll(firstName)",
 "GroupBy(middleName):Header,Footer"
);

provider.SetDesiredEntities("person");
provider.SetPagingInfo(100, 0);
provider.SetRestriction(new ArchiveRestrictionInfo("contactId", "=", CultureDataFormatter.Encode(24)));


foreach (var row in provider.GetRows(string.Empty))
{
  //parse the results.
}