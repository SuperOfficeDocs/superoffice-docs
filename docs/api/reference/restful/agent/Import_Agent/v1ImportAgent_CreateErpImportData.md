---
title: POST Agents/Import/CreateErpImportData
id: v1ImportAgent_CreateErpImportData
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
| Restriction | array |  |
| Columns | array |  |
| ConnectionId | int32 |  |
| ErpActorType | string |  |


## Response: object

Used to import data into the system. Representing one entity that will be imported.



Carrier object for ImportErpData.
Services for the ImportErpData Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IImportAgent">Import Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ImportLines | array | An array of Import lines |
| ColumnInfos | array | Array of column definitions |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Import/CreateErpImportData
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Restriction": [
    {
      "Name": "VonRueden LLC",
      "Operator": "hic",
      "Values": [
        "sed",
        "consequatur"
      ],
      "DisplayValues": [
        "non",
        "molestiae"
      ],
      "ColumnInfo": {},
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 567,
      "InterOperator": "And",
      "UniqueHash": 191
    }
  ],
  "Columns": [
    "vel",
    "ex"
  ],
  "ConnectionId": 682,
  "ErpActorType": "Customer"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ImportLines": [
    {
      "Values": [
        "quia",
        "distinctio"
      ],
      "Selected": true,
      "Operation": "ContactAdded",
      "Type": "Contact",
      "ExternalKey": "accusamus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "ColumnInfos": [
    {
      "Name": "Hessel LLC",
      "DisplayName": "Bradtke, Bahringer and Hackett",
      "Locked": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    },
    {
      "Name": "Hessel LLC",
      "DisplayName": "Bradtke, Bahringer and Hackett",
      "Locked": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "incentivize visionary solutions"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 709
    }
  }
}
```