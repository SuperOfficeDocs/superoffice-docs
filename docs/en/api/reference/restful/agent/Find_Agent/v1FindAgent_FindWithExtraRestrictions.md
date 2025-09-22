---
title: POST Agents/Find/FindWithExtraRestrictions
uid: v1FindAgent_FindWithExtraRestrictions
generated: true
content_type: reference
---

# POST Agents/Find/FindWithExtraRestrictions

```http
POST /api/v1/Agents/Find/FindWithExtraRestrictions
```

Execute a Find operation and return a page of results.


The criteria for the Find are fetched from the restriction storage provider according to the given parameters. In addition an extra set of restrictions can be added to the search. These restrictions will not be saved, they are only valid for the current search. Extra restrictions will override restrictions with the same key already stored on the storagekey.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/FindWithExtraRestrictions?$select=name,department,category/id
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
| StorageType | String |  |
| ProviderName | String |  |
| StorageKey | String |  |
| ExtraRestrictions | Array |  |
| OrderBy | Array |  |
| DesiredColumns | Array |  |
| PageSize | Integer |  |
| PageNumber | Integer |  |

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
POST /api/v1/Agents/Find/FindWithExtraRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StorageType": "et",
  "ProviderName": "Kohler, Quigley and Block",
  "StorageKey": "quo",
  "ExtraRestrictions": [
    {
      "Name": "Hamill, Hilpert and Anderson",
      "Operator": "quis",
      "Values": [
        "beatae",
        "accusantium"
      ],
      "DisplayValues": [
        "occaecati",
        "quae"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 395,
      "InterOperator": "And",
      "UniqueHash": 352
    }
  ],
  "OrderBy": [
    {
      "Name": "Breitenberg, Wisozk and Marks",
      "Direction": "ASC"
    },
    {
      "Name": "Breitenberg, Wisozk and Marks",
      "Direction": "ASC"
    }
  ],
  "DesiredColumns": [
    "minus",
    "sequi"
  ],
  "PageSize": 448,
  "PageNumber": 432
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Gutkowski Group",
      "DisplayTooltip": "qui",
      "DisplayType": "est",
      "CanOrderBy": true,
      "Name": "Blick Inc and Sons",
      "CanRestrictBy": false,
      "RestrictionType": "odio",
      "RestrictionListName": "Zboncak LLC",
      "IsVisible": false,
      "ExtraInfo": "fugit",
      "Width": "eaque",
      "IconHint": "ratione",
      "HeadingIconHint": "excepturi"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Mitchell-Streich",
      "PrimaryKey": 747,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "perferendis",
          "TooltipHint": "sed",
          "LinkHint": "pariatur"
        }
      },
      "LinkHint": "dolores",
      "StyleHint": "ut",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 937
        }
      }
    }
  ],
  "RowCount": 927,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 797
    }
  }
}
```