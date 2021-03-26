---
title: POST Agents/Archive/GetAvailableEntities
id: v1ArchiveAgent_GetAvailableEntities
---

# POST Agents/Archive/GetAvailableEntities

```http
POST /api/v1/Agents/Archive/GetAvailableEntities
```

Return list of all entities supported by an archive provider.

See also GetArchiveConfiguration. 

Archive Restriction strings are OData or SQL-ish.
Column names are documented in <a href="../../../Reference/Archive%20Providers/Archive%20providers.htm">Archive Provider Names</a>

## Binary operators
* =, eq, equals
* &lt;, lt, less
* &lt;=, le
* &gt;, gt
* &gt;=, ge
* ne, unequals
* between
* set
* begins
* contains
* is
* isNot
* notContains
* associateIsOneOf
* associateIsNotOneOf
* oneOf, in
* notOneOf
* before
* date
* after
* dateBetween




For example:

```

"name begins 'Super'"
"category = 3"
"category in (2,3,4)"
"xstop set"
"registered after '2014.3.4'"
"registered dateBetween ('2014.11.29', '2014.12.25')"

```
## Unary operators
* currentAssociate
* beforeToday
* today
* afterToday
* lastWeek
* thisWeek
* nextWeek
* lastMonth
* thisMonth
* nextMonth
* lastQuarter
* nextQuarter
* thisHalf
* thisYear


For example:

```
"updatedDate lastWeek", "assocId currentAssociate"
```


## Brackets and or
AND and OR can be used to combine terms. AND has a higher priority than OR

```
"business = 2  AND name contains 'super'"
```

Brackets can be used for grouping.

```
"(business = 2 or category = 3) and name contains 'super'"
```


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
## Strings

Use the begins or contains operators to do string searches.
You can also use the normal = operator to do string exact match checks.



Use backslash to escape single quotes in strings
(note that backslash needs to be doubled because c# also uses backslash escapes):


```
"department contains 'Bob\\'s'"
```








## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetAvailableEntities?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ProviderName, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Context | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ChildItems | array | The child items of the MDOListItem |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| FullName | string | The name of the ListItem in its context |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/GetAvailableEntities
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Goyette, Mann and Kemmer",
  "Context": "voluptas"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 295,
    "Name": "Olson-White",
    "ToolTip": "Accusantium accusantium reprehenderit.",
    "Deleted": false,
    "Rank": 935,
    "Type": "soluta",
    "ChildItems": [
      {
        "Id": 999,
        "Name": "Fahey-Trantow",
        "ToolTip": "Ut labore aliquam est velit enim.",
        "Deleted": true,
        "Rank": 480,
        "Type": "perspiciatis",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "explicabo",
        "ColorBlock": 187,
        "ExtraInfo": "ea",
        "StyleHint": "omnis",
        "FullName": "Alejandrin Thompson",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 338
          }
        }
      }
    ],
    "IconHint": "natus",
    "ColorBlock": 267,
    "ExtraInfo": "iusto",
    "StyleHint": "corporis",
    "FullName": "Davion Feest MD",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "syndicate visionary solutions"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 484
      }
    }
  }
]
```