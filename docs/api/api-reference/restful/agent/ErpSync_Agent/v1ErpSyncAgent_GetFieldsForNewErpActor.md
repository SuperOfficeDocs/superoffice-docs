---
title: POST Agents/ErpSync/GetFieldsForNewErpActor
id: v1ErpSyncAgent_GetFieldsForNewErpActor
---

# POST Agents/ErpSync/GetFieldsForNewErpActor

```http
POST /api/v1/Agents/ErpSync/GetFieldsForNewErpActor
```

Get the fields that must be filled out when creating a new ERP actor



## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetFieldsForNewErpActor?$select=name,department,category/id
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

ErpConnectionId, ErpActorType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 |  |
| ErpActorType | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| FieldKey | string | Internal key/name of the field. Used as the key in the ConnectionConfigField values when TestConnection is called. |
| Rank | int32 | A way to set the order of the fields. Lowest value will be displayed first/over the fields with other values. |
| DisplayName | string | Localized field name – shown in the GUI |
| DisplayDescription | string | Tooltip for the field name. |
| FieldType | string | String, int, decimal, etc. |
| ListName | string | MDO List provider name for list fields |
| DefaultValue | string | A default value for the field. |
| MaxLength | int32 | Maximum length for strings, if set. 0 means no restriction. (Though sooner or later something will no doubt overflow if you pile on the gigabytes.) |
| Access | string | Access restrictions on the field |
| ShowInSearch | bool | True if this field is displayed in search result |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ErpSync/GetFieldsForNewErpActor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 934,
  "ErpActorType": "Customer"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "FieldKey": "delectus",
    "Rank": 873,
    "DisplayName": "Kunze LLC",
    "DisplayDescription": "Networked client-server customer loyalty",
    "FieldType": "Checkbox",
    "ListName": "Schowalter-Nicolas",
    "DefaultValue": "consequatur",
    "MaxLength": 376,
    "Access": "Mandatory",
    "ShowInSearch": false,
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
        "FieldLength": 254
      }
    }
  }
]
```