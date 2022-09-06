---
title: POST Agents/Webhook/CreateDefaultWebhook
uid: v1WebhookAgent_CreateDefaultWebhook
---

# POST Agents/Webhook/CreateDefaultWebhook

```http
POST /api/v1/Agents/Webhook/CreateDefaultWebhook
```

Set default values into a new Webhook.

NetServer calculates default values on the entity, which is required when creating/storing a new instance

## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered

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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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

## Sample request

```http!
POST /api/v1/Agents/Webhook/CreateDefaultWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 469,
  "Name": "Jerde-Murazik",
  "Events": [
    "quibusdam",
    "adipisci"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "et",
  "State": "Active",
  "Type": "qui",
  "Headers": {
    "Headers1": "autem",
    "Headers2": "soluta"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2006-02-05T11:10:28.4752086+01:00",
  "RegisteredAssociate": null,
  "Updated": "2013-03-10T11:10:28.4752086+01:00",
  "UpdatedAssociate": null
}
```
