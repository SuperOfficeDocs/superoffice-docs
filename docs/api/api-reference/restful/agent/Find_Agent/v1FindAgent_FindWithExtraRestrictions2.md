---
title: POST Agents/Find/FindWithExtraRestrictions2
id: v1FindAgent_FindWithExtraRestrictions2
---

# POST Agents/Find/FindWithExtraRestrictions2

```http
POST /api/v1/Agents/Find/FindWithExtraRestrictions2
```

Execute a Find operation and return a page of results.

The criteria for the Find are fetched from the restriction storage provider according to the given parameters. In addition an extra set of restrictions can be added to the search. These restrictions will not be saved, they are only valid for the current search. Extra restrictions will override restrictions with the same key already stored on the storagekey. 

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
POST /api/v1/Agents/Find/FindWithExtraRestrictions2?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, ExtraRestrictions, OrderBy, DesiredColumns, PageSize, PageNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| ExtraRestrictions | string |  |
| OrderBy | string |  |
| DesiredColumns | string |  |
| PageSize | int32 |  |
| PageNumber | int32 |  |


## Response: object

Result carrier for the Find operation. It contains a set of column specifications, and a set of row, where each row contains the columns. The row set is the result of carrying out some search operation.



Carrier object for FindResults.
Services for the FindResults Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IFindAgent">Find Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ArchiveColumns | array | Array of ColumnInfo column specifications |
| ArchiveRows | array | Array of archive list items, i.e., the service layer carrier for archive rows. These are the find results, represented as archive rows |
| RowCount | int32 | Count of rows, independent of paging. If you order up page 1 with page size 50, the row count may still be 279, that being the number of rows that would have been returned in a  paging-off situation |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Find/FindWithExtraRestrictions2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StorageType": "quis",
  "ProviderName": "Schulist, Runte and Casper",
  "StorageKey": "sit",
  "ExtraRestrictions": "veritatis",
  "OrderBy": "qui",
  "DesiredColumns": "enim",
  "PageSize": 35,
  "PageNumber": 648
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "McGlynn, Feil and Tremblay",
      "DisplayTooltip": "dicta",
      "DisplayType": "autem",
      "CanOrderBy": false,
      "Name": "Denesik, Hills and Mueller",
      "CanRestrictBy": false,
      "RestrictionType": "esse",
      "RestrictionListName": "Miller, Muller and Dibbert",
      "IsVisible": true,
      "ExtraInfo": "voluptatem",
      "Width": "quis",
      "IconHint": "doloremque",
      "HeadingIconHint": "molestiae"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "DuBuque Group",
      "PrimaryKey": 852,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "sit",
          "TooltipHint": "iusto",
          "LinkHint": "aspernatur"
        }
      },
      "LinkHint": "nulla",
      "StyleHint": "eius",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 62
        }
      }
    }
  ],
  "RowCount": 926,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 746
    }
  }
}
```