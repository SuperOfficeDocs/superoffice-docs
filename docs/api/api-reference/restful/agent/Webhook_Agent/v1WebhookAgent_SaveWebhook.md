---
title: POST Agents/Webhook/SaveWebhook
id: v1WebhookAgent_SaveWebhook
---

# POST Agents/Webhook/SaveWebhook

```http
POST /api/v1/Agents/Webhook/SaveWebhook
```

Updates the existing Webhook or creates a new Webhook if the id parameter is empty



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.






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



Carrier object for Webhook.
Services for the Webhook Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IWebhookAgent">Webhook Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/Webhook/SaveWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 419,
  "Name": "Boyer, Effertz and Anderson",
  "Events": [
    "non",
    "cupiditate"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "sit",
  "State": "Active",
  "Type": "suscipit",
  "Headers": {
    "Headers1": "odio",
    "Headers2": "quod"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2015-02-13T16:48:31.0269345+01:00",
  "RegisteredAssociate": {
    "AssociateId": 429,
    "Name": "Farrell, Larson and Conn",
    "PersonId": 642,
    "Rank": 482,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 907,
    "FullName": "Weston Pagac",
    "FormalName": "Oberbrunner, Wilkinson and Hahn",
    "Deleted": false,
    "EjUserId": 11,
    "UserName": "Paucek LLC"
  },
  "Updated": "2000-08-01T16:48:31.027932+02:00",
  "UpdatedAssociate": {
    "AssociateId": 239,
    "Name": "Daniel-Trantow",
    "PersonId": 347,
    "Rank": 530,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 304,
    "FullName": "Cathy Dickens",
    "FormalName": "Williamson LLC",
    "Deleted": false,
    "EjUserId": 326,
    "UserName": "Watsica, Mosciski and Grant"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 55,
  "Name": "Keeling-Hirthe",
  "Events": [
    "ducimus",
    "voluptas"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "maxime",
  "State": "Active",
  "Type": "pariatur",
  "Headers": {
    "Headers1": "qui",
    "Headers2": "possimus"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2019-01-27T16:48:31.0289347+01:00",
  "RegisteredAssociate": {
    "AssociateId": 521,
    "Name": "Gulgowski-Wunsch",
    "PersonId": 430,
    "Rank": 97,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 632,
    "FullName": "Jade Hintz",
    "FormalName": "Mitchell, Donnelly and Towne",
    "Deleted": false,
    "EjUserId": 140,
    "UserName": "Flatley-Wunsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 486
      }
    }
  },
  "Updated": "2015-02-07T16:48:31.0289347+01:00",
  "UpdatedAssociate": {
    "AssociateId": 614,
    "Name": "Rau, Bartell and Von",
    "PersonId": 767,
    "Rank": 262,
    "Tooltip": "tenetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 74,
    "FullName": "Eulah Kutch",
    "FormalName": "Green, Waters and Fadel",
    "Deleted": true,
    "EjUserId": 373,
    "UserName": "Lueilwitz, O'Conner and Nolan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 837
      }
    }
  }
}
```