---
title: POST Agents/Webhook/SaveWebhook
uid: v1WebhookAgent_SaveWebhook
generated: true
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
| WebhookId | Integer | Primary Key. Unique id for this webhook. |
| Name | String | Name to identify this webhook. Does not have to be unique. |
| Events | Array | Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] |
| TargetUrl | String | Destination to POST event info to. URL for webhooks. Id for CRM scripts |
| Secret | String | Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server |
| State | String | Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors |
| Type | String | Name of plugin that handles this webhook. 'webhook' for HTTP POST notifications, 'crmscript' for script invocations. |
| Headers | Object | Custom HTTP Headers to add to webhook requests. |
| Properties | Object | Custom values to inject into JSON body of webhook call. |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociate | Associate | The user that created the webhook. |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociate | Associate | The user that last updated the webhook. |
| ErrorsEmail | String | Email address to send error message to when this webhook state changes to too-many errors. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Webhook

| Property Name | Type |  Description |
|----------------|------|--------------|
| WebhookId | int32 | Primary Key. Unique id for this webhook. |
| Name | string | Name to identify this webhook. Does not have to be unique. |
| Events | array | Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] |
| TargetUrl | string | Destination to POST event info to. URL for webhooks. Id for CRM scripts |
| Secret | string | Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server |
| State | string | Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors |
| Type | string | Name of plugin that handles this webhook. 'webhook' for HTTP POST notifications, 'crmscript' for script invocations. |
| Headers | object | Custom HTTP Headers to add to webhook requests. |
| Properties | object | Custom values to inject into JSON body of webhook call. |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociate | Associate | The user that created the webhook. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociate | Associate | The user that last updated the webhook. |
| ErrorsEmail | string | Email address to send error message to when this webhook state changes to too-many errors. |

## Sample request

```http!
POST /api/v1/Agents/Webhook/SaveWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 988,
  "Name": "Crist LLC",
  "Events": [
    "perferendis",
    "sequi"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "officia",
  "State": "Active",
  "Type": "eos",
  "Headers": {
    "Headers1": "labore",
    "Headers2": "sequi"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2022-11-27T11:44:35.0406407+01:00",
  "RegisteredAssociate": null,
  "Updated": "2014-03-02T11:44:35.0406407+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "armani@considinetillman.com"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 79,
  "Name": "Durgan Group",
  "Events": [
    "quod",
    "blanditiis"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "id",
  "State": "Active",
  "Type": "molestiae",
  "Headers": {
    "Headers1": "porro",
    "Headers2": "dolor"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2011-04-11T11:44:35.0562611+02:00",
  "RegisteredAssociate": null,
  "Updated": "2005-01-19T11:44:35.0562611+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "catharine@blockstehr.us"
}
```