---
title: POST Agents/Find/FindWithExtraRestrictions
id: v1FindAgent_FindWithExtraRestrictions
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
| StorageType | string |  |
| ProviderName | string |  |
| StorageKey | string |  |
| ExtraRestrictions | array |  |
| OrderBy | array |  |
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
POST /api/v1/Agents/Find/FindWithExtraRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StorageType": "ex",
  "ProviderName": "Ledner Group",
  "StorageKey": "quasi",
  "ExtraRestrictions": [
    {
      "Name": "Pollich-O'Hara",
      "Operator": "aut",
      "Values": [
        "amet",
        "in"
      ],
      "DisplayValues": [
        "quia",
        "magnam"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 459,
      "InterOperator": "And",
      "UniqueHash": 370
    }
  ],
  "OrderBy": [
    {
      "Name": "Bradtke Inc and Sons",
      "Direction": "ASC"
    },
    {
      "Name": "Bradtke Inc and Sons",
      "Direction": "ASC"
    }
  ],
  "DesiredColumns": [
    "aliquid",
    "enim"
  ],
  "PageSize": 746,
  "PageNumber": 655
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Kuvalis-Welch",
      "DisplayTooltip": "deleniti",
      "DisplayType": "est",
      "CanOrderBy": false,
      "Name": "Spencer-Goyette",
      "CanRestrictBy": true,
      "RestrictionType": "consequatur",
      "RestrictionListName": "Runte, Leffler and Farrell",
      "IsVisible": true,
      "ExtraInfo": "dolorem",
      "Width": "consequatur",
      "IconHint": "ea",
      "HeadingIconHint": "sequi"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Schmeler-Hahn",
      "PrimaryKey": 769,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "dicta",
          "TooltipHint": "harum",
          "LinkHint": "esse"
        }
      },
      "LinkHint": "ab",
      "StyleHint": "doloremque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "RowCount": 250,
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
      "FieldLength": 545
    }
  }
}
```