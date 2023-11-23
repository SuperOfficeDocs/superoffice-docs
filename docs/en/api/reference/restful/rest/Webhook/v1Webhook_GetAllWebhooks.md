---
title: GET Webhook
uid: v1Webhook_GetAllWebhooks
generated: true
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
GET /api/v1/Webhook?nameFilter=esse
GET /api/v1/Webhook?eventFilter=recusandae
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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
GET /api/v1/Webhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "WebhookId": 610,
    "Name": "Pfannerstill, Boehm and Mohr",
    "Events": [
      "adipisci",
      "eveniet"
    ],
    "TargetUrl": "http://www.example.com/",
    "Secret": "fugit",
    "State": "Active",
    "Type": "sit",
    "Headers": {
      "Headers1": "voluptates",
      "Headers2": "harum"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "2007-03-21T13:38:17.8744364+01:00",
    "RegisteredAssociate": null,
    "Updated": "2008-04-22T13:38:17.8744364+02:00",
    "UpdatedAssociate": null,
    "ErrorsEmail": "cassidy@armstrong.biz"
  }
]
```