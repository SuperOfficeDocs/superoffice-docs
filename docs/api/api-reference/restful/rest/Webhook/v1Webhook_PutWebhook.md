---
title: PUT Webhook/{id}
id: v1Webhook_PutWebhook
---

# PUT Webhook/{id}

```http
PUT /api/v1/Webhook/{id}
```

Updates the existing Webhook



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Webhook id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Webhook/{id}?$select=name,department,category/id
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

## Request Body: entity  

The Webhook to be saved. 

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


## Response: object

Webhook definitions. Webhooks broadcast events from NetServer to remote servers.



Webhook entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | Webhook updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 497,
  "Name": "Frami Inc and Sons",
  "Events": [
    "nostrum",
    "eveniet"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "eum",
  "State": "Active",
  "Type": "tempore",
  "Headers": {
    "Headers1": "laborum",
    "Headers2": "labore"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1997-04-02T15:05:43.1978986+02:00",
  "RegisteredAssociate": {
    "AssociateId": 117,
    "Name": "Green Inc and Sons",
    "PersonId": 525,
    "Rank": 933,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 881,
    "FullName": "Lolita Grimes I",
    "FormalName": "Schmeler, Deckow and Rice",
    "Deleted": true,
    "EjUserId": 171,
    "UserName": "Boyer, Jacobi and Bogisich"
  },
  "Updated": "2003-06-08T15:05:43.1978986+02:00",
  "UpdatedAssociate": {
    "AssociateId": 425,
    "Name": "Gutmann, Schumm and Gulgowski",
    "PersonId": 285,
    "Rank": 386,
    "Tooltip": "adipisci",
    "Type": "AnonymousAssociate",
    "GroupIdx": 348,
    "FullName": "Hobart Nikolaus",
    "FormalName": "Cartwright LLC",
    "Deleted": false,
    "EjUserId": 290,
    "UserName": "Shanahan, Lehner and Upton"
  }
}
```

```http_
HTTP/1.1 200 Webhook updated.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 71,
  "Name": "Weimann, Sauer and Raynor",
  "Events": [
    "voluptates",
    "aut"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "quam",
  "State": "Active",
  "Type": "praesentium",
  "Headers": {
    "Headers1": "ut",
    "Headers2": "dolores"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2004-06-14T15:05:43.1999017+02:00",
  "RegisteredAssociate": {
    "AssociateId": 964,
    "Name": "Wisozk Inc and Sons",
    "PersonId": 10,
    "Rank": 563,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 189,
    "FullName": "Lorenzo Kuvalis",
    "FormalName": "Grady, Herzog and VonRueden",
    "Deleted": true,
    "EjUserId": 908,
    "UserName": "Ernser, Runte and Hermann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 436
      }
    }
  },
  "Updated": "2016-10-30T15:05:43.1999017+01:00",
  "UpdatedAssociate": {
    "AssociateId": 750,
    "Name": "Sporer Inc and Sons",
    "PersonId": 94,
    "Rank": 560,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 615,
    "FullName": "Dahlia Flatley",
    "FormalName": "Bayer LLC",
    "Deleted": true,
    "EjUserId": 677,
    "UserName": "Mitchell, Boyle and Brakus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness intuitive niches"
        },
        "FieldType": "System.Int32",
        "FieldLength": 814
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```