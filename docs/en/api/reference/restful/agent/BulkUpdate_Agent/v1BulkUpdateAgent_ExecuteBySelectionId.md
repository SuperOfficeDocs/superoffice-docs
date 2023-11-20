---
title: POST Agents/BulkUpdate/ExecuteBySelectionId
uid: v1BulkUpdateAgent_ExecuteBySelectionId
generated: true
---

# POST Agents/BulkUpdate/ExecuteBySelectionId

```http
POST /api/v1/Agents/BulkUpdate/ExecuteBySelectionId
```

Do the batchupdate on this selection







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/BulkUpdate/ExecuteBySelectionId?$select=name,department,category/id
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

FieldValueInfos, TableName, Context, SelectionId, IsShadow 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FieldValueInfos | Array |  |
| TableName | String |  |
| Context | String |  |
| SelectionId | Integer |  |
| IsShadow | Boolean |  |

## Response:int32

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: int32


## Sample request

```http!
POST /api/v1/Agents/BulkUpdate/ExecuteBySelectionId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FieldValueInfos": [
    {
      "CanSupportMultiUse": false,
      "DefaultShowInGui": true,
      "DefaultShowInSelector": false,
      "IsActive": true,
      "Key": "consectetur",
      "ValueType": "voluptatem",
      "Mandatory": false,
      "EncodedDisplayName": "Lindgren-Weimann",
      "EncodedDisplayDescription": "Multi-tiered clear-thinking knowledge user",
      "IconHint": "ad",
      "ControlInfos": [
        {},
        {}
      ],
      "EncodedDataCaption": "corporis",
      "EncodedDataCaptionDescription": "Total contextually-based workforce",
      "CurrentOperationType": "cupiditate",
      "Values": [
        "voluptatem",
        "voluptatem"
      ],
      "DisplayValues": [
        "a",
        "eum"
      ],
      "OperationInfos": [
        {},
        {}
      ]
    }
  ],
  "TableName": "Dickinson LLC",
  "Context": "qui",
  "SelectionId": 137,
  "IsShadow": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

101
```