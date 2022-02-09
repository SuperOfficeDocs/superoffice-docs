---
title: POST Webhook
id: v1Webhook_PostWebhook
---

# POST Webhook

```http
POST /api/v1/Webhook
```

Creates a new Webhook

Calls the Webhook agent service SaveWebhook.


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Webhook?$select=name,department,category/id
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
| 200 | OK |

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
POST /api/v1/Webhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 236,
  "Name": "Sawayn LLC",
  "Events": [
    "optio",
    "et"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "quo",
  "State": "Active",
  "Type": "aut",
  "Headers": {
    "Headers1": "saepe",
    "Headers2": "numquam"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1999-05-19T18:25:51.5591203+02:00",
  "RegisteredAssociate": {
    "AssociateId": 518,
    "Name": "Gislason-Lemke",
    "PersonId": 500,
    "Rank": 237,
    "Tooltip": "ratione",
    "Type": "AnonymousAssociate",
    "GroupIdx": 904,
    "FullName": "Miss Darren Walsh",
    "FormalName": "O'Connell LLC",
    "Deleted": false,
    "EjUserId": 747,
    "UserName": "Koch, Rosenbaum and Stark"
  },
  "Updated": "2002-05-19T18:25:51.5591203+02:00",
  "UpdatedAssociate": {
    "AssociateId": 893,
    "Name": "Wyman Group",
    "PersonId": 304,
    "Rank": 490,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 347,
    "FullName": "Elliot Jenkins",
    "FormalName": "Runte, Little and Mayert",
    "Deleted": true,
    "EjUserId": 271,
    "UserName": "Roob Group"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 173,
  "Name": "Mann Group",
  "Events": [
    "consectetur",
    "minus"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "ut",
  "State": "Active",
  "Type": "nesciunt",
  "Headers": {
    "Headers1": "voluptate",
    "Headers2": "hic"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1995-12-06T18:25:51.5611214+01:00",
  "RegisteredAssociate": {
    "AssociateId": 27,
    "Name": "Kulas, Kuhic and Greenfelder",
    "PersonId": 879,
    "Rank": 587,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 373,
    "FullName": "Juanita Rempel",
    "FormalName": "Yost, VonRueden and Hegmann",
    "Deleted": false,
    "EjUserId": 813,
    "UserName": "Friesen, Rodriguez and Hickle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 87
      }
    }
  },
  "Updated": "2018-11-20T18:25:51.5621206+01:00",
  "UpdatedAssociate": {
    "AssociateId": 922,
    "Name": "Feil LLC",
    "PersonId": 826,
    "Rank": 668,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 912,
    "FullName": "Emmalee Stoltenberg",
    "FormalName": "Brown LLC",
    "Deleted": true,
    "EjUserId": 379,
    "UserName": "Lynch Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 141
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```