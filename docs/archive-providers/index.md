---
title: archive_providers       
description: NetServer Archive Providers   
author: Tony Yates             # Your GitHub alias.
so.date: 17 Nov 2017
keywords:
---

# NetServer Archive Providers

How use archive providers for simple to complex data sources.

From low-level Objectified-SQL to higher-level business Entities, SuperOffice integrations have several ways to access to SuperOffice data. Complete access to the database through web services, however, is subject to all kinds of security threats and therefore is not a simple problem to solve. Archive providers were later introduced as a means to execute complex queries through web services in a secure and easy-to-use manner. This article describes what they are and how to use them.

## What is an Archive Provider

Fundamentally, an archive providers is similar to a database view. They each have a unique name, expose a fixed-set of selectable fields and mask their join logic. Underneath the hood lies a dynamic system that, based on the requested fields, only creates joins that are absolutely necessary. This of course increases query performance and throughput.

An Archive provider is determined by three main properties:

* Archive Name
* Available Entities
* Available Columns

Entities add a dimension that database views do not possess. They act as an additional filtering capability. For example, not all, but several archive providers return rows that are of multiple types. This means that a single query can return rows of details that represent several differenct types of rows like appointment, sale and document. On providers that support multiple entities, it possible to tell the provider to only return one or two types of rows, and ignore the rest.

Executing complex queries requires a way to specify criteria, and archive providers do this with Archive Restrictions.

There is a long list of archive providers that give access to virtually the entire database. Some of the most common are the Find providers.

* FindAppointment Archive Provider
* FindContact Archive Provider
* FindDocument Archive Provider
* FindProject Archive Provider
* FindSale Archive Provider
* FindSelection Archive Provider

Please [see the NetServer documentation][1] for a complete list of available archive providers.

## How to Perform an Archive Provider Query

While archive providers make complex queries possible through web services, they of course work in and with their lower-level data types executed in the belly NetServer.

This section presents a demonstration how to query an archive provider both using the core NetServer API, as well as the NetServer Web Services API.

Both examples represent a query that selects all sales where the sale project id is set to 47.

### NetServer Core

```csharp
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
    int saleId     = (int)row.ColumnData["saleId"].RawValue;
    string heading =      row.ColumnData["heading"].RawValue.ToString();

    Console.WriteLine("SaleId {0}, Heading {1}",
                saleId,
                heading);
}

// remember to close the provider to release resources
provider.Close();
```

### NetServer Web Services

```csharp
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

    var results = fa.FindFromRestrictionsColumns(
                        restrictions, 
                        providerName, 
                        columns, 
                        50, 
                        0);

    // ensure there are results and iterate over the them
    if (   results != null 
        && results.ArchiveRows != null 
        && results.ArchiveRows.Length > 0   )
    {
        foreach (var row in results.ArchiveRows)
        {
            var saleId    = row.ColumnData["saleId"].DisplayValue;
            var heading   = row.ColumnData["heading"].DisplayValue;

            Console.WriteLine("SaleId {0}, Heading {1}",
                SuperOffice.CRM.Globalization.CultureDataFormatter.
                ParseEncodedInt(saleId).ToString(),
                heading.ToString());
        }
    }
}
```

### NetServer REST WebApi 

Using the Sale endpoint and issue an OData query ([documentation][2]:

```javascript
GET /Cust12345/api/v1/Sale?$select=saleId,heading,projectId&$filter=projectId eq 47 HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
```

### NetServer REST Agent Service

Using the RESTful Agent Find endpoint ([documentation][3]):

```javascript
POST /Cust12345/api/v1/Agents/Find/FindFromRestrictionsColumns HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
Content-Type: application/json

{
  "ProviderName": "FindSale",
  "DesiredColumns": [
    "saleId",
    "heading",
    "projectId"
  ],
  "Restrictions": [
    {
      "Name": "projectId",
      "Operator": "=",
      "Values": [
        "47"
      ],
      "IsActive": true
    }
  ],
  "Page": 0,
  "PageSize": 100
}
```

There are subtle differences between core and web services APIs, but for the most part they are the same. One of the biggest differences is how value types are returned, i.e. integers, Double and DateTime.

## Encoded Values

With core NetServer, the archive row column data contains a RawValue property of type Object, and can safely be cast to the appropriate type.

Using NetServer web services, it depends on whether you are using SuperOffice proxies or not. If you are, the RawValue property contains the column value. If not, only the DisplayValue exists.

With the exception of string column values, DisplayValue always contains an encoded string that represents the column values. We recommend you use `SuperOffice.CRM.Globalization.CultureDataFormatter` class to handle these encoded values. As seen in the web services API example, SuperOffice.CRM.Globalization.CultureDataFormatter easily parses and returns the column value in the correct data type.

An encoded value is always a string of characters in the format: \[data-type-marker : value\], i.e. \[I:3\]. Columns that are of type string will never be in an encoded format.

The data type marker indicates the column data type followed by a colon, then the column data value. The following table lists all encodings.

| Data Type | Marker | Example |
|---|---|---|
| Binary | B | \[B:X98…\] |
| Date | D | \[D:09.11.2017\] |
| DateTime | DT | \[DT:11/09/2017 14:53:18\] |
| Double, Decimal | F | \[F:123.4\] |
| Int | I | \[I:123\] |
| Money | M | \[M:123.45\] |
| Time | T | \[T:14:52\] |
| String | | “Not encoded” |

For each data type, CultureDataFormatter has a static Encode and ParseEncoded method, for example:

* string = CultureDataFormatter.EncodeInt(int),
* int = CultureDataFormatter.ParseEncodedInt(string)

Although query restrictions do not have to encode parameter values when settings each restriction, they are allowed and NetServer knows how to detect and process them accordingly.

## Data Aggregation

In addition to specifying desired column names, providers accept aggregate functions as column parameters. These are called and referred to as aggregate columns.

Aggregate columns are extremely useful when the results need to be transformed in a structured way. Aggregate columns can also nest other aggregate functions.

### Aggregate Functions

| Function | Description | Example |
|---|---|---|
| Avg | Average of all values. | Avg(amount) |
| Count | Count unique values | Count(saleId) |
| CountAll | Count all values, even duplicates | CountAll(appointmentId) |
| CurrencyConvert | Convert numbers in amountcol, understood to be in currency set by currencycol to the Base currency, users Own currency, or don’t convert. | CurrencyConvert(amountcol;currencycol):Base or Own or None |
| DatePart | DateModifiers:, - Year, Quarter, Month, Day, DayOfYear - simple numbers,- ISODate, ISODateHour : formatted strings, - DayOfWeek, DayOfWeekFromMonday, Weekno, YearWeekno, YearWeekAsISODate : week functions, - YearQuarter, YearMonth : string: number/number | DatePart(date):YearMonth |
| Expression | Expects two or more fields, only supports Multiply modifier. | Expression(amount;probabilityPercent):Multiply |
| GroupBy | Controls processing and is independent of query OrderBy | GroupBy(stage) |
| Median | Returns the middle number. Values expect to be integer or double type. | Median(quantity) |
| Percent | Returns a percentage of the accumulated value of a field. Values can be integer or double. | Percent(progProbability) |
| Sum | Total accumulated amount of a field. Values can be integer or double. | Sum(quantity) |
| Weighted | Multiply numbers in amountcol by the percentage in the weightcol | Weighted(amountcol;weightcol) |

Data transformations can be as simple returning a running count of a column, or as complex as including nested groups; with the use of multiple GroupBy functions. The default output of every archive provider are rows that include the specified detail columns.

### Default row output

Detail Row => \| Column1 \| Column2 \| Column3 \| Column4

However, hidden as an option is the GrandTotal row. GrandTotal is a reserved placeholder for returning aggregate results, such as a total count or total sum.

When specified in a providers GetRows method, i.e. `provider.GetRows("GrandTotal=True")`, the grand total row is output as the very last row. This is useful to display the results of one or more aggregate columns.

### Default row output with GrandTotal

Detail Row1 => \| Column1 \| Column2 \| Column3 \| Column4
Detail Row2 => \| Column1 \| Column2 \| Column3 \| Column4
*GrandTotal Row* \=> \| Function1 \| Function2

### Aggregate Function Modifiers

Function modifiers are used to set the behavior or output of an aggregate function. An aggregate function can include one or more modifiers, and the format is as follows:

`FunctionName(columnName)[:Modifer[,Modifier]...]`

| Modifer | Description | Used by |
|---|---|---|
| HideDetail | Removes running value in the detail rows. | All Functions |
| Base | Use the base currency. | ConvertCurrency |
| Own | Use the associates set currency. | ConvertCurrency |
| None | Do not convert to a different currency. | ConvertCurrency |
| Multiply | Perform multiplication on column. | Expression |
| Header | Generates a header row when this group level key changes | GroupBy |
| Footer | Generates a footer row when this group level key changes | GroupBy |
| Integer | A number the nested level this key belongs to; default is 1 | GroupBy |

HideDetail is commonly used when calculation results should only appear in the Header, Footer and GrandTotal rows. Given the example `Count(SaleId):HideDetail`, the HideDetail modifier instructs the provider to not include this desired column in the row.ColumnData collection.

It only makes sense to output headers or footers row when results are grouped. Therefore, the Header, Footer, and Integer modifiers are only used together with GroupBy.

The Integer modifier is literally a number that specifies the nest level of a group. The first GroupBy function has a default level value of 1 and is not required. in a Using integer is only useful when there are more than one

| Function and Modifier | Description |
|---|---|
| Count(columnName):HideDetail | Count but hide in detail row. Available in GrandTotal, Headers and Footers |
| GroupBy(columnName):Header | Display header row for this group for each unique value |
| GroupBy(columnName):Footer | Display footer row for this group for each unique value |
| GroupBy(columnName):Footer,HideDetail | Display footer row for this group for each unique value, Remove the detail rows |
| GroupBy(columnName):Header,Footer,1 | Display first level of header and footer rows for each unique value |
| GroupBy(columnName):Header,Footer,2 | Display nested level of header and footer rows under first level for each unique value |

Below are two examples that demonstrate how to use the count function to:

1. display the accumulative sale count.
2. use with a HideDetail modifier to save the output for the GrantTotal row.

### Example: Using Count(“saleId”)

```csharp
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
    int count      = (int)row.ColumnData["Count(saleId)"].RawValue;
    int saleId     = (int)row.ColumnData["saleId"].RawValue;
    string heading =      row.ColumnData["heading"].RawValue.ToString();

    Debug.WriteLine("{0}) SaleId: {1}, Heading: {2}",count,saleId,heading);
}

// remember to close the provider to release resources
provider.Close();
```

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

Each row includes the result of the Count(saleId) function, and is accessed just like normal detail columns in the row.ColumnData collection.

The following example includes the “GrandTotal=True” option in the GetRows method. This acts as a signal to save the results of all functions with the HideDetail modifier and include them as available columns in the final row output. When set, the final row RowType is “grandtotal”.

### Example: Using Count(“saleId”):HideDetail with GrandTotal

```csharp
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
```

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

When using the GrandTotal option, the results outputs a final row that facilitates access to all aggregate functions that were specified with the HideDetails modifier. This becomes useful for displaying a summary of the query results.

> [!NOTE]
> A detail RowType will _not_ say row.RowType=detail. Instead, then RowType of a detail row is equal to the entity name that the row represents, i.e. contact, project, sale, etc.

## Structured Aggregation Output With GroupBy

Probably the most powerful aggregate function, GroupBy provides the capability to band query results into rigid report-like structures. With capabilities that span aggregation-only to combined to detail only, it’s a flexible tool that can be used in a couple different ways.

Strict aggregation-only use is most similar to the SQL _GROUP BY_ statement, where it arranges the query results into groups of rows, usually for the purpose of performing one or more aggregations on each group. Nearly all of widgets in SuperOffice Dashboards use this form of aggregation to display results.

Using the archive provider _appointmentdynamicselection_, construct a query that will count all activities for the current user for the past month and group them by type.

Use the Count function to count each unique appointmentId, and use the HideDetail modifier to remove the column from the detail rows. Then use the GroupBy function to divide the query results into activity types. Use the Footer modifier to output a footer row that contains the count and type columns for each group. Also append the HideDetails modifier to not return any detail rows; just the footer rows.

```csharp
// use selection provider to get all my completed activities this month

var provider = ArchiveProviderFactory.Create("appointmentdynamicselection");

// Set the aggregate functions to get how many of each, grouped by type

provider.SetDesiredColumns(
   "Count(appointmentId):HideDetail",
   "GroupBy(type):Footer,HideDetail"
   );

provider.SetDesiredEntities("appointment");
provider.SetPagingInfo(100, 0);

// specifiy the restrictions

provider.SetRestriction(
   new ArchiveRestrictionInfo("endDate", ">", CultureDataFormatter.EncodeDate(DateTime.Now.AddMonths(-1))),
   new ArchiveRestrictionInfo("associateId", "currentAssociate", ""),
   new ArchiveRestrictionInfo("completed", "set", "1"),
   new ArchiveRestrictionInfo("selectionId", "=", "-1")
   );

// fetch the rows

foreach (var row in provider.GetRows(""))
{
   var activityType  =      row.ColumnData["GroupBy(type):Footer,HideDetail"].RawValue.ToString();
   var activityCount = (int)row.ColumnData["Count(appointmentId):HideDetail"].RawValue;
}
```

The results are one row for each activity type and occurance count.

### Query output

| Rowno | Row type | Count(appointmentId):HideDetail | GroupBy(type):Footer,HideDetail |
|---|---|---|---|
| 0 (1) | \[footer:1\] | 4 | Meeting (Internal) |
| 1 (2) | \[footer:1\] | 1 | Phone-Out |

Similar to reports, combined aggregation results use GroupBy functions together with other columns, both aggregate and non-aggregate, to display Header and Footer, and Detail rows. For example, a new group of rows is created everytime a GroupBy column value changes, dividing the results into one or more Header - Details - Footer rows. Modifiers are used to control where aggregation columns reside and become accessible.

A rows’ RowType property determines if the output is a normal detail row, header row, footer row, or grandtotal row.

| Row types | Output |
|---|---|
| header | Function |
|detail | Column Data |
| footer | Function |
| grandtotal | Function |

To demonstrate the concepts, create a query that uses the person archive provider and set the desired columns to include the firstName, middleName, lastName and rank, then set the restriction to where the contactId equals 24. Next, create three aggregate columns that do the following:

* Sum the rank column for display in details.
* Count all of the occurrences of firstName for display in details.
* Group the results by middleName, and make this column available in both the header and footer, but hide in detail rows.

```csharp
var provider = ArchiveProviderFactory.Create(PersonProvider.ProviderName);

provider.SetDesiredColumns(
   "firstName", 
   "middleName", 
   "lastName", 
   "rank", 
   "Sum(rank)",
   "CountAll(firstName)", 
   "GroupBy(middleName):Header,Footer"
);

provider.SetDesiredEntities("person");
provider.SetPagingInfo(100, 0);
provider.SetRestriction(new ArchiveRestrictionInfo("contactId", "=", CultureDataFormatter.Encode(24)));


foreach (var row in provider.GetRows(string.Empty))
{
   //parse the results.
}
```

### Sample data - company name: Superosom, 5 employees

| First Name | Middle Name | Last Name | Rank |
|---|---|---|---|
| Jane | Ray | Doe | 1 |
| Billy | Ray | Doe | 2 |
| Bobby | Sue | Doe | 3 |
| Mary | Sue | Smith | 4 |
| Tabby | Sue | Smith | 5 |

Using the sample data, the results are divided into two distinct groups. The first group contains all persons with the middle name Ray and the second group contains all people with the middle name Sue.

Every time the middle name changes, the results will create and output a new band of header, detail and footer rows. According to the specification, two of the aggregate columns are available in the detail rows, but the GroupBy column is only available in the header and footer rows of each band.

## Query Output

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

If the provider.GetRows method included the GrandTotal option, the last row in the results include thre GrandTotal row type. Notice how the Sum and CountAll functions appear and display the total results. All aggregrate colums, except GroupBy, are included and available in the granttotal row.

```csharp
foreach (var row in provider.GetRows(AggregationProvider2.GrandTotalOption + "=True"))
{
    if (row.RowType == "granttotal")
    {
        int totalNameCount = (int)row.ColumnData["CountAll(firstName)"].RawValue;
        int totalRankSum   = (int)row.ColumnData["Sum(rank)"].RawValue;
    }
}
```

### Multiple Level GroupBy

It’s easy to specify an additional group level with the integer modifier. Building on the last example, create a query that sets the desired columns to include the firstName, then set the restriction to where the contactId equals 24. Next, create these five aggregate columns:

* Count all of the occurences of firstName for display in details.
* Count the unique occurences of middleName for display in details.
* Sum the rank column for display in details.
* Group the first level of results by middleName, and make the column available in both the header and footer, but hide in detail rows.
* Group the second level of results by lastName, and make the column available in the details row, as well as both the header and footer.

```csharp
var provider = ArchiveProviderFactory.Create(PersonProvider.ProviderName);
provider.SetDesiredColumns("firstName",
       "CountAll(firstName)",
       "Count(middleName)",
       "Sum(rank):HideDetail",
       "GroupBy(middleName):Header,Footer,1",
       "GroupBy(lastName):Header,Footer,2");
provider.SetDesiredEntities("person");
provider.SetPagingInfo(100, 0);
provider.SetRestriction(new ArchiveRestrictionInfo("contactId", "=", CultureDataFormatter.Encode(24)));

foreach (var row in provider.GetRows(AggregationProvider2.GrandTotalOption + "=true"))
{
   // ...
}
```

## Query Output

| RowNo | RowType | Count (middleName) | CountAll (firstName) | firstName | GroupBy (middleName): HideDetail,Header,Footer,1 | GroupBy (lastName): Header,Footer,2 | Sum(rank): |HideDetail |
| 0 (1) | \[header:1\] | 1 | 2  | | Ray | | 3 |
| 1 (2) | \[header:2\]| 1 | 2 | | |Doe | 3 |
| 2 (359) | \[person\] | 1 | 1 | Jane | | | |
| 3 (360) | \[person\] | 1 | 2 | Billy | | | |
| 4 (1) | \[footer:2\] | 1 | 2 | | | Doe | 3 |
| 5 (2) | \[footer:1\] | 1 | 2 | | |Ray | | 3 |
| 6 (3) | \[header:1\] | 1 | 3 | | Sue | | | 12 |
| 7 (4) | \[header:2\] | 1 | 1 | | | | Doe | 3 |
| 8 (361) | \[person\] | 1 | 1 | Bobby | | |
| 9 (3) | \[footer:2\] | 1 | 1 | | Doe | 3 |
| 10 (5) | \[header:2\] | 1 | 2 | | | Smith | 9 |
| 11 (362) | \[person\] | 1 | 1 | Mary | | | | |
| 12 (363) | \[person\] | 1 | 2 | Tabby | | | |
| 13 (4) | \[footer:2\] | 1 | 2 | | | | Smith | 9 |
| 14 (5) | \[footer:1\] | 1 | 3 | | Sue | | 12 |
| 15 (1) | \[grandtotal\] | 2 | 5 | | | | | 15 |

The output includes two first-level groups; one for each of the two different middle names. The first band is grouped by middleName and contains two people with the middle name Ray. Because both of these people share the same last name, there are no nested levels grouped by lastName. The second group contains three people with the same second name. However, only two share the same last name and so there becomes two nested groups; one for lastName Doe and one for last name Smith.

## Nested Aggregate Functions

Functions can contain functions, so it’s possible to pass the result of one aggregate function to another aggregate function for compound operations. For example, with regards to a sale amount, first weight the amount and then converted to a specific currency using:

`CurrencyConvert(Weighted(amount;probPercent);currencyId))`

To demonstrate the concept, construct a query that displays the top sales representatives this month. Do this by specifying a restriction where the userGroup equals the sales group, the saleStatus is sold, and the sale date is within the past month. Sort the results by the sum of the sale amount, descending. Then add the following aggregate functions to display the results in a footer - one for each distinct group:

* using Sum and ConvertCurrency, convert all sale amounts to one currency and then sum the amounts.
* use GroupBy to divide the results by full name, personId and title.

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

provider.SetOrderBy(
    new ArchiveOrderByInfo(
        formattedSum,
        SuperOffice.Data.OrderBySortType.DESC));

// Set the aggregate functions to get how many of each, grouped by type

provider.SetDesiredColumns(
    formattedSum,
    "GroupBy(associate/fullName):Footer,HideDetail", //default level 1, no nesting
    "GroupBy(associate/personId):Footer,HideDetail", //default level 1, no nesting
    "GroupBy(associate/title):Footer,HideDetail"     //default level 1, no nesting
    );

// specifiy the restrictions

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
```

> [!NOTE]
> The use of CultureDataFormatter to format the summed amount into local currency in both the footer and grandtotal rows.

### Query Results

| Rowno | Row type | GroupBy (associate/fullName): Footer,HideDetail | GroupBy (associate/personId): Footer,HideDetail | GroupBy (associate/title): Footer,HideDetail | Sum (CurrencyConvert (amount;36)): HideDetail |
|---|---|---|---|---|
| 0 (1) | \[footer:1\] | Rebecca Franklin | 9| Sales Representative | 1 480 110,00 |
| 1 (2) | \[footer:1\] | Sean Baker | 8 | Tech and Sales | 152 495,00 |
| 2 (1) | \[grandtotal\] | | | 1 632 605,00 |

Another common scenario to demonstrate nested functions is to group sales based on a DatePart. Combined together with a GroupBy, the use of DatePart makes it easy to aggregate sales by week, month or quarter.

Use the previous example as a template and modify the restriction sale date to show just this year. Modify the Sort to use the GroupBy DatePart, ascending. Then change the desired columns to just include the Sum of sale amounts and a GroupBy to divide the results by months.

```csharp
var currency = SuperOffice.CRM.Rows.Util.CurrencyConversionHelper.BaseCurrencyId;

// set the formatted function for use in multiple places below
s
var formattedSum = string.Format("Sum(CurrencyConvert(amount;{0})):HideDetail", currency);

// use selection provider to get all my completed activities this month

var provider = ArchiveProviderFactory.Create("saledynamicselection");

// Set the aggregate functions to get how many sales, grouped by Month

provider.SetDesiredColumns(formattedSum, "GroupBy(DatePart(date):Month):Footer,HideDetail");

provider.SetDesiredEntities("sale");
provider.SetPagingInfo(100, 0);

// specifiy the restrictions

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
            var foSum    =      row.ColumnData[formattedSum].DisplayValue;

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

## Conclusion

From situations that depend on constructing light-weight datamodels to performing complex aggregate queries, archive providers are an attractive tool in your tool-belt. They are easy to use data sources and work well for executing wide variety of queries.

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/Reference-Reference.htm
[2]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/v1SaleEntity_GetAll.htm
[3]: https://community.superoffice.com/documentation/sdk/SO.NetServer.Web.Services/html/v1FindAgent_FindFromRestrictionsColumns.htm
