---
title: POST Agents/ErpSync/GetConnectionsAndDisplayFields
id: v1ErpSyncAgent_GetConnectionsAndDisplayFields
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
| CrmActorType | string |  |
| EntityId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 | The id of the connection |
| ConnectionName | string | The name of the connection |
| Connected | bool | True if this entity instance has syncronized connection |
| ErpFields | array | The ERP fields that should be displayed |
| CrmActorType | string | The crm actor type which these fields belongs to |
| ErpActorType | string | The erp actor type which these fields belongs to |
| ErpActorTypes | array | Contains all mapped ErpActorType for this CrmActorType |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ErpSync/GetConnectionsAndDisplayFields
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "CrmActorType": "Contact",
  "EntityId": 832
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ErpConnectionId": 40,
    "ConnectionName": "Lubowitz-Littel",
    "Connected": true,
    "ErpFields": [
      {
        "FieldKey": "dicta",
        "Rank": 172,
        "DisplayName": "Krajcik LLC",
        "DisplayDescription": "Reactive bottom-line groupware",
        "FieldType": "Checkbox",
        "ListName": "Kuhn, Flatley and Kuhic",
        "DefaultValue": "nemo",
        "MaxLength": 707,
        "Access": "Mandatory",
        "ShowInSearch": true,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 662
          }
        }
      }
    ],
    "CrmActorType": "Contact",
    "ErpActorType": "Customer",
    "ErpActorTypes": [
      "est",
      "at"
    ],
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
        "FieldLength": 855
      }
    }
  }
]
```