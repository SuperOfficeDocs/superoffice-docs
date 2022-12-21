// get a currencyId to convert sale amount to.
var currency = SuperOffice.CRM.Rows.Util.CurrencyConversionHelper.BaseCurrencyId;

// set the formatted function for use in multiple places below
var formattedSum = string.Format("Sum(CurrencyConvert(amount;{0})):HideDetail", currency);

// use selection provider to get all my completed activities this month
var provider = ArchiveProviderFactory.Create("saledynamicselection");
provider.SetDesiredEntities("sale");
provider.SetPagingInfo(100, 0);

// specify the sort order
provider.SetOrderBy( new ArchiveOrderByInfo( formattedSum, SuperOffice.Data.OrderBySortType.DESC));

// Set the aggregate functions to get how many of each, grouped by type
provider.SetDesiredColumns(
  formattedSum,
  "GroupBy(associate/fullName):Footer,HideDetail", //default level 1, no nesting
  "GroupBy(associate/personId):Footer,HideDetail", //default level 1, no nesting
  "GroupBy(associate/title):Footer,HideDetail"     //default level 1, no nesting
  );

// specify the restrictions
provider.SetRestriction(
  new ArchiveRestrictionInfo("userGroup", "oneOf", SuperOffice.SoContext.CurrentPrincipal.GroupId),
  new ArchiveRestrictionInfo("saleStatus", "oneOf", "2"),
  new ArchiveRestrictionInfo("date", ">", CultureDataFormatter.EncodeDate(DateTime.Now.AddMonths(-1))),
  new ArchiveRestrictionInfo("selectionId", "=", "-1")
  );

  foreach (var row in provider.GetRows(AggregationProvider2.GrandTotalOption + "=True"))
  {
    if(row.RowType.StartsWith("footer"))
    {
      var fullName = row.ColumnData["GroupBy(associate/fullName):Footer,HideDetail"].DisplayValue;
      var personId = row.ColumnData["GroupBy(associate/personId):Footer,HideDetail"].DisplayValue;
      var perTitle = row.ColumnData["GroupBy(associate/title):Footer,HideDetail"].DisplayValue;
      var persoSum = row.ColumnData[formattedSum].DisplayValue;
      Console.WriteLine("Fullname: {0}, PersonId: {1}, Title: {2}, Sum: {3}",
        fullName, personId, perTitle, CultureDataFormatter.LocalizeEncoded(persoSum));
    }
    else if(row.RowType.StartsWith("grandtotal"))
    {
      var grandTotalSum = row.ColumnData[formattedSum].DisplayValue;
      Console.WriteLine("Grand Total: {0}", CultureDataFormatter.LocalizeEncoded(grandTotalSum));
    }
  }
}