---
title: POST Agents/Webhook/GetWebhook
id: v1WebhookAgent_GetWebhook
---

# POST Agents/Webhook/GetWebhook

```http
POST /api/v1/Agents/Webhook/GetWebhook
```

Gets a Webhook object.



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| webhookId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Webhook/GetWebhook?webhookId=935
POST /api/v1/Agents/Webhook/GetWebhook?$select=name,department,category/id
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
POST /api/v1/Agents/Webhook/GetWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 583,
  "Name": "Robel, West and Connelly",
  "Events": [
    "consectetur",
    "dolorem"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "harum",
  "State": "Active",
  "Type": "tempora",
  "Headers": {
    "Headers1": "labore",
    "Headers2": "earum"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2014-09-01T18:28:50.6114149+02:00",
  "RegisteredAssociate": {
    "AssociateId": 370,
    "Name": "Corkery-Thompson",
    "PersonId": 414,
    "Rank": 536,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 444,
    "FullName": "Asa Abshire",
    "FormalName": "Cummerata, Blanda and Mertz",
    "Deleted": true,
    "EjUserId": 153,
    "UserName": "Paucek, Bradtke and McDermott",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 446
      }
    }
  },
  "Updated": "2020-09-20T18:28:50.6114149+02:00",
  "UpdatedAssociate": {
    "AssociateId": 513,
    "Name": "Stark LLC",
    "PersonId": 752,
    "Rank": 100,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 835,
    "FullName": "Hans Deckow",
    "FormalName": "Bergstrom-Braun",
    "Deleted": false,
    "EjUserId": 139,
    "UserName": "Lakin-Abshire",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 102
      }
    }
  }
}
```