---
title: PUT Webhook/{id}
uid: v1Webhook_PutWebhook
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
| WebhookId | Integer | Primary Key. Unique id for this webhook. |
| Name | String | Name to identify this webhook. Does not have to be unique. |
| Events | Array | Array of event names that trigger this webhook: ['contact.created', 'sale.changed'] |
| TargetUrl | String | Destination to POST event info to. URL for webhooks. Id for CRM scripts |
| Secret | String | Shared secret key used for generating SHA256 HMAC signature, so that receiver can verify that call came from this server |
| State | String | Webhook status - should we post events to the URL? 1=Active, 2=Stopped or 3=TooManyErrors |
| Type | String | Name of plugin that handles this webhook. 'webhook' for webhooks, which are handled by the system plugin. |
| Headers | Object | Custom HTTP Headers to add to webhook requests. |
| Properties | Object | Custom values to inject into JSON body of webhook call. |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociate | Associate | The user that created the webhook. |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociate | Associate | The user that last updated the webhook. |

## Response:

Webhook updated.

| Response | Description |
|----------------|-------------|
| 200 | Webhook updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: WebhookWithLinks

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
| RegisteredAssociate | Associate | The user that created the webhook. |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociate | Associate | The user that last updated the webhook. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 966,
  "Name": "Gulgowski Inc and Sons",
  "Events": [
    "quis",
    "fugit"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "iusto",
  "State": "Active",
  "Type": "quas",
  "Headers": {
    "Headers1": "sint",
    "Headers2": "soluta"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2016-12-17T15:29:31.0204472+01:00",
  "RegisteredAssociate": null,
  "Updated": "2007-07-15T15:29:31.0209471+02:00",
  "UpdatedAssociate": null
}
```

## Sample response

```http_
HTTP/1.1 200 Webhook updated.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 652,
  "Name": "Swift LLC",
  "Events": [
    "magnam",
    "rerum"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "commodi",
  "State": "Active",
  "Type": "qui",
  "Headers": {
    "Headers1": "nihil",
    "Headers2": "non"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2010-02-07T15:29:31.0229469+01:00",
  "RegisteredAssociate": null,
  "Updated": "2014-12-28T15:29:31.0234471+01:00",
  "UpdatedAssociate": null,
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```