IArchiveProvider provider = ArchiveProviderFactory.Create("FindSale");
provider.SetDesiredColumns("Count(saleId)", "saleId", "heading");
provider.SetDesiredEntities("sale");
provider.SetPagingInfo(50, 0);
ArchiveRestrictionInfo[] restrictions = {
  new ArchiveRestrictionInfo("projectId", "=", "47")
};
provider.SetRestriction(restrictions);
foreach (ArchiveRow row in provider.GetRows(""))
{
  int count = (int)row.ColumnData["Count(saleId)"].RawValue;
  int saleId = (int)row.ColumnData["saleId"].RawValue;
  string heading = row.ColumnData["heading"].RawValue.ToString();
  Debug.WriteLine("{0}) SaleId: {1}, Heading: {2}",count,saleId,heading);
}

// remember to close the provider to release resources
provider.Close();