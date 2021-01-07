---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: nested_aggregate_functions       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Nested aggregate functions

Functions can contain functions, so it’s possible to pass the result of one aggregate function to another aggregate function for compound operations. For example, with regards to a sale amount, first weight the amount and then converted to a specific currency using:

`CurrencyConvert(Weighted(amount;probPercent);currencyId))`

## Scenario 1

To demonstrate the concept, construct a query that displays the top sales representatives this month. Do this by specifying a restriction where the `userGroup` equals the sales group, the `saleStatus` is sold, and the sale date is within the past month. Sort the results by the sum of the sale amount, descending. Then add the following aggregate functions to display the results in a footer - one for each distinct group:

* using `Sum` and `ConvertCurrency`, convert all sale amounts to one currency and then sum the amounts.
* use `GroupBy` to divide the results by full name, personId, and title.

[!code-csharp[scenario 1](includes/nested-aggregate-1.cs)]

> [!NOTE]
> The use of `CultureDataFormatter` to format the summed amount into local currency in both the footer and grandtotal rows.

### Query results

| Rowno | Row type | GroupBy (associate/fullName): Footer,HideDetail | GroupBy (associate/personId): Footer,HideDetail | GroupBy (associate/title): Footer,HideDetail | Sum (CurrencyConvert (amount;36)): HideDetail |
|---|---|---|---|---|---|
| 0 (1) | \[footer:1\] | Rebecca Franklin | 9| Sales Representative | 1 480 110,00 |
| 1 (2) | \[footer:1\] | Sean Baker | 8 | Tech and Sales | 152 495,00 |
| 2 (1) | \[grandtotal\] | | | | 1 632 605,00 |

## Scenario 2

Another common scenario to demonstrate nested functions is to group sales based on a `DatePart`. Combined with a `GroupBy`, the use of `DatePart` makes it easy to aggregate sales by week, month, or quarter.

Use the previous example as a template and modify the restriction sale date to show just this year. Modify the `Sort` to use the `GroupBy DatePart, ascending`. Then change the desired columns to just include the `Sum` of sale amounts and a `GroupBy` to divide the results by months.

[!code-csharp[scenario 2](includes/nested-aggregate-2.cs)]

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
