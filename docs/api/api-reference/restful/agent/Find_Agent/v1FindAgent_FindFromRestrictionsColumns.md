---
title: POST Agents/Find/FindFromRestrictionsColumns
id: v1FindAgent_FindFromRestrictionsColumns
---

# POST Agents/Find/FindFromRestrictionsColumns

```http
POST /api/v1/Agents/Find/FindFromRestrictionsColumns
```

Execute a Find operation and return a page of results.

&lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is calculated by the system.&lt;para/&gt;Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them. 
Archive Restriction Info objects represent search terms.



See the <a href="../../../Reference/Archive%20Providers/-Restriction%20Types.htm">
restriction types reference for
operator details
</a>.



Column names are documented in <a href="../../../Reference/Archive%20Providers/Archive%20providers.htm">Archive Provider Names</a>




## Aggregation operators


The column names can encode grouping and summarizing.
You add modifiers to the end of the column name to trigger aggregation.
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








## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/FindFromRestrictionsColumns?$select=name,department,category/id
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

Restrictions, ProviderName, DesiredColumns, PageSize, PageNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restrictions | array |  |
| ProviderName | string |  |
| DesiredColumns | array |  |
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
POST /api/v1/Agents/Find/FindFromRestrictionsColumns
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Waters Group",
      "Operator": "mollitia",
      "Values": [
        "similique",
        "aut"
      ],
      "DisplayValues": [
        "labore",
        "dolorem"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 157,
      "InterOperator": "And",
      "UniqueHash": 700
    }
  ],
  "ProviderName": "Franecki-Oberbrunner",
  "DesiredColumns": [
    "qui",
    "omnis"
  ],
  "PageSize": 829,
  "PageNumber": 940
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Will LLC",
      "DisplayTooltip": "ipsam",
      "DisplayType": "voluptas",
      "CanOrderBy": false,
      "Name": "Weimann, Schoen and Prosacco",
      "CanRestrictBy": false,
      "RestrictionType": "perferendis",
      "RestrictionListName": "Zboncak LLC",
      "IsVisible": false,
      "ExtraInfo": "autem",
      "Width": "et",
      "IconHint": "necessitatibus",
      "HeadingIconHint": "dolore"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Harris, Schuppe and Boehm",
      "PrimaryKey": 450,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "fugiat",
          "TooltipHint": "cumque",
          "LinkHint": "voluptatem"
        }
      },
      "LinkHint": "quae",
      "StyleHint": "voluptate",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 875
        }
      }
    }
  ],
  "RowCount": 502,
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
      "FieldType": "System.Int32",
      "FieldLength": 14
    }
  }
}
```