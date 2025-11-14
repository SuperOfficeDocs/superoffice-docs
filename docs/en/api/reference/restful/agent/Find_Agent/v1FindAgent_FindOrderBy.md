---
title: POST Agents/Find/FindOrderBy
uid: v1FindAgent_FindOrderBy
generated: true
content_type: reference
---

# POST Agents/Find/FindOrderBy

```http
POST /api/v1/Agents/Find/FindOrderBy
```

Execute a Find operation and return a page of results.


The criteria for the Find are fetched from the restriction storage provider according to the given parameters. The columns of the result are calculated based on the restriction. The orderby parameter is used for sorting the results.&lt;para/&gt;The other variants of the Find method allow you greater control over the individual aspects of the process.
NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/FindOrderBy?$select=name,department,category/id
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

StorageType, ProviderName, StorageKey, PageSize, PageNumber, OrderBy 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| PageSize | Integer |  |
| PageNumber | Integer |  |
| OrderBy | Array |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: FindResults

| Property Name | Type |  Description |
|----------------|------|--------------|
| ArchiveColumns | array | Array of ColumnInfo column specifications |
| ArchiveRows | array | Array of archive list items, i.e., the service layer carrier for archive rows. These are the find results, represented as archive rows |
| RowCount | int32 | Count of rows, independent of paging. If you order up page 1 with page size 50, the row count may still be 279, that being the number of rows that would have been returned in a  paging-off situation |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Find/FindOrderBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "StorageType": "ipsum",
  "ProviderName": "Streich, Klocko and Casper",
  "StorageKey": "fugiat",
  "PageSize": 719,
  "PageNumber": 893,
  "OrderBy": [
    {
      "Name": "Stiedemann-Bartell",
      "Direction": "ASC"
    },
    {
      "Name": "Stiedemann-Bartell",
      "Direction": "ASC"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Langosh Group",
      "DisplayTooltip": "nemo",
      "DisplayType": "est",
      "CanOrderBy": true,
      "Name": "Wyman LLC",
      "CanRestrictBy": false,
      "RestrictionType": "necessitatibus",
      "RestrictionListName": "Pouros-Hackett",
      "IsVisible": false,
      "ExtraInfo": "ipsa",
      "Width": "numquam",
      "IconHint": "qui",
      "HeadingIconHint": "quo"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Torphy Group",
      "PrimaryKey": 561,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "sed",
          "TooltipHint": "dolores",
          "LinkHint": "beatae"
        }
      },
      "LinkHint": "sint",
      "StyleHint": "ipsa",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    }
  ],
  "RowCount": 304,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 798
    }
  }
}
```