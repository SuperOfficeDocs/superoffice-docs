---
title: PATCH TriggerScript/{id}
id: v1TriggerScriptEntity_PatchTriggerScriptEntity
---

# PATCH TriggerScript/{id}

```http
PATCH /api/v1/TriggerScript/{id}
```

Update a TriggerScriptEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.ICRMScriptAgent} service SaveTriggerScriptEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TriggerScriptEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/TriggerScript/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

CRM Trigger Script - The script runs when a given event fires.



TriggerScriptEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | TriggerScriptEntity  updated. |
| 404 | TriggerScriptEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because TriggerScriptEntity has changed since the requested If-Unmodified-Since timestamp. |

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/TriggerScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "qui",
    "value": {
      "value1": {
        "PrimaryKey": 7501,
        "EntityName": "sale",
        "saleId": 7501,
        "contactId": 7810,
        "name": "Parker-Upton"
      },
      "value2": {
        "PrimaryKey": 6472,
        "EntityName": "sale",
        "saleId": 6472,
        "contactId": 7993,
        "name": "Ortiz, Dach and Carter"
      }
    }
  },
  {
    "op": "add",
    "path": "qui",
    "value": {
      "value1": {
        "PrimaryKey": 7501,
        "EntityName": "sale",
        "saleId": 7501,
        "contactId": 7810,
        "name": "Parker-Upton"
      },
      "value2": {
        "PrimaryKey": 6472,
        "EntityName": "sale",
        "saleId": 6472,
        "contactId": 7993,
        "name": "Ortiz, Dach and Carter"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 TriggerScriptEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ScreenChooserId": 193,
  "Name": "Raynor Inc and Sons",
  "ScreenType": "ChatAfterSaveNewMessage",
  "Enabled": true,
  "UniqueIdentifier": "molestiae",
  "Source": "iure",
  "Registered": "2009-06-27T15:05:42.9616322+02:00",
  "RegisteredAssociateId": 252,
  "Updated": "2015-02-27T15:05:42.9616322+01:00",
  "UpdatedAssociateId": 564,
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
      "FieldLength": 19
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```