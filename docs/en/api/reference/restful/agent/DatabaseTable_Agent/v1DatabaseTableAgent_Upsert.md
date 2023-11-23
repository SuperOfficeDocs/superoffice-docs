---
title: POST Agents/DatabaseTable/Upsert
uid: v1DatabaseTableAgent_Upsert
generated: true
---

# POST Agents/DatabaseTable/Upsert

```http
POST /api/v1/Agents/DatabaseTable/Upsert
```

Insert or update rows, optionally deleting/zeroing 'leftover' rows.


Special support for UDEF, as well as optional extensive information return. Traveltransactionlog and WebHooks are supported






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DatabaseTable/Upsert?$select=name,department,category/id
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

TableName, Columns, Keys, Data, NomatchAction, ReturnRowStatus 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableName | String |  |
| Columns | Array |  |
| Keys | Array |  |
| Data | Array |  |
| NomatchAction | String |  |
| ReturnRowStatus | Boolean |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: MassOperationResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | Did the operation succeed |
| Message | string | Any message from the method, including timing data |
| Inserts | int32 | Number of rows inserted |
| Updates | int32 | Number of rows updated |
| Deletes | int32 | Number of rows deleted / zeroed |
| RowStatus | array | Array of statuses and primary keys for all rows that were specified. Populated if the 'ReturnRowStatus' parameter of 'Upsert' is set, otherwise null |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/DatabaseTable/Upsert
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TableName": "Carter-Hermiston",
  "Columns": [
    "quisquam",
    "veniam"
  ],
  "Keys": [
    "neque",
    "quia"
  ],
  "Data": [
    [
      {}
    ],
    [
      {}
    ]
  ],
  "NomatchAction": "DeleteRow",
  "ReturnRowStatus": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "dignissimos",
  "Inserts": 451,
  "Updates": 556,
  "Deletes": 732,
  "RowStatus": [
    {
      "PrimaryKey": 972,
      "Action": "ColumnsZeroed",
      "RowKeys": [
        "vel",
        "illo"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    },
    {
      "PrimaryKey": 972,
      "Action": "ColumnsZeroed",
      "RowKeys": [
        "vel",
        "illo"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 148
    }
  }
}
```