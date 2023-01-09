---
title: POST Agents/ErpSync/ForceResyncExternal
uid: v1ErpSyncAgent_ForceResyncExternal
---

# POST Agents/ErpSync/ForceResyncExternal

```http
POST /api/v1/Agents/ErpSync/ForceResyncExternal
```

Force resync from CRM or given Erp connection to all other connections, using external keys


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/ForceResyncExternal?$select=name,department,category/id
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

ErpConnectionId, ErpActorType, ExternalKeys 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | Integer |  |
| ErpActorType | String |  |
| ExternalKeys | Array |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PluginResponse

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsOk | bool | Answer to the question / An indication if the operation went well. Equivalent to Status != Error |
| UserExplanation | string | A localized explanation to the answer. Text here is displayed to the user. |
| TechExplanation | string | Always in English |
| ErrorCode | string | An error code, if available. |
| Changes | ChangedData | Tablename/recordid of data changed by this method, that the client may need to reload |
| Status | string | QuoteStatus = Ok / OkWithInfo / Warn / Error. Error implies IsOk = false. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/ForceResyncExternal
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 252,
  "ErpActorType": "Customer",
  "ExternalKeys": [
    "ratione",
    "sit"
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "voluptatem",
  "TechExplanation": "aut",
  "ErrorCode": "laboriosam",
  "Changes": null,
  "Status": "Error",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 172
    }
  }
}
```