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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 794,
  "Name": "Howell Group",
  "Events": [
    "non",
    "et"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "ea",
  "State": "Active",
  "Type": "aliquam",
  "Headers": {
    "Headers1": "laborum",
    "Headers2": "ad"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2016-04-18T09:41:00.1118281+02:00",
  "RegisteredAssociate": {
    "AssociateId": 999,
    "Name": "Rau-Kozey",
    "PersonId": 86,
    "Rank": 992,
    "Tooltip": "vero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 278,
    "FullName": "Pearline Jenkins",
    "FormalName": "Reilly-Jacobi",
    "Deleted": false,
    "EjUserId": 156,
    "UserName": "Boyle, Reichel and Pouros"
  },
  "Updated": "2017-09-30T09:41:00.1127872+02:00",
  "UpdatedAssociate": {
    "AssociateId": 612,
    "Name": "Bartoletti-Renner",
    "PersonId": 42,
    "Rank": 555,
    "Tooltip": "accusantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 887,
    "FullName": "Valentin Fritsch",
    "FormalName": "Haley, Bergstrom and Jacobi",
    "Deleted": true,
    "EjUserId": 252,
    "UserName": "Volkman-Wilkinson"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 681,
  "Name": "Dooley-Gibson",
  "Events": [
    "possimus",
    "consequuntur"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "consectetur",
  "State": "Active",
  "Type": "officiis",
  "Headers": {
    "Headers1": "aperiam",
    "Headers2": "et"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2012-06-17T09:41:00.1147919+02:00",
  "RegisteredAssociate": {
    "AssociateId": 637,
    "Name": "DuBuque-Douglas",
    "PersonId": 558,
    "Rank": 391,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 140,
    "FullName": "Abigale Brekke",
    "FormalName": "Hauck, Johnston and Yost",
    "Deleted": true,
    "EjUserId": 168,
    "UserName": "Williamson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 182
      }
    }
  },
  "Updated": "2013-11-26T09:41:00.1147919+01:00",
  "UpdatedAssociate": {
    "AssociateId": 469,
    "Name": "Satterfield LLC",
    "PersonId": 135,
    "Rank": 357,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 682,
    "FullName": "Roslyn Schowalter",
    "FormalName": "Kautzer, Hilpert and Wuckert",
    "Deleted": false,
    "EjUserId": 71,
    "UserName": "Bode Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 614
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```