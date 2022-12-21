---
title: POST Agents/DatabaseTable/Delete
uid: v1DatabaseTableAgent_Delete
---

# POST Agents/DatabaseTable/Delete

```http
POST /api/v1/Agents/DatabaseTable/Delete
```

Delete rows, by primary key; traveltransactionlog and WebHooks are supported







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/DatabaseTable/Delete?$select=name,department,category/id
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

TableName, IDs 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TableName | string |  |
| IDs | array |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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

## Sample request

```http!
POST /api/v1/Agents/DatabaseTable/Delete
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TableName": "Haag, Orn and Considine",
  "IDs": [
    844,
    380
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "est",
  "Inserts": 593,
  "Updates": 423,
  "Deletes": 709,
  "RowStatus": [
    {
      "PrimaryKey": 508,
      "Action": "ColumnsZeroed",
      "RowKeys": [
        "quisquam",
        "reprehenderit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "PrimaryKey": 508,
      "Action": "ColumnsZeroed",
      "RowKeys": [
        "quisquam",
        "reprehenderit"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 770
    }
  }
}
```