---
title: POST Agents/Find/FindFromRestrictionsColumnsOrderBy
uid: v1FindAgent_FindFromRestrictionsColumnsOrderBy
generated: true
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "O'Hara-Senger",
      "Operator": "nemo",
      "Values": [
        "fugiat",
        "totam"
      ],
      "DisplayValues": [
        "voluptatibus",
        "omnis"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 227,
      "InterOperator": "And",
      "UniqueHash": 121
    }
  ],
  "ProviderName": "Stanton LLC",
  "DesiredColumns": [
    "qui",
    "illum"
  ],
  "OrderBy": [
    {
      "Name": "Fritsch-Auer",
      "Direction": "ASC"
    },
    {
      "Name": "Fritsch-Auer",
      "Direction": "ASC"
    }
  ],
  "PageSize": 773,
  "PageNumber": 810
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Feest LLC",
      "DisplayTooltip": "eos",
      "DisplayType": "quo",
      "CanOrderBy": false,
      "Name": "Rau Group",
      "CanRestrictBy": true,
      "RestrictionType": "impedit",
      "RestrictionListName": "Price-Walker",
      "IsVisible": false,
      "ExtraInfo": "consequatur",
      "Width": "et",
      "IconHint": "dolores",
      "HeadingIconHint": "eligendi"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Predovic Inc and Sons",
      "PrimaryKey": 165,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "sunt",
          "TooltipHint": "reprehenderit",
          "LinkHint": "consequatur"
        }
      },
      "LinkHint": "cupiditate",
      "StyleHint": "quis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 97
        }
      }
    }
  ],
  "RowCount": 949,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 586
    }
  }
}
```