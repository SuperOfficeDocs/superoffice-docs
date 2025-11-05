---
title: POST Webhook
uid: v1Webhook_PostWebhook
generated: true
content_type: reference
---

# POST Webhook

```http
POST /api/v1/Webhook
```

Creates a new Webhook


Calls the Webhook agent service SaveWebhook.
NsApiSlow threshold: 2000 ms.


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

### Response body: WebhookWithLinks

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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Webhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 344,
  "Name": "Murray-Jenkins",
  "Events": [
    "voluptatibus",
    "beatae"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "ut",
  "State": "Active",
  "Type": "omnis",
  "Headers": {
    "Headers1": "quis",
    "Headers2": "qui"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2018-11-22T02:30:53.1786436+01:00",
  "RegisteredAssociate": null,
  "Updated": "2016-01-22T02:30:53.1786436+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "elouise@casperreynolds.com"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 80,
  "Name": "Hudson LLC",
  "Events": [
    "saepe",
    "quia"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "et",
  "State": "Active",
  "Type": "et",
  "Headers": {
    "Headers1": "amet",
    "Headers2": "doloremque"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2004-02-25T02:30:53.1786436+01:00",
  "RegisteredAssociate": null,
  "Updated": "2000-09-28T02:30:53.1786436+02:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "colleen_schaefer@cormierbruen.biz",
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```