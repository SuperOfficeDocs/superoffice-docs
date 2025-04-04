---
title: POST Agents/Find/FindWithExtraRestrictions
uid: v1FindAgent_FindWithExtraRestrictions
generated: true
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StorageType": "ipsa",
  "ProviderName": "Auer-Champlin",
  "StorageKey": "blanditiis",
  "ExtraRestrictions": [
    {
      "Name": "Macejkovic, Franecki and Hoeger",
      "Operator": "iusto",
      "Values": [
        "ea",
        "maiores"
      ],
      "DisplayValues": [
        "temporibus",
        "nihil"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 440,
      "InterOperator": "And",
      "UniqueHash": 756
    }
  ],
  "OrderBy": [
    {
      "Name": "Bechtelar-Prohaska",
      "Direction": "ASC"
    },
    {
      "Name": "Bechtelar-Prohaska",
      "Direction": "ASC"
    }
  ],
  "DesiredColumns": [
    "architecto",
    "architecto"
  ],
  "PageSize": 454,
  "PageNumber": 499
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Okuneva Group",
      "DisplayTooltip": "dignissimos",
      "DisplayType": "dolor",
      "CanOrderBy": false,
      "Name": "Lind-Hammes",
      "CanRestrictBy": false,
      "RestrictionType": "qui",
      "RestrictionListName": "Smitham, Ernser and Boyle",
      "IsVisible": false,
      "ExtraInfo": "tenetur",
      "Width": "dolore",
      "IconHint": "quisquam",
      "HeadingIconHint": "minus"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Tromp, Auer and Christiansen",
      "PrimaryKey": 666,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "consequatur",
          "TooltipHint": "similique",
          "LinkHint": "ea"
        }
      },
      "LinkHint": "et",
      "StyleHint": "magni",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 781
        }
      }
    }
  ],
  "RowCount": 197,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 916
    }
  }
}
```