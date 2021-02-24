---
title: odata_rest_api_search
description: REST Web API search using ODATA
author: {github-id}             # Your GitHub alias.
keywords: search,odata
so.date:
so.topic: concept
---

# REST Web API search

SuperOffice REST APIs expose search endpoints that API consumers use to submit search queries.

Examples of these endpoints are:

* `/api/v1/Appointment`
* `/api/v1/Contact`
* `/api/v1/Person`
* `/api/v1/Sale`

Each endpoint, accessed by a GET request without parameters, is expected to be an [OData URI][1] query.

OData is a standard for specifying queries and getting results back. OData is a way to access the archive providers in NetServer.

## OData

The OData URIs are expected in a structured query format, which is then server-side transformed into data structures understood by [archive providers][2].

`/api/v1/contact?$select=field1,field2&$filter=contactId eq 5`

-root---/-resource-/-query options ----------------------/

---

An OData URI accepts any number of the following options that are used to formulate logical database queries.

| Options | Type | Description |
|---|---|---|
| $select | string | Comma-separated list of column names to return. "nameDepartment,fullname,category". Can also use aggregation functions and modifiers: "Count(category):Footer" |
| $filter | string | Expression to restrict the results. e.g.: "name begins 'foo' and category gt 1" |
| $orderBy | string | Comma separated list of column names to sort by, with optional direction. "name asc,fullname,category desc" |
| $entities | string | Comma separated list of entity names to use. Default = "". "contact, person" |
| $top | int32 | Number of rows to return in results |
| $skip | int32 | Number of rows from database to skip before returning results |
| $mode | Enum: Slim, Full | FULL (with raw values and hints for each value) or SLIM (just the display values) |
| $options | string | Provider specific options. e.g: "GrandTotal=true" |
| $context | string | Provider specific context parameter. |
| $format | string | Set XML or JSON output format; override the format determined from Accept header. |
| $jsonSafe | bool | Make output names into JSON safe property names. Replace all unsafe characters with _ underscore. |
| $output | Enum: Logical, Display | Return Logical or Display values in SLIM mode. Logical returns true/false for booleans, Display returns icon hints. Dates are always returned as ISO strings. |

## The OData - Archive Provider connection

Because every OData query performs a search using an [archive provider][1], it's important to understand the relationship between the OData query options and how that structure gets transformed into something the underlying archive provider can understand.

OData queries provide the means to submit a query with `SELECT` columns, `WHERE` criteria, `ORDER BY` instructions, and paging information.

Looking at the Sale endpoint, select the GET Sale node. In addition to providing clues for how to construct an OData query, these pages all detail which archive provider is used by the endpoint to perform the query.

The name of the archive provider is located just above the Filter section. Locate the paragraph that begins with *Calls the Archive service using the `"{ArchiveProvider}"` archive."* The name of the archive provider matches one that is listed in the Archive Provider pages.

The GET Sale endpoint uses the `FindSale` archive provider.

![GetSale][img1]

## $select columns

All available columns, shown under the blue rectangle, are listed under the **Supported Columns** text on the FindSale archive provider page.

![GetSale][img2]

Archive provider pages also list the column datatypes and whether or not the column can by used in an `ORDER BY` statement.

![GetSale][img3]

## $filter operators

Difference data types can have different operators. Each OData search page contains a table of data types and their associated operators.

| Data type | Description |
|---|---|
| Bool | set |
| Int, Decimal | eq, ne, lt, gt, set, equals, greater, less, unequals, between |
| String | begins, between, contains, is, notBegins, notContains, isNot |
| Date | before, date, after, between, dateBetween |
| DateTime | dateTime, beforeTime, afterTime |
| Unary (Days)| beforeToday, today, afterToday |
| Unary (Weeks) | lastWeek, thisWeek, nextWeek |
| Unary (Months) | lastMonth, thisMonth, nextMonth |
| Unary (Quarter) | lastQuarter, thisQuarter, nextQuarter |
| Unary (Year) | thisHalf, thisYear |
| Associate | associateIsOneOf, associateIsNotOneOf, currentAssociate |
| Lists | equals, oneOf, notOneOf |

Read more about [using filters][3].

## Example searches

* [Associate][4]
* [Boolean][5]
* [Contact][12] (company)
* [Date][6]
* [DateTime][7]
* [Lists][8]
* [Numbers][9] (integer, decimal, float)
* [Strings][10]
* [Unary][11] (day, week, month, quarter, year)

<!-- Referenced links -->
[1]: https://www.odata.org/
[2]: ../../archive-providers/index.md
[3]: using-filters.md
[4]: associate.md
[5]: boolean.md
[6]: date.md
[7]: datetime.md
[8]: lists.md
[9]: numbers.md
[10]: strings.md
[11]: unary-day-week-month-quarter-year.md
[12]: ../../contact/get/get-all-contacts-rest.md

<!-- Referenced images -->
[img1]: media/get-sale.png
[img2]: media/find-sale.png
[img3]: media/find-sale-supported-columns.png
