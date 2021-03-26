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
  "WebhookId": 332,
  "Name": "Dickinson, Harber and Crist",
  "Events": [
    "qui",
    "aspernatur"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "occaecati",
  "State": "Active",
  "Type": "et",
  "Headers": {
    "Headers1": "commodi",
    "Headers2": "eum"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1994-02-05T09:41:00.117333+01:00",
  "RegisteredAssociate": {
    "AssociateId": 615,
    "Name": "Bogisich, Kshlerin and Bahringer",
    "PersonId": 697,
    "Rank": 171,
    "Tooltip": "maxime",
    "Type": "AnonymousAssociate",
    "GroupIdx": 493,
    "FullName": "Danielle Rohan Jr.",
    "FormalName": "Fadel-Marquardt",
    "Deleted": true,
    "EjUserId": 539,
    "UserName": "Haag-Watsica"
  },
  "Updated": "2002-08-08T09:41:00.117333+02:00",
  "UpdatedAssociate": {
    "AssociateId": 96,
    "Name": "Bins, Ziemann and Rath",
    "PersonId": 16,
    "Rank": 11,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 467,
    "FullName": "Dedric Ebert",
    "FormalName": "Nicolas Group",
    "Deleted": false,
    "EjUserId": 711,
    "UserName": "Moen Inc and Sons"
  }
}
```

```http_
HTTP/1.1 200 Webhook updated.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 465,
  "Name": "Senger, Cassin and Buckridge",
  "Events": [
    "adipisci",
    "est"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "assumenda",
  "State": "Active",
  "Type": "quo",
  "Headers": {
    "Headers1": "necessitatibus",
    "Headers2": "est"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1998-05-08T09:41:00.1193613+02:00",
  "RegisteredAssociate": {
    "AssociateId": 145,
    "Name": "Bahringer, Schamberger and Hahn",
    "PersonId": 453,
    "Rank": 468,
    "Tooltip": "numquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 616,
    "FullName": "Katherine Senger",
    "FormalName": "Treutel, Collins and Padberg",
    "Deleted": true,
    "EjUserId": 182,
    "UserName": "Fay Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 94
      }
    }
  },
  "Updated": "1996-01-27T09:41:00.1193613+01:00",
  "UpdatedAssociate": {
    "AssociateId": 621,
    "Name": "Beier, Ritchie and Kunde",
    "PersonId": 650,
    "Rank": 15,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 511,
    "FullName": "Lyla Sauer",
    "FormalName": "Pagac, Blanda and Carroll",
    "Deleted": true,
    "EjUserId": 793,
    "UserName": "Schultz-Predovic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 746
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```