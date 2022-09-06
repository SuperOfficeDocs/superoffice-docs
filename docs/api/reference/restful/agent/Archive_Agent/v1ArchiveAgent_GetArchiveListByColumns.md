---
title: POST Agents/Archive/GetArchiveListByColumns
uid: v1ArchiveAgent_GetArchiveListByColumns
---

# POST Agents/Archive/GetArchiveListByColumns

```http
POST /api/v1/Agents/Archive/GetArchiveListByColumns
```

Get a page of results for an archive list, explicitly specifying the restrictions, orderby and chosen columns.

Archive Restriction Info objects represent search terms.

Column names and operator strings are defined elsewhere.

Values should be encoded using the CultureDataFormatter, so 10 is "[I:10]".
Default string encodings should be handled ok, but beware of non-invariant cultures leading to incorrect date and float parsing.

```

var restriction1 = new ArchiveRestrictionInfo("category", "equals", "[I:10]");

```

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Archive/GetArchiveListByColumns?$select=name,department,category/id
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

ProviderName, Columns, SortOrder, Restriction, Entities, Page, PageSize

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Columns | array |  |
| SortOrder | array |  |
| Restriction | array |  |
| Entities | array |  |
| Page | int32 |  |
| PageSize | int32 |  |

## Response: array

OK

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

## Sample request

```http!
POST /api/v1/Agents/Archive/GetArchiveListByColumns
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Greenholt Inc and Sons",
  "Columns": [
    "debitis",
    "amet"
  ],
  "SortOrder": [
    {
      "Name": "Littel Inc and Sons",
      "Direction": "ASC"
    },
    {
      "Name": "Littel Inc and Sons",
      "Direction": "ASC"
    }
  ],
  "Restriction": [
    {
      "Name": "Paucek, Kuphal and Turner",
      "Operator": "corrupti",
      "Values": [
        "voluptatem",
        "nobis"
      ],
      "DisplayValues": [
        "velit",
        "commodi"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 938,
      "InterOperator": "And",
      "UniqueHash": 981
    }
  ],
  "Entities": [
    "voluptas",
    "atque"
  ],
  "Page": 144,
  "PageSize": 422
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "EntityName": "Fadel LLC",
    "PrimaryKey": 270,
    "ColumnData": {
      "fieldName": {
        "DisplayValue": "molestiae",
        "TooltipHint": "accusamus",
        "LinkHint": "officiis"
      }
    },
    "LinkHint": "est",
    "StyleHint": "molestiae",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 416
      }
    }
  }
]
```
