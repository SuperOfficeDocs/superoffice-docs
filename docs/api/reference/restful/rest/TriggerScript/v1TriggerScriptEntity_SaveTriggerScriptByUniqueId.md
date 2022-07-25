---
title: PUT TriggerScript/{id}
id: v1TriggerScriptEntity_SaveTriggerScriptByUniqueId
---

# PUT TriggerScript/{id}

```http
PUT /api/v1/TriggerScript/{triggerScriptUniqueId}
```

Validate a CRMScript.

This will check that the syntax is correct

## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered

| Path Part | Type | Description |
|-----------|------|-------------|
| triggerScriptUniqueId | string | The unique id of the CRMScript to validate **Required** |

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

## Request Body: entity

Trigger script details and source code

| Property Name | Type |  Description |
|----------------|------|--------------|
| ScreenChooserId | int32 | Primary key |
| Name | string | Optional description of what this script is used for. |
| ScreenType | string | Event id that triggers script.  See EventHandlerType enum. |
| Enabled | bool | Whether this screen chooser is enabled or not |
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Source | string | The CRMScript code for this event handler |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |

## Response: object

CRM Trigger Script - The script runs when a given event fires.

Carrier object for TriggerScriptEntity.
Services for the TriggerScriptEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICRMScriptAgent">CRMScript Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ScreenChooserId | int32 | Primary key |
| Name | string | Optional description of what this script is used for. |
| ScreenType | string | Event id that triggers script.  See EventHandlerType enum. |
| Enabled | bool | Whether this screen chooser is enabled or not |
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Source | string | The CRMScript code for this event handler |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/TriggerScript/{triggerScriptUniqueId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 702,
  "Name": "Nienow LLC",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "repellat",
  "Source": "quis",
  "Registered": "1998-10-12T18:25:51.3221056+02:00",
  "RegisteredAssociateId": 195,
  "Updated": "2001-06-27T18:25:51.3221056+02:00",
  "UpdatedAssociateId": 822
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 24,
  "Name": "Kuhlman LLC",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": false,
  "UniqueIdentifier": "veniam",
  "Source": "error",
  "Registered": "2000-05-16T18:25:51.3231056+02:00",
  "RegisteredAssociateId": 282,
  "Updated": "2003-12-28T18:25:51.3231056+01:00",
  "UpdatedAssociateId": 587,
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
      "FieldLength": 504
    }
  }
}
```
