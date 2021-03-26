---
title: POST Agents/Find/FindFromRestrictionsColumnsOrderBy
id: v1FindAgent_FindFromRestrictionsColumnsOrderBy
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
| Restrictions | array |  |
| ProviderName | string |  |
| DesiredColumns | array |  |
| OrderBy | array |  |
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
POST /api/v1/Agents/Find/FindFromRestrictionsColumnsOrderBy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Hegmann, Spencer and Hoeger",
      "Operator": "dolore",
      "Values": [
        "non",
        "nulla"
      ],
      "DisplayValues": [
        "illo",
        "id"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 236,
      "InterOperator": "And",
      "UniqueHash": 544
    }
  ],
  "ProviderName": "Mueller, Gusikowski and Nitzsche",
  "DesiredColumns": [
    "ut",
    "illo"
  ],
  "OrderBy": [
    {
      "Name": "Larson Group",
      "Direction": "ASC"
    },
    {
      "Name": "Larson Group",
      "Direction": "ASC"
    }
  ],
  "PageSize": 588,
  "PageNumber": 612
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Hegmann, Hane and Ernser",
      "DisplayTooltip": "odio",
      "DisplayType": "vel",
      "CanOrderBy": true,
      "Name": "Kessler, Mraz and Klein",
      "CanRestrictBy": false,
      "RestrictionType": "amet",
      "RestrictionListName": "Champlin Inc and Sons",
      "IsVisible": false,
      "ExtraInfo": "non",
      "Width": "natus",
      "IconHint": "rerum",
      "HeadingIconHint": "aut"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Schneider-Lakin",
      "PrimaryKey": 682,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "in",
          "TooltipHint": "voluptatem",
          "LinkHint": "dolor"
        }
      },
      "LinkHint": "et",
      "StyleHint": "eius",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    }
  ],
  "RowCount": 843,
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
      "FieldLength": 586
    }
  }
}
```