var currency = SuperOffice.CRM.Rows.Util.CurrencyConversionHelper.BaseCurrencyId;

// set the formatted function for use in multiple places below
var formattedSum = string.Format("Sum(CurrencyConvert(amount;{0})):HideDetail", currency);

// use selection provider to get all my completed activities this month
var provider = ArchiveProviderFactory.Create("saledynamicselection");

// Set the aggregate functions to get how many sales, grouped by Month
provider.SetDesiredColumns(formattedSum, "GroupBy(DatePart(date):Month):Footer,HideDetail");
provider.SetDesiredEntities("sale");
provider.SetPagingInfo(100, 0);

// specify the restrictions
provider.SetRestriction(
  new ArchiveRestrictionInfo("userGroup", "oneOf", SuperOffice.SoContext.CurrentPrincipal.GroupId,
  new ArchiveRestrictionInfo("saleStatus", "oneOf", "2"),
  new ArchiveRestrictionInfo("date", "thisYear"),
  new ArchiveRestrictionInfo("selectionId", "=", "-1")
  );

// set the sort by to the month ascending
provider.SetOrderBy(
  new ArchiveOrderByInfo("GroupBy(DatePart(date):Month):Footer,HideDetail",
  SuperOffice.Data.OrderBySortType.ASC)
);

using (ArchiveRowDumper d = new ArchiveRowDumper(provider))
{
  foreach (var row in provider.GetRows(AggregationProvider2.GrandTotalOption + "=True"))
  {
    if (row.RowType.StartsWith("footer"))
    {
      // get the month and sale sum data
      var monthInt = (int)row.ColumnData["GroupBy(DatePart(date):Month):Footer,HideDetail"].RawValue;
      var foSum = row.ColumnData[formattedSum].DisplayValue;

      // convert the integer representation of month to month name
      var monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthInt);
      Debug.WriteLine("Month: {0}, Sum: {1}", monthName, foSum);
    }
    else if (row.RowType.StartsWith("grandtotal"))
    {
      // get out the total sum value
      var grandTotalSum = row.ColumnData[formattedSum].DisplayValue;
      Debug.WriteLine("Grand Total: {0}", CultureDataFormatter.LocalizeEncoded((grandTotalSum)));
    }
    d.DumpRow(row);
  }
}