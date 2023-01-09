---
title: POST Agents/Import/CreateErpImportData
uid: v1ImportAgent_CreateErpImportData
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Import/CreateErpImportData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Restriction": [
    {
      "Name": "Rutherford-Cassin",
      "Operator": "quisquam",
      "Values": [
        "quam",
        "nulla"
      ],
      "DisplayValues": [
        "aut",
        "laboriosam"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 972,
      "InterOperator": "And",
      "UniqueHash": 265
    }
  ],
  "Columns": [
    "numquam",
    "et"
  ],
  "ConnectionId": 969,
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
        "ea",
        "quibusdam"
      ],
      "Selected": true,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "quia",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 350
        }
      }
    }
  ],
  "ColumnInfos": [
    {
      "Name": "Krajcik Inc and Sons",
      "DisplayName": "Keeling LLC",
      "Locked": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    },
    {
      "Name": "Krajcik Inc and Sons",
      "DisplayName": "Keeling LLC",
      "Locked": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 557
    }
  }
}
```