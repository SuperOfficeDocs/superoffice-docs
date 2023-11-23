---
title: POST Agents/ErpSync/GetConnectionsAndDisplayFields
uid: v1ErpSyncAgent_GetConnectionsAndDisplayFields
generated: true
---

# POST Agents/ErpSync/GetConnectionsAndDisplayFields

```http
POST /api/v1/Agents/ErpSync/GetConnectionsAndDisplayFields
```

Get all connection statuses and fields for a given entity


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetConnectionsAndDisplayFields?$select=name,department,category/id
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

CrmActorType, EntityId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CrmActorType | String |  |
| EntityId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 | The id of the connection |
| ConnectionName | string | The name of the connection |
| Connected | bool | True if this entity instance has syncronized connection |
| ErpFields | array | The ERP fields that should be displayed |
| CrmActorType | string | The crm actor type which these fields belongs to |
| ErpActorType | string | The erp actor type which these fields belongs to |
| ErpActorTypes | array | Contains all mapped ErpActorType for this CrmActorType |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/GetConnectionsAndDisplayFields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CrmActorType": "Contact",
  "EntityId": 622
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ErpConnectionId": 3,
    "ConnectionName": "Rath Group",
    "Connected": false,
    "ErpFields": [
      {
        "FieldKey": "ut",
        "Rank": 753,
        "DisplayName": "Waelchi-Mitchell",
        "DisplayDescription": "Distributed multimedia moderator",
        "FieldType": "Checkbox",
        "ListName": "Schoen Inc and Sons",
        "DefaultValue": "occaecati",
        "MaxLength": 124,
        "Access": "Mandatory",
        "ShowInSearch": false,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 267
          }
        }
      }
    ],
    "CrmActorType": "Contact",
    "ErpActorType": "Customer",
    "ErpActorTypes": [
      "atque",
      "fuga"
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 792
      }
    }
  }
]
```