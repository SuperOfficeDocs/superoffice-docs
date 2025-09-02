---
title: POST Webhook/Test
uid: v1Webhook_TestWebhook
generated: true
content_type: reference
---

# POST Webhook/Test

```http
POST /api/v1/Webhook/Test
```

Pings a webhook with a 'test' event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target.


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

## Request Body: webhook 

Webhook definition to ping. Must contain a valid TargetUrl. 

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

### Response body: WebhookResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | Was call to webhook successful? (200 OK) |
| Message | string | Headers and body of response from webhook |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Webhook/Test
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 199,
  "Name": "Boehm, Senger and Mosciski",
  "Events": [
    "id",
    "et"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "necessitatibus",
  "State": "Active",
  "Type": "debitis",
  "Headers": {
    "Headers1": "accusantium",
    "Headers2": "illo"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2024-07-11T03:47:00.5505518+02:00",
  "RegisteredAssociate": null,
  "Updated": "2006-03-20T03:47:00.5505518+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "friedrich@johnsonzulauf.com"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "commodi",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 433
    }
  }
}
```