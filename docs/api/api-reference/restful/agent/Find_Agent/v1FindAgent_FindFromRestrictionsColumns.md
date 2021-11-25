---
title: POST Agents/Find/FindFromRestrictionsColumns
id: v1FindAgent_FindFromRestrictionsColumns
---

# POST Agents/Find/FindFromRestrictionsColumns

```http
POST /api/v1/Agents/Find/FindFromRestrictionsColumns
```

Execute a Find operation and return a page of results.

&lt;para/&gt;The criteria for the Find are passed in directly, not fetched by a restriction storage provider. &lt;para/&gt;The desired columns of the result set are also passed in directly.&lt;para/&gt;The orderby information is calculated by the system.&lt;para/&gt;Use the GetCriteriaInformation and GetDefaultDesiredColumns service methods to let the system calculate these values, if you want to use or modify them. 
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
POST /api/v1/Agents/Find/FindFromRestrictionsColumns?$select=name,department,category/id
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

Restrictions, ProviderName, DesiredColumns, PageSize, PageNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restrictions | array |  |
| ProviderName | string |  |
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
POST /api/v1/Agents/Find/FindFromRestrictionsColumns
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Davis-Purdy",
      "Operator": "earum",
      "Values": [
        "ut",
        "veniam"
      ],
      "DisplayValues": [
        "dolorum",
        "quis"
      ],
      "ColumnInfo": {},
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 180,
      "InterOperator": "And",
      "UniqueHash": 996
    }
  ],
  "ProviderName": "Halvorson-Kreiger",
  "DesiredColumns": [
    "ducimus",
    "velit"
  ],
  "PageSize": 581,
  "PageNumber": 837
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumns": [
    {
      "DisplayName": "Schoen, Kris and Hyatt",
      "DisplayTooltip": "quasi",
      "DisplayType": "aut",
      "CanOrderBy": false,
      "Name": "Weber-Wiegand",
      "CanRestrictBy": false,
      "RestrictionType": "eaque",
      "RestrictionListName": "Schaden, Rau and Stanton",
      "IsVisible": true,
      "ExtraInfo": "harum",
      "Width": "voluptatem",
      "IconHint": "numquam",
      "HeadingIconHint": "magnam"
    }
  ],
  "ArchiveRows": [
    {
      "EntityName": "Gibson, Padberg and Smith",
      "PrimaryKey": 26,
      "ColumnData": {
        "fieldName": {
          "DisplayValue": "corporis",
          "TooltipHint": "fuga",
          "LinkHint": "fugiat"
        }
      },
      "LinkHint": "dolorem",
      "StyleHint": "quasi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "RowCount": 191,
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
      "FieldLength": 760
    }
  }
}
```