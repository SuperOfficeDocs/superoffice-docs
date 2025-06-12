---
title: POST Agents/CRMScript/SaveTriggerScriptEntity
uid: v1CRMScriptAgent_SaveTriggerScriptEntity
generated: true
---

# POST Agents/CRMScript/SaveTriggerScriptEntity

```http
POST /api/v1/Agents/CRMScript/SaveTriggerScriptEntity
```

Updates the existing TriggerScriptEntity or creates a new TriggerScriptEntity if the id parameter is empty


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.







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

The TriggerScriptEntity to be saved. 

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
POST /api/v1/Agents/CRMScript/SaveTriggerScriptEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 634,
  "Name": "Simonis-Roberts",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": false,
  "UniqueIdentifier": "sit",
  "Source": "sed",
  "Registered": "2003-08-05T17:54:02.9139671+02:00",
  "RegisteredAssociateId": 179,
  "Updated": "2011-01-15T17:54:02.9139671+01:00",
  "UpdatedAssociateId": 472
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 882,
  "Name": "Hand-Schroeder",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "quae",
  "Source": "recusandae",
  "Registered": "2003-11-08T17:54:02.9139671+01:00",
  "RegisteredAssociateId": 934,
  "Updated": "2000-04-16T17:54:02.9139671+02:00",
  "UpdatedAssociateId": 664,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 287
    }
  }
}
```