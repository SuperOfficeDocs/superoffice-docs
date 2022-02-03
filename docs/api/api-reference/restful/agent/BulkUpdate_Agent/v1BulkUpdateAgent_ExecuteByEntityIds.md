---
title: POST Agents/BulkUpdate/ExecuteByEntityIds
id: v1BulkUpdateAgent_ExecuteByEntityIds
---

# POST Agents/BulkUpdate/ExecuteByEntityIds

```http
POST /api/v1/Agents/BulkUpdate/ExecuteByEntityIds
```

Do the batchupdate on selected







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BulkUpdate/ExecuteByEntityIds?$select=name,department,category/id
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

FieldValueInfos, TableName, Context, Ids 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FieldValueInfos | array |  |
| TableName | string |  |
| Context | string |  |
| Ids | string |  |


## Response: int32



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: int32


## Sample Request

```http!
POST /api/v1/Agents/BulkUpdate/ExecuteByEntityIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "FieldValueInfos": [
    {
      "CanSupportMultiUse": true,
      "DefaultShowInGui": false,
      "DefaultShowInSelector": false,
      "IsActive": false,
      "Key": "dolores",
      "ValueType": "aliquid",
      "Mandatory": false,
      "EncodedDisplayName": "Waelchi-Considine",
      "EncodedDisplayDescription": "Implemented radical firmware",
      "IconHint": "doloremque",
      "ControlInfos": [
        {},
        {}
      ],
      "EncodedDataCaption": "accusamus",
      "EncodedDataCaptionDescription": "Vision-oriented zero administration productivity",
      "CurrentOperationType": "id",
      "Values": [
        "sit",
        "labore"
      ],
      "DisplayValues": [
        "debitis",
        "est"
      ],
      "OperationInfos": [
        {},
        {}
      ]
    }
  ],
  "TableName": "Rath-Lind",
  "Context": "ut",
  "Ids": "incidunt"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

737
```