---
title: GetAllWebhooks
id: v1WebhookAgent_GetAllWebhooks
---

# GetAllWebhooks

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "NameFilter": "Torp Group",
  "EventFilter": "sed",
  "StatusFilter": "Active"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebhookId": 435,
    "Name": "Reichel-Goldner",
    "Events": [
      "sed",
      "commodi"
    ],
    "TargetUrl": "http://www.example.com/",
    "Secret": "deserunt",
    "State": "Active",
    "Type": "saepe",
    "Headers": {
      "Headers1": "in",
      "Headers2": "ratione"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "2013-02-02T14:58:05.6160652+01:00",
    "RegisteredAssociate": {
      "AssociateId": 111,
      "Name": "Douglas Group",
      "PersonId": 820,
      "Rank": 403,
      "Tooltip": "cumque",
      "Type": "AnonymousAssociate",
      "GroupIdx": 817,
      "FullName": "Dana McGlynn",
      "FormalName": "Bode Group",
      "Deleted": true,
      "EjUserId": 75,
      "UserName": "Renner, Olson and Krajcik",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    },
    "Updated": "2020-05-03T14:58:05.6160652+02:00",
    "UpdatedAssociate": {
      "AssociateId": 835,
      "Name": "Bradtke Group",
      "PersonId": 770,
      "Rank": 803,
      "Tooltip": "modi",
      "Type": "AnonymousAssociate",
      "GroupIdx": 782,
      "FullName": "Kraig Halvorson",
      "FormalName": "O'Conner-Jast",
      "Deleted": true,
      "EjUserId": 660,
      "UserName": "Abshire, Barrows and Zboncak",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    }
  }
]
```