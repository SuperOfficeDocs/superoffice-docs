---
title: POST Agents/ErpSync/GetFieldValuesFromCrm
id: v1ErpSyncAgent_GetFieldValuesFromCrm
---

# POST Agents/ErpSync/GetFieldValuesFromCrm

```http
POST /api/v1/Agents/ErpSync/GetFieldValuesFromCrm
```

Get Crm Field values

## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetFieldValuesFromCrm?$select=name,department,category/id
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

RecordId, ActorTypeCrm

| Property Name | Type |  Description |
|----------------|------|--------------|
| RecordId | int32 |  |
| ActorTypeCrm | string |  |

## Response: array

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DisplayName | string |  |
| CrmFieldKey | string | The CRM field name, as implemented by the Sync entities |
| Value | string |  |
| DisplayValue | string |  |
| SyncToCrm | bool | Should value changes in ERP be automatically transferred to CRM |
| SyncToErp | bool | Should value changes in CRM be automatically transferred to ERP |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ErpSync/GetFieldValuesFromCrm
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "RecordId": 656,
  "ActorTypeCrm": "Contact"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DisplayName": "Lueilwitz, Friesen and Lindgren",
    "CrmFieldKey": "non",
    "Value": "adipisci",
    "DisplayValue": "delectus",
    "SyncToCrm": true,
    "SyncToErp": false,
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
        "FieldLength": 779
      }
    }
  }
]
```
