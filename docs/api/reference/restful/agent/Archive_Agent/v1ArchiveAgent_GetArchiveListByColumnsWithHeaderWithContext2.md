---
title: POST Agents/Archive/GetArchiveListByColumnsWithHeaderWithContext2
uid: v1ArchiveAgent_GetArchiveListByColumnsWithHeaderWithContext2
---

# POST Agents/Archive/GetArchiveListByColumnsWithHeaderWithContext2

```http
POST /api/v1/Agents/Archive/GetArchiveListByColumnsWithHeaderWithContext2
```

Get a page of results for an archive list, with context parameter, explicitly specifying the restrictions as strings, orderby and chosen columns; as well as a name/value string formatted set of options.

The return value includes a header that has various extra information, in addition to the actual rows.

Archive Restriction strings are OData or SQL-ish.
They are parsed and converted into ArchiveRestrictions.

For example:

```

"name begins 'Super'"
"category = 3"
"category in (2,3,4)"
"xstop set"
"registered after '2014.3.4'"
"registered dateBetween ('2014.11.29', '2014.12.25')"

```

Unary operators:

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
POST /api/v1/Agents/Archive/GetArchiveListByColumnsWithHeaderWithContext2?$select=name,department,category/id
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

ProviderName, Columns, SortOrder, Restriction, Entities, Page, PageSize, Options, Context

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | string |  |
| Columns | string |  |
| SortOrder | string |  |
| Restriction | string |  |
| Entities | string |  |
| Page | int32 |  |
| PageSize | int32 |  |
| Options | string |  |
| Context | string |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| RowCount | int32 | Count of rows, independent of paging. If you order up page 1 with page size 50, the row count may still be 279, that being the number of rows that would have been returned in a  paging-off situation |
| Rows | array | The actual rows, according to the paging info, of the result. See RowCount for a paging-independent count estimate |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Archive/GetArchiveListByColumnsWithHeaderWithContext2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Lang LLC",
  "Columns": "id",
  "SortOrder": "nobis",
  "Restriction": "quia",
  "Entities": "velit",
  "Page": 435,
  "PageSize": 598,
  "Options": "qui",
  "Context": "quas"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RowCount": 730,
  "Rows": [
    {
      "EntityName": "Schimmel Inc and Sons",
      "PrimaryKey": 453,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "voluptas",
          "TooltipHint": "iusto",
          "LinkHint": "possimus"
        }
      },
      "LinkHint": "iure",
      "StyleHint": "eligendi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 446
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 612
    }
  }
}
```
