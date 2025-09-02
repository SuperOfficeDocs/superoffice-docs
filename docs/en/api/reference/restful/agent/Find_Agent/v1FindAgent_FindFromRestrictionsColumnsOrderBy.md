---
title: POST Agents/Find/FindFromRestrictionsColumnsOrderBy
uid: v1FindAgent_FindFromRestrictionsColumnsOrderBy
generated: true
content_type: reference
---

# POST Agents/Find/FindFromRestrictionsColumnsOrderBy

```http
POST /api/v1/Agents/Find/FindFromRestrictionsColumnsOrderBy
```

Execute a Find operation and return a page of results.


&lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is also passed in directly.&lt;para/&gt;Use the GetCriteriaInformation, GetDefaultDesiredColumns and GetDefaultOrderBy service methods to let the system calculate these values, if you want to use or modify them.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Find/FindFromRestrictionsColumnsOrderBy?$select=name,department,category/id
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

Restrictions, ProviderName, DesiredColumns, OrderBy, PageSize, PageNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restrictions | Array |  |
| ProviderName | String |  |
| DesiredColumns | Array |  |
| OrderBy | Array |  |
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
POST /api/v1/Agents/Find/FindFromRestrictionsColumnsOrderBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Heidenreich Group",
      "Operator": "fuga",
      "Values": [
        "qui",
        "sequi"
      ],
      "DisplayValues": [
        "enim",
        "magni"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 452,
      "InterOperator": "And",
      "UniqueHash": 930
    }
  ],
  "ProviderName": "Hyatt-Johnson",
  "DesiredColumns": [
    "et",
    "quas"
  ],
  "OrderBy": [
    {
      "Name": "Bradtke LLC",
      "Direction": "ASC"
    },
    {
      "Name": "Bradtke LLC",
      "Direction": "ASC"
    }
  ],
  "PageSize": 276,
  "PageNumber": 631
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Jewess, Gislason and Veum",
      "DisplayTooltip": "maxime",
      "DisplayType": "facilis",
      "CanOrderBy": false,
      "Name": "Greenfelder, Treutel and Predovic",
      "CanRestrictBy": false,
      "RestrictionType": "quo",
      "RestrictionListName": "Smitham-Walter",
      "IsVisible": true,
      "ExtraInfo": "doloremque",
      "Width": "necessitatibus",
      "IconHint": "quos",
      "HeadingIconHint": "quia"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Schroeder LLC",
      "PrimaryKey": 867,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "odit",
          "TooltipHint": "distinctio",
          "LinkHint": "ratione"
        }
      },
      "LinkHint": "perferendis",
      "StyleHint": "facere",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    }
  ],
  "RowCount": 937,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 984
    }
  }
}
```