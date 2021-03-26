---
title: POST Agents/Webhook/TestWebhook
id: v1WebhookAgent_TestWebhook
---

# POST Agents/Webhook/TestWebhook

```http
POST /api/v1/Agents/Webhook/TestWebhook
```

Pings a webhook with a 'test' event, returns SUCCESS(true) or FAILURE(false) + the response from the webhook target.



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Webhook/TestWebhook?$select=name,department,category/id
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

## Request Body: request  

Webhook 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Webhook |  | Webhook definitions. Webhooks broadcast events from NetServer to remote servers. <para /> Carrier object for Webhook. Services for the Webhook Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IWebhookAgent">Webhook Agent</see>. |


## Response: object

Result of calling a webhook



Carrier object for WebhookResult.
Services for the WebhookResult Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IWebhookAgent">Webhook Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | Was call to webhook successful? (200 OK) |
| Message | string | Headers and body of response from webhook |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Webhook/TestWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Webhook": {
    "WebhookId": 596,
    "Name": "Schamberger, Predovic and VonRueden",
    "Events": [
      "quod",
      "mollitia"
    ],
    "TargetUrl": "http://www.example.com/",
    "Secret": "autem",
    "State": "Active",
    "Type": "labore",
    "Headers": {
      "Headers1": "voluptas",
      "Headers2": "hic"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "2015-11-28T16:48:31.0339347+01:00",
    "RegisteredAssociate": {},
    "Updated": "2018-11-06T16:48:31.0339347+01:00",
    "UpdatedAssociate": {}
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": true,
  "Message": "rerum",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 953
    }
  }
}
```