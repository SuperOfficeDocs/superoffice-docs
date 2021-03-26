---
title: POST Agents/Archive/GetArchiveListWithContext
id: v1ArchiveAgent_GetArchiveListWithContext
---

# POST Agents/Archive/GetArchiveListWithContext

```http
POST /api/v1/Agents/Archive/GetArchiveListWithContext
```

Get a page of data for an archive, with context parameter.

The columns returned will be those set as chosen columns, using either the SetChosenColumns service or the corresponding SelectableMDOList.SetSelected. 
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
POST /api/v1/Agents/Archive/GetArchiveListWithContext?$select=name,department,category/id
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

GuiName, ProviderName, SortOrder, Restriction, Entities, Page, PageSize, Context 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GuiName | string |  |
| ProviderName | string |  |
| SortOrder | array |  |
| Restriction | array |  |
| Entities | array |  |
| Page | int32 |  |
| PageSize | int32 |  |
| Context | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| EntityName | string | The entity name of the ArchiveListItem. An ArchiveList may contain rows from different entities. |
| PrimaryKey | int32 | The  primary key for the row |
| ColumnData | object | Dictionary of column name - column data items. Each column data item contains a display value, a tooltip hint, a link hint, and an orderby value. &lt;para/&gt;The display value is encoded by the CultureDataFormatter and can be decoded / localized by that class; all other values are optional. &lt;para/&gt;Tooltip hints can be passed to the TooltipProvider (Tooltip service) to be translated into an actual tootip. |
| LinkHint | string | Link hint for the row, indicating things like navigation links that can be presented as clickable hyperlinks |
| StyleHint | string | Style hint for the row, for instance 'retired' for associates or 'private' for appointments. Presentation layers can interpret the style hints as they see fit. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Archive/GetArchiveListWithContext
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "GuiName": "Dicki, Spinka and Mayert",
  "ProviderName": "Witting Inc and Sons",
  "SortOrder": [
    {
      "Name": "Walter-D'Amore",
      "Direction": "ASC"
    },
    {
      "Name": "Walter-D'Amore",
      "Direction": "ASC"
    }
  ],
  "Restriction": [
    {
      "Name": "Prohaska, Bartell and Treutel",
      "Operator": "iusto",
      "Values": [
        "est",
        "aut"
      ],
      "DisplayValues": [
        "et",
        "et"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 415,
      "InterOperator": "And",
      "UniqueHash": 1000
    }
  ],
  "Entities": [
    "libero",
    "dolorum"
  ],
  "Page": 985,
  "PageSize": 833,
  "Context": "eius"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "EntityName": "Ratke LLC",
    "PrimaryKey": 559,
    "ColumnData": {
      "fieldName": {
        "DisplayValue": "ex",
        "TooltipHint": "quas",
        "LinkHint": "sit"
      }
    },
    "LinkHint": "velit",
    "StyleHint": "consectetur",
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
        "FieldLength": 79
      }
    }
  }
]
```