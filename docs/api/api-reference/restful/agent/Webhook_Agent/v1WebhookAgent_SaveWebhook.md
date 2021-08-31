---
title: SaveWebhook
id: v1WebhookAgent_SaveWebhook
---

# SaveWebhook

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 388,
  "Name": "Pacocha-Hand",
  "Events": [
    "asperiores",
    "magnam"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "nihil",
  "State": "Active",
  "Type": "repellat",
  "Headers": {
    "Headers1": "adipisci",
    "Headers2": "voluptas"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2004-11-22T14:58:05.6100555+01:00",
  "RegisteredAssociate": {
    "AssociateId": 854,
    "Name": "Wuckert Group",
    "PersonId": 124,
    "Rank": 695,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 787,
    "FullName": "Margaretta Bechtelar",
    "FormalName": "Keebler, Kassulke and Harris",
    "Deleted": true,
    "EjUserId": 156,
    "UserName": "Conroy, Emard and Sanford"
  },
  "Updated": "1997-11-23T14:58:05.6110565+01:00",
  "UpdatedAssociate": {
    "AssociateId": 151,
    "Name": "Pagac, Tremblay and Boyle",
    "PersonId": 512,
    "Rank": 462,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 983,
    "FullName": "Dallin Miller",
    "FormalName": "Wuckert-Larson",
    "Deleted": false,
    "EjUserId": 759,
    "UserName": "West LLC"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 555,
  "Name": "Schroeder LLC",
  "Events": [
    "numquam",
    "atque"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "assumenda",
  "State": "Active",
  "Type": "porro",
  "Headers": {
    "Headers1": "molestiae",
    "Headers2": "ea"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2003-07-19T14:58:05.6120552+02:00",
  "RegisteredAssociate": {
    "AssociateId": 462,
    "Name": "Torp, Crooks and Hermann",
    "PersonId": 465,
    "Rank": 802,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 815,
    "FullName": "Roslyn Crooks",
    "FormalName": "Pacocha Inc and Sons",
    "Deleted": false,
    "EjUserId": 932,
    "UserName": "Boyle, Rowe and Cormier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 197
      }
    }
  },
  "Updated": "2000-10-12T14:58:05.6120552+02:00",
  "UpdatedAssociate": {
    "AssociateId": 875,
    "Name": "Romaguera-Marks",
    "PersonId": 833,
    "Rank": 452,
    "Tooltip": "nulla",
    "Type": "AnonymousAssociate",
    "GroupIdx": 393,
    "FullName": "Fannie Schroeder",
    "FormalName": "Dicki-Frami",
    "Deleted": false,
    "EjUserId": 180,
    "UserName": "Pouros, Trantow and Baumbach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 411
      }
    }
  }
}
```