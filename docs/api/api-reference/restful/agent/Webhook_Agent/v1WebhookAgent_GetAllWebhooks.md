---
title: POST Agents/Webhook/GetAllWebhooks
id: v1WebhookAgent_GetAllWebhooks
---

# POST Agents/Webhook/GetAllWebhooks

```http
POST /api/v1/Agents/Webhook/GetAllWebhooks
```

Returns all webhooks, according to filter criteria



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Webhook/GetAllWebhooks?$select=name,department,category/id
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

NameFilter, EventFilter, StatusFilter 

| Property Name | Type |  Description |
|----------------|------|--------------|
| NameFilter | string |  |
| EventFilter | string |  |
| StatusFilter | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| WebhookId | int32 | Primary Key. Unique id for this webhook. |
| Name | string | Name to identify this webhook. Does not have to be unique. |
| Events | array | Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] |
| TargetUrl | string | Destination to POST event info to. URL for webhooks. Id for CRM scripts |
| Secret | string | Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server |
| State | string | Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors |
| Type | string | Name of plugin that handles this webhook. 'webhook' for webhooks, which are handled by the system plugin. |
| Headers | object | Custom HTTP Headers to add to webhook requests. |
| Properties | object | Custom values to inject into JSON body of webhook call. |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociate |  | The user that created the webhook. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociate |  | The user that last updated the webhook. |

## Sample Request

```http!
POST /api/v1/Agents/Webhook/GetAllWebhooks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "NameFilter": "O'Connell-Farrell",
  "EventFilter": "maiores",
  "StatusFilter": "Active"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebhookId": 411,
    "Name": "Moen, Funk and Zboncak",
    "Events": [
      "iste",
      "necessitatibus"
    ],
    "TargetUrl": "http://www.example.com/",
    "Secret": "eligendi",
    "State": "Active",
    "Type": "vero",
    "Headers": {
      "Headers1": "quia",
      "Headers2": "quis"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "1997-04-30T16:48:31.0329348+02:00",
    "RegisteredAssociate": {
      "AssociateId": 969,
      "Name": "Terry-Lind",
      "PersonId": 32,
      "Rank": 386,
      "Tooltip": "dolorum",
      "Type": "AnonymousAssociate",
      "GroupIdx": 452,
      "FullName": "Ceasar Schimmel Jr.",
      "FormalName": "Christiansen, Murazik and Wilkinson",
      "Deleted": false,
      "EjUserId": 655,
      "UserName": "Gutkowski, Howell and Langworth",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "generate frictionless web-readiness"
          },
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    },
    "Updated": "2006-05-22T16:48:31.0329348+02:00",
    "UpdatedAssociate": {
      "AssociateId": 251,
      "Name": "Gusikowski-DuBuque",
      "PersonId": 533,
      "Rank": 207,
      "Tooltip": "accusamus",
      "Type": "AnonymousAssociate",
      "GroupIdx": 565,
      "FullName": "Angelita O'Connell DDS",
      "FormalName": "Ruecker, Bogan and Reinger",
      "Deleted": true,
      "EjUserId": 256,
      "UserName": "Raynor-Bernier",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "facilitate transparent experiences"
          },
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    }
  }
]
```