---
title: PUT TriggerScript/{id}
uid: v1TriggerScriptEntity_SaveTriggerScriptByUniqueId
generated: true
---

# PUT TriggerScript/{id}

```http
PUT /api/v1/TriggerScript/{triggerScriptUniqueId}
```

Validate a CRMScript.


This will check that the syntax is correct


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





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
| ScreenChooserId | Integer | Primary key |
| Name | String | Optional description of what this script is used for. |
| ScreenType | String | Event id that triggers script.  See EventHandlerType enum. |
| Enabled | Boolean | Whether this screen chooser is enabled or not |
| UniqueIdentifier | String | Global unique identifier, accross customers/tenants |
| Source | String | The CRMscript code for this event handler |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TriggerScriptEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ScreenChooserId | int32 | Primary key |
| Name | string | Optional description of what this script is used for. |
| ScreenType | string | Event id that triggers script.  See EventHandlerType enum. |
| Enabled | bool | Whether this screen chooser is enabled or not |
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Source | string | The CRMscript code for this event handler |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/TriggerScript/{triggerScriptUniqueId}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 162,
  "Name": "Kassulke, Kuphal and Bogisich",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "et",
  "Source": "voluptatem",
  "Registered": "2021-07-05T16:32:48.2745849+02:00",
  "RegisteredAssociateId": 691,
  "Updated": "1997-12-31T16:32:48.2745849+01:00",
  "UpdatedAssociateId": 439
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 495,
  "Name": "Torp-Cremin",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": false,
  "UniqueIdentifier": "quam",
  "Source": "et",
  "Registered": "2020-07-27T16:32:48.2745849+02:00",
  "RegisteredAssociateId": 607,
  "Updated": "2001-08-16T16:32:48.2745849+02:00",
  "UpdatedAssociateId": 506,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 457
    }
  }
}
```