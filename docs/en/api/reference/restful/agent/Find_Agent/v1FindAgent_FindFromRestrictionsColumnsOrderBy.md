---
title: POST Agents/Find/FindFromRestrictionsColumnsOrderBy
uid: v1FindAgent_FindFromRestrictionsColumnsOrderBy
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
      "Name": "Williamson Inc and Sons",
      "Operator": "autem",
      "Values": [
        "possimus",
        "sunt"
      ],
      "DisplayValues": [
        "accusamus",
        "culpa"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 260,
      "InterOperator": "And",
      "UniqueHash": 544
    }
  ],
  "ProviderName": "Rempel, Marquardt and Schuppe",
  "DesiredColumns": [
    "nulla",
    "reiciendis"
  ],
  "OrderBy": [
    {
      "Name": "Upton-Frami",
      "Direction": "ASC"
    },
    {
      "Name": "Upton-Frami",
      "Direction": "ASC"
    }
  ],
  "PageSize": 331,
  "PageNumber": 178
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Emard-Douglas",
      "DisplayTooltip": "tenetur",
      "DisplayType": "pariatur",
      "CanOrderBy": false,
      "Name": "Marvin-Reynolds",
      "CanRestrictBy": false,
      "RestrictionType": "in",
      "RestrictionListName": "Hagenes, Gerlach and Sanford",
      "IsVisible": false,
      "ExtraInfo": "nulla",
      "Width": "voluptas",
      "IconHint": "quasi",
      "HeadingIconHint": "explicabo"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Wilderman-Rau",
      "PrimaryKey": 35,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "sunt",
          "TooltipHint": "voluptatibus",
          "LinkHint": "aut"
        }
      },
      "LinkHint": "culpa",
      "StyleHint": "facere",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 49
        }
      }
    }
  ],
  "RowCount": 754,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 438
    }
  }
}
```