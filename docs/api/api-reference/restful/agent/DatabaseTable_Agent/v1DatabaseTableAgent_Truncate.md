---
title: Truncate
id: v1DatabaseTableAgent_Truncate
---

# Truncate

```http
POST /api/v1/Agents/DatabaseTable/Truncate
```

Drop all rows in a table.

This clearance is not individually logged in TravelTransactionlog or Webhook/script calls


## Online Restricted: ## The DatabaseTable agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DatabaseTable/Truncate?$select=name,department,category/id
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

TableName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableName | string |  |


## Response: object

Information about the results of a mass-update operation



Carrier object for MassOperationResult.
Services for the MassOperationResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDatabaseTableAgent">DatabaseTable Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | Did the operation succeed |
| Message | string | Any message from the method, including timing data |
| Inserts | int32 | Number of rows inserted |
| Updates | int32 | Number of rows updated |
| Deletes | int32 | Number of rows deleted / zeroed |
| RowStatus | array | Array of statuses and primary keys for all rows that were specified. Populated if the 'ReturnRowStatus' parameter of 'Upsert' is set, otherwise null |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/DatabaseTable/Truncate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TableName": "Conn Inc and Sons"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "impedit",
  "Inserts": 120,
  "Updates": 877,
  "Deletes": 76,
  "RowStatus": [
    {
      "PrimaryKey": 914,
      "Action": "ColumnsZeroed",
      "RowKeys": [
        "ut",
        "consequatur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    },
    {
      "PrimaryKey": 914,
      "Action": "ColumnsZeroed",
      "RowKeys": [
        "ut",
        "consequatur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    }
  ],
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
      "FieldLength": 834
    }
  }
}
```