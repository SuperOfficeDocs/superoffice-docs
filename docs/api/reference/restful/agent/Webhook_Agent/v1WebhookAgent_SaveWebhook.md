---
title: POST Agents/Webhook/SaveWebhook
id: v1WebhookAgent_SaveWebhook
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

Webhook definitions. Webhooks broadcast events from NetServer to remote servers.



Carrier object for Webhook.
Services for the Webhook Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IWebhookAgent">Webhook Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Webhook/SaveWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 776,
  "Name": "Runte-Larkin",
  "Events": [
    "aut",
    "vero"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "facere",
  "State": "Active",
  "Type": "quis",
  "Headers": {
    "Headers1": "totam",
    "Headers2": "nulla"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2014-06-25T18:28:50.6074146+02:00",
  "RegisteredAssociate": {
    "AssociateId": 393,
    "Name": "Eichmann Group",
    "PersonId": 881,
    "Rank": 492,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 171,
    "FullName": "Audie Schultz",
    "FormalName": "Price-Medhurst",
    "Deleted": true,
    "EjUserId": 562,
    "UserName": "Bode, Greenholt and Conroy"
  },
  "Updated": "2003-06-20T18:28:50.6074146+02:00",
  "UpdatedAssociate": {
    "AssociateId": 315,
    "Name": "Steuber, Schimmel and Leuschke",
    "PersonId": 812,
    "Rank": 386,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 582,
    "FullName": "Christa Kuhic",
    "FormalName": "Kuhn, Gorczany and Nienow",
    "Deleted": true,
    "EjUserId": 935,
    "UserName": "Lynch, Frami and Weimann"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 309,
  "Name": "Treutel, Murray and Terry",
  "Events": [
    "sint",
    "mollitia"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "qui",
  "State": "Active",
  "Type": "a",
  "Headers": {
    "Headers1": "natus",
    "Headers2": "neque"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1995-12-08T18:28:50.6094147+01:00",
  "RegisteredAssociate": {
    "AssociateId": 367,
    "Name": "Nienow Inc and Sons",
    "PersonId": 897,
    "Rank": 870,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 741,
    "FullName": "Andy Weissnat",
    "FormalName": "Sawayn-Okuneva",
    "Deleted": false,
    "EjUserId": 234,
    "UserName": "Collins Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 69
      }
    }
  },
  "Updated": "2017-02-07T18:28:50.6094147+01:00",
  "UpdatedAssociate": {
    "AssociateId": 279,
    "Name": "Muller Group",
    "PersonId": 680,
    "Rank": 902,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 255,
    "FullName": "Kenneth Abernathy",
    "FormalName": "Denesik, Ritchie and Bins",
    "Deleted": true,
    "EjUserId": 240,
    "UserName": "Doyle Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 329
      }
    }
  }
}
```