// specify the name and instantiate the archive provider
IArchiveProvider provider = ArchiveProviderFactory.Create("FindSale");

// set the desired fields
provider.SetDesiredColumns("saleId", "heading");

// set the desired entities
provider.SetDesiredEntities("sale");

// set the paging information
provider.SetPagingInfo(50, 0);

// specify and set the criteria restriction
provider.SetRestriction(new ArchiveRestrictionInfo("projectId", "=", "47"));

// execute the query and iterate over the results
foreach (ArchiveRow row in provider.GetRows(""))
{
  int saleId = (int)row.ColumnData["saleId"].RawValue;
  string heading =  row.ColumnData["heading"].RawValue.ToString();
  Console.WriteLine("SaleId {0}, Heading {1}", saleId, heading);
}

// remember to close the provider to release resources
provider.Close();