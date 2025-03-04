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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 572,
  "Name": "Armstrong, Stiedemann and Buckridge",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "qui",
  "Source": "ipsam",
  "Registered": "2012-12-28T14:13:39.9067187+01:00",
  "RegisteredAssociateId": 329,
  "Updated": "2022-08-28T14:13:39.9067187+02:00",
  "UpdatedAssociateId": 63
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 187,
  "Name": "Oberbrunner, Stoltenberg and Balistreri",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": false,
  "UniqueIdentifier": "aut",
  "Source": "sunt",
  "Registered": "2001-01-22T14:13:39.9067187+01:00",
  "RegisteredAssociateId": 699,
  "Updated": "2014-12-21T14:13:39.9067187+01:00",
  "UpdatedAssociateId": 62,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 98
    }
  }
}
```