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
  "WebhookId": 265,
  "Name": "Yundt Group",
  "Events": [
    "praesentium",
    "qui"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "ab",
  "State": "Active",
  "Type": "autem",
  "Headers": {
    "Headers1": "consequatur",
    "Headers2": "reprehenderit"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2003-10-12T15:05:43.1929014+02:00",
  "RegisteredAssociate": {
    "AssociateId": 179,
    "Name": "Fahey LLC",
    "PersonId": 657,
    "Rank": 303,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 197,
    "FullName": "Francis Casper",
    "FormalName": "Bradtke, Braun and Gleichner",
    "Deleted": true,
    "EjUserId": 20,
    "UserName": "Reichert-Renner"
  },
  "Updated": "2010-05-09T15:05:43.1929014+02:00",
  "UpdatedAssociate": {
    "AssociateId": 227,
    "Name": "Stanton, Brekke and Jaskolski",
    "PersonId": 900,
    "Rank": 975,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 250,
    "FullName": "Westley Mante",
    "FormalName": "Marvin, Pfannerstill and Kohler",
    "Deleted": false,
    "EjUserId": 829,
    "UserName": "Purdy-Miller"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 568,
  "Name": "Hilpert LLC",
  "Events": [
    "maxime",
    "vitae"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "quo",
  "State": "Active",
  "Type": "minus",
  "Headers": {
    "Headers1": "minima",
    "Headers2": "accusamus"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2019-05-20T15:05:43.1949007+02:00",
  "RegisteredAssociate": {
    "AssociateId": 587,
    "Name": "Littel, Kertzmann and Nicolas",
    "PersonId": 385,
    "Rank": 273,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 98,
    "FullName": "Darian Prosacco",
    "FormalName": "Bergstrom, Bergnaum and Champlin",
    "Deleted": true,
    "EjUserId": 495,
    "UserName": "Brakus-Runolfsdottir",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 566
      }
    }
  },
  "Updated": "2015-03-31T15:05:43.1949007+02:00",
  "UpdatedAssociate": {
    "AssociateId": 813,
    "Name": "Doyle, Pfeffer and Anderson",
    "PersonId": 182,
    "Rank": 80,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 477,
    "FullName": "Edmond Ullrich",
    "FormalName": "Torp Group",
    "Deleted": true,
    "EjUserId": 607,
    "UserName": "Swaniawski, O'Reilly and Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 587
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```