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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 31,
  "Name": "Stehr-Bergnaum",
  "Events": [
    "odit",
    "dolor"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "a",
  "State": "Active",
  "Type": "fugiat",
  "Headers": {
    "Headers1": "ipsam",
    "Headers2": "nisi"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2017-06-06T18:25:51.5641207+02:00",
  "RegisteredAssociate": {
    "AssociateId": 207,
    "Name": "Pacocha, Lesch and Lind",
    "PersonId": 434,
    "Rank": 226,
    "Tooltip": "fuga",
    "Type": "AnonymousAssociate",
    "GroupIdx": 598,
    "FullName": "Laurine Heidenreich",
    "FormalName": "Kihn Group",
    "Deleted": false,
    "EjUserId": 109,
    "UserName": "Hand Group"
  },
  "Updated": "2014-05-10T18:25:51.5641207+02:00",
  "UpdatedAssociate": {
    "AssociateId": 516,
    "Name": "Welch, Waelchi and Purdy",
    "PersonId": 977,
    "Rank": 865,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 892,
    "FullName": "Kendrick Lemke",
    "FormalName": "Bradtke-Johnson",
    "Deleted": false,
    "EjUserId": 858,
    "UserName": "Runolfsson-Deckow"
  }
}
```

```http_
HTTP/1.1 200 Webhook updated.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 971,
  "Name": "Yost LLC",
  "Events": [
    "eos",
    "deleniti"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "omnis",
  "State": "Active",
  "Type": "omnis",
  "Headers": {
    "Headers1": "ut",
    "Headers2": "molestiae"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1994-09-23T18:25:51.5667798+02:00",
  "RegisteredAssociate": {
    "AssociateId": 845,
    "Name": "Walter Inc and Sons",
    "PersonId": 954,
    "Rank": 197,
    "Tooltip": "magni",
    "Type": "AnonymousAssociate",
    "GroupIdx": 550,
    "FullName": "Jeffery Beier",
    "FormalName": "Koch, Fadel and Stamm",
    "Deleted": true,
    "EjUserId": 564,
    "UserName": "Howell Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 825
      }
    }
  },
  "Updated": "2005-06-26T18:25:51.5667798+02:00",
  "UpdatedAssociate": {
    "AssociateId": 771,
    "Name": "Klocko-Walsh",
    "PersonId": 458,
    "Rank": 89,
    "Tooltip": "repellendus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 569,
    "FullName": "Demarco Schamberger",
    "FormalName": "Corwin, Breitenberg and Yundt",
    "Deleted": true,
    "EjUserId": 787,
    "UserName": "Huel, Conroy and Hane",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 928
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```