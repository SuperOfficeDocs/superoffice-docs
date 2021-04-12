---
# Mandatory fields.
title: aggregate_groupby       # (Required)
description: Structured aggregation output with groupby # (Required) Important for SEO.
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Structured aggregation output with GroupBy

Probably the most powerful aggregate function, GroupBy provides the capability to band query results into rigid report-like structures. With capabilities that span aggregation-only to combined to detail only, it’s a flexible tool that can be used in different ways.

## Aggregation only

Strict aggregation-only use is most similar to the **SQL GROUP BY** statement, where it arranges the query results into groups of rows, usually to perform one or more aggregations on each group. Nearly all widgets in SuperOffice Dashboards use this form of aggregation to display results.

Using the archive provider `appointmentdynamicselection`, construct a query that will count all activities for the current user for the past month and group them by type.

Use the `Count` function to count each unique appointment ID, and use the `HideDetail` modifier to remove the column from the detail rows. Then use the `GroupBy` function to divide the query results into activity types. Use the `Footer` modifier to output a footer row that contains the count and type columns for each group. Also, append the `HideDetails` modifier to not return any detail rows; just the footer rows.

[!code-csharp[scenario 1](includes/aggregate-only.cs)]

The results are one row for each activity type and occurrence count.

### Query output

| Rowno | Row type | Count(appointmentId):HideDetail | GroupBy(type):Footer,HideDetail |
|---|---|---|---|
| 0 (1) | \[footer:1\] | 4 | Meeting (Internal) |
| 1 (2) | \[footer:1\] | 1 | Phone-Out |

## Row type

Similar to reports, combined aggregation results use `GroupBy` functions together with other columns, both aggregate and non-aggregate, to display `Header`, `Footer`, and `Detail` rows.

For example, a new group of rows is created every time a GroupBy column value changes, dividing the results into one or more Header - Details - Footer rows. Modifiers are used to control where aggregation columns reside and become accessible.

The `RowType` property of a row determines if the output is a normal detail row, header row, footer row, or grandtotal row.

| Row type | Output |
|---|---|
| header | Function |
|detail | Column data |
| footer | Function |
| grandtotal | Function |

To demonstrate the concepts, create a query that uses the person archive provider and set the desired columns to include the `firstName`, `middleName`, `lastName`, and `rank`, then set the restriction to where the `contactId` equals 24. Next, create three aggregate columns that do the following:

* Sum the rank column for display in details.
* Count all of the occurrences of `firstName` for display in details.
* Group the results by `middleName`, and make this column available in both the header and footer, but hide in detail rows.

[!code-csharp[scenario 2](includes/aggregate-rowtype.cs)]

### Sample data - company name: Superoso, 5 employees

| First name | Middle name | Last name | Rank |
|---|---|---|---|
| Jane | Ray | Doe | 1 |
| Billy | Ray | Doe | 2 |
| Bobby | Sue | Doe | 3 |
| Mary | Sue | Smith | 4 |
| Tabby | Sue | Smith | 5 |

Using the sample data, the results are divided into two distinct groups. The first group contains all persons with the middle name Ray and the second group contains all people with the middle name Sue.

Every time the middle name changes, the results will create and output a new band of header, detail, and footer rows. According to the specification, two of the aggregate columns are available in the detail rows, but the `GroupBy` column is only available in the header and footer rows of each band.

### Query Output

| Rowno (id) | Row type | GroupBy(middleName):<br>HideDetail,Header,Footer | CountAll(firstName) | fName | lName | mName | rank | Sum(rank) |
|---|---|---|---|---|---|---|---|---|
| 0 (1) | \[header:1\] | Ray | 2 | | | | | 3 |
| 1 (324) | \[person\] | | 1 | Jane | Doe | Ray | 1 | 1 |
| 2 (325) | \[person\] | | 2 | Billy | Doe | Ray | 2 | 3 |
| 3 (1) | \[footer:1\] | Ray | 2 | | | | | 3 |
| ... | | | | | | | | |
| 4 (2) | \[header:1\] | Sue | 3 | | | | | 12 |
| 5 (326) | \[person\] | | 1 | Bobby | Doe | Sue | 3 | 3 |
| 6 (327) | \[person\] | | 2 | Mary | Smith | Sue | 4| 7 |
| 7 (328) | \[person\] | | 3 | Tabby | Smith | Sue | 5 | 12 |
| 8 (2) |\[footer:1\] | Sue | 3 | | | | | 12 |
| 9 (1) | \[grandtotal\] | | 5 | | | | | 15 |

### GrandTotal

If the `provider.GetRows` method included the `GrandTotal` option, the last row in the results includes the `GrandTotal` row type. Notice how the `Sum` and `CountAll` functions appear and display the total results. All aggregate columns, except `GroupBy`, are included and available in the `GrandTotal` row.

```csharp
foreach (var row in provider.GetRows(AggregationProvider2.GrandTotalOption + "=True"))
{
  if (row.RowType == "grandtotal")
  {
    int totalNameCount = (int)row.ColumnData["CountAll(firstName)"].RawValue;
    int totalRankSum   = (int)row.ColumnData["Sum(rank)"].RawValue;
  }
}
```

## Multiple-level GroupBy

It’s easy to specify an additional group level with the integer modifier. Building on the last example, create a query that sets the desired columns to include the `firstName`, then set the restriction to where the `contactId` equals 24. Next, create these five aggregate columns:

* Count all of the occurrences of `firstName` for display in details.
* Count the unique occurrences of `middleName` for display in details.
* Sum the rank column for display in details.
* Group the first level of results by `middleName`, and make the column available in both the header and footer, but hide in detail rows.
* Group the second level of results by lastName, and make the column available in the details row, as well as both the header and footer.

[!code-csharp[scenario 4](includes/multilevel-groupby.cs)]

### Query output

| RowNo | RowType | Count (middleName) | CountAll (firstName) | firstName | GroupBy (middleName): HideDetail,Header,Footer,1 | GroupBy (lastName): Header,Footer,2 | Sum(rank): HideDetail |
|-------|--------------|---|---|------|-----|---|---|
| 0 (1) | \[header:1\] | 1 | 2 |      | Ray |   | 3 |
| 1 (2) | \[header:2\] | 1 | 2 |      | |Doe | 3 |
| 2 (359) | \[person\] | 1 | 1 | Jane | | | |
| 3 (360) | \[person\] | 1 | 2 | Billy | | | |
| 4 (1) | \[footer:2\] | 1 | 2 | | | Doe | 3 |
| 5 (2) | \[footer:1\] | 1 | 2 | |Ray | | 3 |
| 6 (3) | \[header:1\] | 1 | 3 | | Sue | | 12 |
| 7 (4) | \[header:2\] | 1 | 1 | | | Doe | 3 |
| 8 (361) | \[person\] | 1 | 1 | Bobby | | | |
| 9 (3) | \[footer:2\] | 1 | 1 | | | Doe | 3 |
| 10 (5) | \[header:2\] | 1 | 2 | | | Smith | 9 |
| 11 (362) | \[person\] | 1 | 1 | Mary | | | |
| 12 (363) | \[person\] | 1 | 2 | Tabby | | |
| 13 (4) | \[footer:2\] | 1 | 2 | | | Smith | 9 |
| 14 (5) | \[footer:1\] | 1 | 3 | | Sue | | 12 |
| 15 (1) | \[grandtotal\] | 2 | 5 | | | | | 15 |

The output includes two first-level groups; one for each of the two different middle names. The first band is grouped by `middleName` and contains two people with the middle name Ray. Because both of these people share the same last name, there are no nested levels grouped by `lastName`. The second group contains three people with the same second name. However, only two share the same last name and so there becomes two nested groups; one for `lastName` Doe and one for last name Smith.

## Continue reading

* [Nested aggregate functions][1]

<!-- Referenced links -->
[1]: nested-aggregate-functions.md
