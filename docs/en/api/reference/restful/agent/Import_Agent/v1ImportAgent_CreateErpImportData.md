---
title: POST Agents/Import/CreateErpImportData
uid: v1ImportAgent_CreateErpImportData
generated: true
content_type: reference
---

# POST Agents/Import/CreateErpImportData

```http
POST /api/v1/Agents/Import/CreateErpImportData
```

Populates the ImportLines and columnDefs basedfrom erp system







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Import/CreateErpImportData?$select=name,department,category/id
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

Restriction, Columns, ConnectionId, ErpActorType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Restriction | Array |  |
| Columns | Array |  |
| ConnectionId | Integer |  |
| ErpActorType | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ImportErpData

| Property Name | Type |  Description |
|----------------|------|--------------|
| ImportLines | array | An array of Import lines |
| ColumnInfos | array | Array of column definitions |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Import/CreateErpImportData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Restriction": [
    {
      "Name": "Swaniawski Group",
      "Operator": "ipsa",
      "Values": [
        "enim",
        "nemo"
      ],
      "DisplayValues": [
        "quasi",
        "rerum"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 819,
      "InterOperator": "And",
      "UniqueHash": 293
    }
  ],
  "Columns": [
    "ex",
    "excepturi"
  ],
  "ConnectionId": 509,
  "ErpActorType": "Customer"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ImportLines": [
    {
      "Values": [
        "et",
        "unde"
      ],
      "Selected": false,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "est",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    }
  ],
  "ColumnInfos": [
    {
      "Name": "Volkman Inc and Sons",
      "DisplayName": "Kirlin-Jewess",
      "Locked": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    },
    {
      "Name": "Volkman Inc and Sons",
      "DisplayName": "Kirlin-Jewess",
      "Locked": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 848
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 206
    }
  }
}
```