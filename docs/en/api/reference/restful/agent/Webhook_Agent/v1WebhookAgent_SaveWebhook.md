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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 943,
  "Name": "Douglas LLC",
  "Events": [
    "molestiae",
    "quidem"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "dicta",
  "State": "Active",
  "Type": "animi",
  "Headers": {
    "Headers1": "ea",
    "Headers2": "harum"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2021-07-05T10:17:56.3634594+02:00",
  "RegisteredAssociate": null,
  "Updated": "2004-04-10T10:17:56.3634594+02:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "eveline@kuhn.name"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 696,
  "Name": "Welch, Hoppe and Ortiz",
  "Events": [
    "et",
    "sunt"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "velit",
  "State": "Active",
  "Type": "minus",
  "Headers": {
    "Headers1": "consequatur",
    "Headers2": "dolores"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2006-01-02T10:17:56.3634594+01:00",
  "RegisteredAssociate": null,
  "Updated": "2020-09-16T10:17:56.3634594+02:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "eleonore.moore@morar.co.uk"
}
```