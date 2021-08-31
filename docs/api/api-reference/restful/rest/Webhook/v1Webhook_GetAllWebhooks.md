---
title: GET Webhook
id: v1Webhook_GetAllWebhooks
---

# GET Webhook

```http
GET /api/v1/Webhook
```

Returns all webhooks, according to filter criteria



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| nameFilter | string |  Only return hooks with this name. Default NULL = no filter |
| eventFilter | string |  Only return hooks responding to this event name. Default NULL = no filter |
| statusFilter | Enum: Unknown, Active, Stopped, TooManyErrors |  Only return hooks with this status. Default Unknown = no filter, returns all. |

```http
GET /api/v1/Webhook?nameFilter=odio
GET /api/v1/Webhook?eventFilter=voluptatem
GET /api/v1/Webhook?statusFilter=Active
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Webhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebhookId": 311,
    "Name": "Weissnat-Kshlerin",
    "Events": [
      "et",
      "autem"
    ],
    "TargetUrl": "http://www.example.com/",
    "Secret": "omnis",
    "State": "Active",
    "Type": "natus",
    "Headers": {
      "Headers1": "omnis",
      "Headers2": "quaerat"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "1998-11-22T15:05:43.1918665+01:00",
    "RegisteredAssociate": {
      "AssociateId": 522,
      "Name": "Heathcote, Willms and Kemmer",
      "PersonId": 754,
      "Rank": 226,
      "Tooltip": "eius",
      "Type": "AnonymousAssociate",
      "GroupIdx": 323,
      "FullName": "Drake Fadel IV",
      "FormalName": "Robel Group",
      "Deleted": true,
      "EjUserId": 272,
      "UserName": "Gaylord LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    },
    "Updated": "2011-04-23T15:05:43.1929014+02:00",
    "UpdatedAssociate": {
      "AssociateId": 359,
      "Name": "Bailey LLC",
      "PersonId": 89,
      "Rank": 903,
      "Tooltip": "sint",
      "Type": "AnonymousAssociate",
      "GroupIdx": 351,
      "FullName": "Claire Gerhold DDS",
      "FormalName": "Tromp, Becker and Kreiger",
      "Deleted": true,
      "EjUserId": 665,
      "UserName": "Kreiger Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 797
        }
      }
    }
  }
]
```