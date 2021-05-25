---
title: Data aggregation
uid: data_aggregation
description: Data aggregation
author: Tony Yates
so.date: 11.17.2017.
keywords:
so.topic: concept
# so.envir:
# so.client:
---

# Data aggregation

In addition to specifying desired column names, providers accept aggregate functions as column parameters. These are called and referred to as aggregate columns.

Aggregate columns are extremely useful when the results need to be transformed in a structured way. Aggregate columns can also nest other aggregate functions.

## Aggregate functions

| Function | Description | Example |
|---|---|---|
| Avg | Average of all values. | Avg(amount) |
| Count | Count unique values | Count(saleId) |
| CountAll | Count all values, even duplicates | CountAll(appointmentId) |
| CurrencyConvert | Convert numbers in amountcol (in currency set by currencycol to the Base currency, user's Own currency, or don’t convert) | CurrencyConvert(amountcol;currencycol):Base or Own or None |
| DatePart | DateModifiers:<br>Year, Quarter, Month, Day, DayOfYear<br>simple numbers<br>ISODate, ISODateHour : formatted strings<br>DayOfWeek, DayOfWeekFromMonday, Weekno, YearWeekno, YearWeekAsISODate : week functions<br>YearQuarter, YearMonth : string: number/number | DatePart(date):YearMonth |
| Expression | Expects two or more fields, only supports Multiply modifier. | Expression(amount;probabilityPercent):Multiply |
| GroupBy | Controls processing and is independent of query OrderBy | GroupBy(stage) |
| Median | Returns the middle number (integer or double) | Median(quantity) |
| Percent | Returns a percentage of the accumulated value of a field. (integer or double) | Percent(progProbability) |
| Sum | Total accumulated amount of a field. (integer or double) | Sum(quantity) |
| Weighted | Multiply numbers in amountcol by the percentage in the weightcol | Weighted(amountcol;weightcol) |

Data transformations can be as simple as returning a running count of a column, or as complex as including nested groups; with the use of multiple GroupBy functions. The default output of every archive provider are rows that include the specified detail columns.

## Default row output

Detail Row => \| Column1 \| Column2 \| Column3 \| Column4

However, hidden as an option is the GrandTotal row. GrandTotal is a reserved placeholder for returning aggregate results, such as a total count or total sum.

When specified in a provider's GetRows method, i.e. `provider.GetRows("GrandTotal=True")`, the grand total row is output as the very last row. This is useful to display the results of one or more aggregate columns.

## Default row output with GrandTotal

Detail Row1 => \| Column1 \| Column2 \| Column3 \| Column4<br>
Detail Row2 => \| Column1 \| Column2 \| Column3 \| Column4<br>
*GrandTotal Row* => \| Function1 \| Function2

## Aggregate function modifiers

**Function modifiers** are used to set the behavior or output of an aggregate function. An aggregate function can include one or more modifiers, and the format is as follows:

`FunctionName(columnName)[:Modifer[,Modifier]...]`

| Modifier | Description | Used by |
|---|---|---|
| HideDetail | Removes running value in the detail rows | All Functions |
| Base | Use the base currency | ConvertCurrency |
| Own | Use the associate's set currency | ConvertCurrency |
| None | Don't convert to a different currency | ConvertCurrency |
| Multiply | Perform multiplication on column | Expression |
| Header | Generates a header row when this group level key changes | GroupBy |
| Footer | Generates a footer row when this group level key changes | GroupBy |
| Integer | A number the nested level this key belongs to<br>Default is 1 | GroupBy |

`HideDetail` is commonly used when calculation results should only appear in the Header, Footer, and GrandTotal rows. Given the example `Count(SaleId):HideDetail`, the `HideDetail` modifier instructs the provider to not include this desired column in the `row.ColumnData` collection.

It only makes sense to output headers or footers row when results are grouped. Therefore, the Header, Footer, and Integer modifiers are only used together with GroupBy.

The `Integer` modifier is literally a number that specifies the nest level of a group. The first GroupBy function has a default level value of 1 and is not required. in a Using integer is only useful when there are more than one

| Function and modifier | Description |
|---|---|
| Count(columnName):HideDetail | Count but hide in detail row. Available in GrandTotal, Headers and Footers |
| GroupBy(columnName):Header | Display header row for this group for each unique value |
| GroupBy(columnName):Footer | Display footer row for this group for each unique value |
| GroupBy(columnName):Footer,HideDetail | Display footer row for this group for each unique value, Remove the detail rows |
| GroupBy(columnName):Header,Footer,1 | Display first level of header and footer rows for each unique value |
| GroupBy(columnName):Header,Footer,2 | Display nested level of header and footer rows under first level for each unique value |

Below are two examples that demonstrate how to use the count function to:

* display the accumulative sale count.
* use with a `HideDetail` modifier to save the output for the `GrantTotal` row.

## Example: Using Count("saleId")

[!code-csharp[scenario 1](includes/aggregate-count-saleid.cs)]

**Example output:**

```text
1) SaleId: 1, Heading: SalgAAAA
2) SaleId: 5, Heading: SalgWAAW
3) SaleId: 6, Heading: SalgØAAØ
4) SaleId: 12, Heading: SalgGBBG
5) SaleId: 16, Heading: SalgÅBBÅ
6) SaleId: 21, Heading: SalgCDDC
7) SaleId: 24, Heading: SalgSDDS
8) SaleId: 25, Heading: SalgYDDY
9) SaleId: 33, Heading: SalgOFFO
10) SaleId: 37, Heading: Salg4FF4
11) SaleId: 40, Heading: SalgEHHE
12) SaleId: 43, Heading: SalgUHHU
13) SaleId: 49, Heading: SalgKGGK
14) SaleId: 51, Heading: Salg0GG0
```

Each row includes the result of the `Count(saleId)` function and is accessed just like normal detail columns in the `row.ColumnData` collection.

The following example includes the `GrandTotal=True` option in the `GetRows` method. This acts as a signal to save the results of all functions with the `HideDetail` modifier and include them as available columns in the final row output. When set, the final row `RowType` is "grandtotal".

## Example: Using Count("saleId"):HideDetail with GrandTotal

[!code-csharp[scenario 2](includes/aggregate-count-grandtotal.cs)]

**Example output:**

```text
SaleId: 1, Heading: SalgAAAA
SaleId: 5, Heading: SalgWAAW
SaleId: 6, Heading: SalgØAAØ
SaleId: 12, Heading: SalgGBBG
SaleId: 16, Heading: SalgÅBBÅ
SaleId: 21, Heading: SalgCDDC
SaleId: 24, Heading: SalgSDDS
SaleId: 25, Heading: SalgYDDY
SaleId: 33, Heading: SalgOFFO
SaleId: 37, Heading: Salg4FF4
SaleId: 40, Heading: SalgEHHE
SaleId: 43, Heading: SalgUHHU
SaleId: 49, Heading: SalgKGGK
SaleId: 51, Heading: Salg0GG0
Total Project 47 Sales: 14
```

When using the `GrandTotal` option, the results output a final row that facilitates access to all aggregate functions that were specified with the `HideDetails` modifier. This becomes useful for displaying a summary of the query results.

> [!NOTE]
> A detail RowType will **not** say `row.RowType=detail`. Instead, then RowType of a detail row is equal to the entity name that the row represents, for example contact, project, or sale.

## Continue reading

* [Structured aggregation output with GroupBy][1]

<!-- Referenced links -->
[1]: aggregate-groupby.md
