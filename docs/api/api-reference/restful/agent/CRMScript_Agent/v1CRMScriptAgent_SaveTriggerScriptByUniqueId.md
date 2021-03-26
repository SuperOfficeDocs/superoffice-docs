---
title: POST Agents/CRMScript/SaveTriggerScriptByUniqueId
id: v1CRMScriptAgent_SaveTriggerScriptByUniqueId
---

# POST Agents/CRMScript/SaveTriggerScriptByUniqueId

```http
POST /api/v1/Agents/CRMScript/SaveTriggerScriptByUniqueId
```

Validate a CRMScript.

This will check that the syntax is correct


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CRMScript/SaveTriggerScriptByUniqueId?$select=name,department,category/id
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

TriggerScriptUniqueId, Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TriggerScriptUniqueId | string |  |
| Entity |  | CRM Trigger Script - The script runs when a given event fires. <para /> Carrier object for TriggerScriptEntity. Services for the TriggerScriptEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ICRMScriptAgent">CRMScript Agent</see>. |


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
| Source | string | The CRMscript code for this event handler |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/CRMScript/SaveTriggerScriptByUniqueId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TriggerScriptUniqueId": "et",
  "Entity": {
    "ScreenChooserId": 757,
    "Name": "Gutkowski LLC",
    "ScreenType": "ChatAfterSaveNewMessage",
    "Enabled": false,
    "UniqueIdentifier": "dolore",
    "Source": "nihil",
    "Registered": "2009-12-15T16:48:29.2168941+01:00",
    "RegisteredAssociateId": 575,
    "Updated": "2008-05-30T16:48:29.2168941+02:00",
    "UpdatedAssociateId": 373
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 760,
  "Name": "Reilly-Hickle",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": false,
  "UniqueIdentifier": "ducimus",
  "Source": "qui",
  "Registered": "2017-11-29T16:48:29.2179055+01:00",
  "RegisteredAssociateId": 8,
  "Updated": "2006-03-22T16:48:29.2179055+01:00",
  "UpdatedAssociateId": 994,
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
      "FieldType": "System.Int32",
      "FieldLength": 322
    }
  }
}
```