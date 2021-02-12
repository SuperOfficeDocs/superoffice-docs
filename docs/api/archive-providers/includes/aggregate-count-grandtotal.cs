IArchiveProvider provider = ArchiveProviderFactory.Create("FindSale");
provider.SetDesiredColumns("Count(saleId):HideDetail", "saleId", "heading");
provider.SetDesiredEntities("sale");
provider.SetPagingInfo(50, 0);
ArchiveRestrictionInfo[] restrictions = {
  new ArchiveRestrictionInfo("projectId", "=", "47")
};
provider.SetRestriction(restrictions);
foreach (ArchiveRow row in provider.GetRows("GrandTotal=True"))
{
  if(row.RowType == "grandtotal")
  {
    int count = (int)row.ColumnData["Count(saleId):HideDetail"].RawValue;
    Debug.WriteLine("Total Project 47 Sales: {0}", count);
  }
  else
  {
    int saleId = (int)row.ColumnData["saleId"].RawValue;
    string heading = row.ColumnData["heading"].RawValue.ToString();
    Debug.WriteLine("SaleId: {0}, Heading: {1}", saleId, heading);
  }
}

// remember to close the provider to release resources
provider.Close();