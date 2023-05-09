---
title: POST Agents/ErpSync/GetActorTypeMapping
uid: v1ErpSyncAgent_GetActorTypeMapping
---

# POST Agents/ErpSync/GetActorTypeMapping

```http
POST /api/v1/Agents/ErpSync/GetActorTypeMapping
```

Get the current mappings for one connection/actor; connection+actor type = unique key


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetActorTypeMapping?$select=name,department,category/id
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

ErpConnectionId, ActorType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | Integer |  |
| ActorType | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ErpSyncActorTypeMapping

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 | Primary key |
| IsActive | bool | Is this sync mapping active |
| FieldMappings | array | Array of individual field mappings; explicitly map to empty CrmFieldKey to indicate non-sync |
| ActorTypeErp | string | The actor type (ERP side) |
| ActorTypeCrm | string | The actor type (CRM side) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/GetActorTypeMapping
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 187,
  "ActorType": "Customer"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 136,
  "IsActive": true,
  "FieldMappings": [
    {
      "ErpFieldId": 652,
      "CrmFieldKey": "voluptatem",
      "CrmDisplayName": "Lowe, Orn and Doyle",
      "CrmDisplayTooltip": "laboriosam",
      "ErpFieldKey": "quibusdam",
      "FieldType": "Checkbox",
      "ErpDisplayName": "O'Connell-Swift",
      "ErpDisplayTooltip": "et",
      "SyncToCrm": false,
      "SyncToErp": false,
      "ShowInGui": false,
      "ShowInSearch": false,
      "AlreadyMapped": false,
      "MissingInERP": true,
      "MissingInCRM": true,
      "Access": "Mandatory",
      "ListReference": "accusamus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "ActorTypeErp": "Customer",
  "ActorTypeCrm": "Contact",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 837
    }
  }
}
```