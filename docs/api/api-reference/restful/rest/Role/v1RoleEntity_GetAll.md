---
title: GET Role
id: v1RoleEntity_GetAll
---

# GET Role

```http
GET /api/v1/Role
```

OData list of all RoleEntity.

Can be sorted and further filtered using OData conventions:

* Role?$select=col1,col2,abc/col3
* Role?$filter=col1 eq 'foo' and startswith(col2, 'baz')
* Role?$orderby=abc/col3,col1
* Role?$top=1000
* Role?$mode=full


OData returns XML or JSON carriers depending on the Accept headers.


Calls the Archive service using the "Role" archive.


## Filter Operators: ##

ints: eq =, ne, le, lt, gt, ge, set, equals, greater, less, unequals, between

strings: contains, is, notBegins, notContains, isNot

associate: associateIsOneOf, associateIsNotOneOf,  

list ids: oneOf, NotOneOf, 

dates: before, date, after, dateBetween, beforeToday

Unary ops: currentAssociate, beforeToday, today, afterToday, lastWeek, thisWeek, nextWeek, lastMonth, thisMonth, nextMonth, lastQuarter, thisQuarter, nextQuarter, thisHalf, thisYear

Funcs: substringof(a,b), startswith(a,b), endswith(a,b), this(f,period), next(f,n,period), previous(f,n,period), thisAndNext(f,n,period), thisAndPrevious(f,n,period), thisAndPreviousAndNext(f,period)






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Comma separated list of column names to return. "nameDepartment,fullname,category". Can also use aggregation functions and modifiers: "Count(category):Footer" |
| $filter | string |  Expression to restrict the results. e.g.: "name begins 'foo' and category gt 1" |
| $orderBy | string |  Comma separated list of column names to sort by, with optional direction. "name asc,fullname,category desc" |
| $entities | string |  Comma separated list of entity names to use. Default = "". "contact, person" |
| $top | int32 |  Number of rows to return in results |
| $skip | int32 |  Number of rows from database to skip before returning results |
| $mode | Enum: Slim, Wide, Full |  FULL (with raw values and hints for each value) or SLIM (just the display values) |
| $options | string |  Provider specific options. e.g: "GrandTotal=true" |
| $context | string |  Provider specific context parameter. |
| $format | string |  Set XML or JSON output format; override the format determined from Accept header. |
| $jsonSafe | bool |  Make output names into JSON safe property names. Replace all unsafe characters with _ underscore. |
| $output | Enum: Logical, Display |  Return Logical or Display values in SLIM mode. Logical returns true/false for booleans, Display returns icon hints. Dates are always returned as ISO strings. |

```http
GET /api/v1/Role?$select=name,department,category/id
GET /api/v1/Role?$filter=name begins 'S'
GET /api/v1/Role?$orderBy=name asc
GET /api/v1/Role?$entities=dolore
GET /api/v1/Role?$top=131
GET /api/v1/Role?$skip=883
GET /api/v1/Role?$mode=Full
GET /api/v1/Role?$options=GrandTotal=true
GET /api/v1/Role?$context=quibusdam
GET /api/v1/Role?$format=JSON
GET /api/v1/Role?$jsonSafe=True
GET /api/v1/Role?$output=Display
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
GET /api/v1/Role
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "iusto",
  "value": [
    {
      "PrimaryKey": 8627,
      "EntityName": "sale",
      "saleId": 8627,
      "contactId": 513,
      "name": "Lueilwitz, Turner and McDermott"
    },
    {
      "PrimaryKey": 8760,
      "EntityName": "sale",
      "saleId": 8760,
      "contactId": 4908,
      "name": "Corwin Group"
    }
  ]
}
```