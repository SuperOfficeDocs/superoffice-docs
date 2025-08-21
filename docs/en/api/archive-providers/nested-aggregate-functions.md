---
title: Nested aggregate functions
uid: nested_aggregate_functions
description: Examples of nested aggregate functions for archive providers.
author: Tony Yates
date: 11.17.2017
keywords: aggregate function
content_type: howto
category: api
topic: archive providers
redirect_from: /en/api/netserver/archive-providers/nested-aggregate-functions
---

# Nested aggregate functions

Functions can contain functions, so it’s possible to pass the result of one aggregate function to another aggregate function for compound operations. For example, with regards to a sale amount, first weigh the amount and then converted to a specific currency using:

`CurrencyConvert(Weighted(amount;probPercent);currencyId))`

## Scenario 1

To demonstrate the concept, construct a query that displays the top sales representatives this month. Do this by specifying a restriction where the `userGroup` equals the sales group, the `saleStatus` is sold, and the sale date is within the past month. Sort the results by the sum of the sale amount, descending. Then add the following aggregate functions to display the results in a footer - one for each distinct group:

* using `Sum` and `ConvertCurrency`, convert all sale amounts to one currency and then sum the amounts.
* use `GroupBy` to divide the results by full name, personId, and title.

```csharp
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
```

> [!NOTE]
> The `CultureDataFormatter` method is used to format the summed amount into local currency in both the footer and grandtotal rows.

### Query results

| Rowno | Row type | GroupBy (associate/fullName): Footer,HideDetail | GroupBy (associate/personId): Footer,HideDetail | GroupBy (associate/title): Footer,HideDetail | Sum (CurrencyConvert (amount;36)): HideDetail |
|---|---|---|---|---|---|
| 0 (1) | \[footer:1\] | Rebecca Franklin | 9| Sales Representative | 1 480 110,00 |
| 1 (2) | \[footer:1\] | Sean Baker | 8 | Tech and Sales | 152 495,00 |
| 2 (1) | \[grandtotal\] | | | | 1 632 605,00 |

## Scenario 2

Another common scenario to demonstrate nested functions is to group sales based on a `DatePart`. Combined with a `GroupBy`, the use of `DatePart` makes it easy to aggregate sales by week, month, or quarter.

Use the previous example as a template and modify the restriction sale date to show just this year. Modify the `Sort` to use the `GroupBy DatePart, ascending`. Then change the desired columns to just include the `Sum` of sale amounts and a `GroupBy` to divide the results by months.

```csharp
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
  new ArchiveRestrictionInfo("userGroup", "oneOf", SuperOffice.SoContext.CurrentPrincipal.GroupId),
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
```

| Rowno | Row type | GroupBy(DatePart(date):Month) :Footer,HideDetail | Sum(CurrencyConvert(amount;36)) :HideDetail |
|---|---|---|---|
| 0 (1) | \[footer:1\] | January | 123 123,00 |
| 1 (2) | \[footer:1\] | February | 450 987,00 |
| 2 (3) | \[footer:1\] | March | 1 123 123,00 |
| 3 (4) | \[footer:1\] | April | 750 009,00 |
| 4 (5) | \[footer:1\] | May | 321 244,99 |
| 5 (6) | \[footer:1\] | June | 2 334 854,00 |
| 6 (7) | \[footer:1\] | July | 1 875 987,00 |
| 7 (8) | \[footer:1\] | August | 890 000,00 |
| 8 (9) | \[footer:1\] | September | 1 432 423,00 |
| 9 (10) | \[footer:1\] | October | 987 798,00 |
| 10 (11) | \[footer:1\] | November | 123 654,00 |
