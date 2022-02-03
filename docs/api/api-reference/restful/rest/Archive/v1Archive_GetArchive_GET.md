---
title: GET Archive/{archiveProviderName}
id: v1Archive_GetArchive_GET
---

# GET Archive/{archiveProviderName}

```http
GET /api/v1/Archive/{archiveProviderName}
```

Returns archive providers in OData format.

Supports JSON and ATOM+XML results based on Accept headers. Supports OData query parameters:
<ul><li>$select=col1,col2,abc/col3</li><li>$filter=col1 eq 'foo' and startswith(col2, 'baz')</li><li>$orderby=col1,abc/col3</li><li>$top=1000</li><li>$options=GrandTotal=true</li><li>$context=foo</li><li>$format=json</li></ul>
## Filter Operators: ##

ints: eq =, ne, le, lt, gt, ge, set, equals, greater, less, unequals, between

strings: contains, is, notBegins, notContains, isNot

associate: associateIsOneOf, associateIsNotOneOf,  

list ids: oneOf, NotOneOf, 

dates: before, date, after, dateBetween, beforeToday

Unary ops: currentAssociate, beforeToday, today, afterToday, lastWeek, thisWeek, nextWeek, lastMonth, thisMonth, nextMonth, lastQuarter, thisQuarter, nextQuarter, thisHalf, thisYear

Funcs: substringof(a,b), startswith(a,b), endswith(a,b), this(f,period), next(f,n,period), previous(f,n,period), thisAndNext(f,n,period), thisAndPrevious(f,n,period), thisAndPreviousAndNext(f,period)


OData returns XML or JSON carriers depending on the Accept headers. $format can also be used to 
control the response format via the URL. 

## Aggregation operators

The column names can encode grouping and summarizing.
You add functions and modifiers to the column name to trigger aggregation.
* GroupBy(col)
* Sum(col)
* Avg(col)
* Percent(col)
* Count(col)
* CountAll(col)
* DatePart(col)



You add modifiers to the end of the column name to trigger aggregation.
* :Header
* :Footer
* :HideDetail


DatePart specific modifiers
* :Year
* :Quarter
* :Month
* :Day
* :DayOfYear
* :DayOfWeek
* :Hour
* :Weekno
* :YearMonth
* :YearWeekno
* :YearQuarter


Example: group last names together, and inject a header row for each group.

```

GroupBy(lastName):Header

```

Example: count instances of middle names, and hide the individual rows, 
report just the totals for each group using a footer. Note how the modifiers stack.

```

Count(middleName):HideDetail:Footer

```

Example: the aggregator functions can nest, so you can say

```

GroupBy(DatePart(personUpdatedDate):YearMonth):Header

```

Some simple queries can be used to filter and simplify the result list:

```

GET api/archives/$metadata
GET api/archives/findContact
GET api/archives/findContact?$top=20
GET api/archives/findContact?$select=nameDepartment,fullname
GET api/archives/findContact?$filter=name begins 'foo'
GET api/archives/findContact?$filter=thisAndPrevious(registered, 2, 'weeks')
GET api/archives/findContact?$select=nameDepartment,fullname&amp;$filter=name begins 'foo'

```





| Path Part | Type | Description |
|-----------|------|-------------|
| archiveProviderName | string | Archive Provider name: FindContact, Person, Product, etc. Call with blank name to get a list of names. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Comma separated list of column names to return. "nameDepartment,fullname,category". Can also use aggregation functions and modifiers: "Count(category):Footer" |
| $filter | string |  Expression to restrict the results. e.g.: "name begins 'foo' and category gt 1". |
| $orderBy | string |  Comma separated list of column names to sort by, with optional direction. "name asc,fullname,category desc" |
| $entities | string |  Comma separated list of entity names to use. Default = "", which means all entities. "contact, person" |
| $top | int32 |  Number of rows to return in results. |
| $skip | int32 |  Number of rows to skip before returning results. |
| $mode | Enum: Slim, Wide, Full |  FULL (with raw values and hints for each value) or SLIM (just the display values) |
| $options | string |  Provider specific options. e.g: "GrandTotal=true" |
| $context | string |  Provider specific context parameter. Usually blank. |
| $format | string |  Set XML or JSON output format, override the format determined from Accept header. |
| $metadata | string |  Default: "ALL" to return description of all columns. Overrides $select and other parameters. |
| $inlineCount | Enum: False, Estimate, True, AllPages |  Determine how/if row count is returned in the result |
| $jsonSafe | bool |  Make output names into JSON safe property names. Replace all unsafe characters with _ underscore. |
| $output | Enum: Logical, Display |  Return Logical or Display values in SLIM mode. Logical returns true/false for booleans, Display returns icon hints. Dates are always returned as ISO strings. |

```http
GET /api/v1/Archive/{archiveProviderName}?$select=name,department,category/id
GET /api/v1/Archive/{archiveProviderName}?$filter=name begins 'S'
GET /api/v1/Archive/{archiveProviderName}?$orderBy=name asc
GET /api/v1/Archive/{archiveProviderName}?$entities=voluptatem
GET /api/v1/Archive/{archiveProviderName}?$top=953
GET /api/v1/Archive/{archiveProviderName}?$skip=607
GET /api/v1/Archive/{archiveProviderName}?$mode=Full
GET /api/v1/Archive/{archiveProviderName}?$options=GrandTotal=true
GET /api/v1/Archive/{archiveProviderName}?$context=distinctio
GET /api/v1/Archive/{archiveProviderName}?$format=JSON
GET /api/v1/Archive/{archiveProviderName}?$metadata=dicta
GET /api/v1/Archive/{archiveProviderName}?$inlineCount=AllPages
GET /api/v1/Archive/{archiveProviderName}?$jsonSafe=True
GET /api/v1/Archive/{archiveProviderName}?$output=Display
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Easy to use archive results - just a flat list of values.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| odata.metadata | string |  |
| odata.nextLink | string |  |
| value | array |  |

## Sample Request

```http!
GET /api/v1/Archive/{archiveProviderName}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "consequatur",
  "value": [
    {
      "PrimaryKey": 3690,
      "EntityName": "sale",
      "saleId": 3690,
      "contactId": 2505,
      "name": "Kiehn-McKenzie"
    },
    {
      "PrimaryKey": 5381,
      "EntityName": "sale",
      "saleId": 5381,
      "contactId": 364,
      "name": "Mayert Group"
    }
  ]
}
```