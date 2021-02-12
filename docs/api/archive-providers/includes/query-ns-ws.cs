// Instantiate the FindAgent web service proxy class
using (FindAgent fa = new FindAgent())
{
  // specify the archive provider name
  string providerName = "FindSale";

  // set the desired fields
  string[] columns = { "saleId", "heading", "projectId" };

  // specify the criteria restriction
  ArchiveRestrictionInfo[] restrictions =
  {
    new ArchiveRestrictionInfo()
    {
      Name = "projectId",
      Operator = "=",
      Values = new [] {"47"},
      IsActive = true
    }
  };

  // execute the query and get the results
  var results = fa.FindFromRestrictionsColumns(restrictions, providerName, columns, 50, 0);

  // ensure there are results and iterate over the them
  if ( results != null && results.ArchiveRows != null && results.ArchiveRows.Length > 0 )
  {
    foreach (var row in results.ArchiveRows)
    {
      var saleId = row.ColumnData["saleId"].DisplayValue;
      var heading = row.ColumnData["heading"].DisplayValue;
      Console.WriteLine("SaleId {0}, Heading {1}",
          SuperOffice.CRM.Globalization.CultureDataFormatter.
          ParseEncodedInt(saleId).ToString(),
          heading.ToString());
    }
  }
}