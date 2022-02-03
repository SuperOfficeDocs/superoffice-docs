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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Webhook": {
    "WebhookId": 724,
    "Name": "Dibbert LLC",
    "Events": [
      "maxime",
      "aut"
    ],
    "TargetUrl": "http://www.example.com/",
    "Secret": "reprehenderit",
    "State": "Active",
    "Type": "enim",
    "Headers": {
      "Headers1": "est",
      "Headers2": "architecto"
    },
    "Properties": {
      "fieldName": {}
    },
    "Registered": "2007-07-16T18:28:50.6144147+02:00",
    "RegisteredAssociate": {},
    "Updated": "2006-12-15T18:28:50.6144147+01:00",
    "UpdatedAssociate": {}
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "ut",
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
      "FieldType": "System.String",
      "FieldLength": 404
    }
  }
}
```