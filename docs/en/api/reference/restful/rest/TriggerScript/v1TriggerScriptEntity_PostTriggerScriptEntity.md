---
title: POST TriggerScript
uid: v1TriggerScriptEntity_PostTriggerScriptEntity
generated: true
content_type: reference
---

# POST TriggerScript

```http
POST /api/v1/TriggerScript
```

Creates a new TriggerScriptEntity


Calls the CRMScript agent service SaveTriggerScriptEntity.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/TriggerScript?$select=name,department,category/id
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

## Request Body: newEntity 

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

### Response body: TriggerScriptEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/TriggerScript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 329,
  "Name": "Hickle, Brekke and Tromp",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "reprehenderit",
  "Source": "necessitatibus",
  "Registered": "2004-09-13T11:24:53.7186781+02:00",
  "RegisteredAssociateId": 494,
  "Updated": "2022-12-17T11:24:53.7186781+01:00",
  "UpdatedAssociateId": 498
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 467,
  "Name": "Rohan-Carter",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": false,
  "UniqueIdentifier": "ut",
  "Source": "in",
  "Registered": "2007-12-23T11:24:53.7186781+01:00",
  "RegisteredAssociateId": 891,
  "Updated": "2004-10-21T11:24:53.7186781+02:00",
  "UpdatedAssociateId": 186,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 6
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```