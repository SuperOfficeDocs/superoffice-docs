---
title: POST Webhook/Test
id: v1Webhook_TestWebhook
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
POST /api/v1/Webhook/Test
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 391,
  "Name": "Douglas Group",
  "Events": [
    "est",
    "mollitia"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "ut",
  "State": "Active",
  "Type": "dicta",
  "Headers": {
    "Headers1": "quam",
    "Headers2": "velit"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1999-04-12T09:41:00.1223616+02:00",
  "RegisteredAssociate": {
    "AssociateId": 678,
    "Name": "Jerde Inc and Sons",
    "PersonId": 736,
    "Rank": 397,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 768,
    "FullName": "Ms. Lera Gerlach",
    "FormalName": "Armstrong-Breitenberg",
    "Deleted": true,
    "EjUserId": 188,
    "UserName": "McCullough-Sipes"
  },
  "Updated": "2005-05-07T09:41:00.1223616+02:00",
  "UpdatedAssociate": {
    "AssociateId": 586,
    "Name": "Heaney LLC",
    "PersonId": 52,
    "Rank": 706,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 4,
    "FullName": "Brannon Ward",
    "FormalName": "Bradtke LLC",
    "Deleted": false,
    "EjUserId": 646,
    "UserName": "Nikolaus Inc and Sons"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "nulla",
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
      "FieldLength": 273
    }
  }
}
```