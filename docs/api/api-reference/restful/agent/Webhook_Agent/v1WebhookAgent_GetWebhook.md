---
title: GetWebhook
id: v1WebhookAgent_GetWebhook
---

# GetWebhook

```http
POST /api/v1/Agents/Webhook/GetWebhook
```

Gets a Webhook object.



## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| webhookId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Webhook/GetWebhook?webhookId=819
POST /api/v1/Agents/Webhook/GetWebhook?$select=name,department,category/id
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
POST /api/v1/Agents/Webhook/GetWebhook
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 513,
  "Name": "Zieme, Lubowitz and Kilback",
  "Events": [
    "soluta",
    "vitae"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "inventore",
  "State": "Active",
  "Type": "molestiae",
  "Headers": {
    "Headers1": "dolores",
    "Headers2": "id"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2017-11-28T14:58:05.6140553+01:00",
  "RegisteredAssociate": {
    "AssociateId": 581,
    "Name": "Rau-Jones",
    "PersonId": 12,
    "Rank": 924,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 316,
    "FullName": "Sydni Ward",
    "FormalName": "Pfannerstill Group",
    "Deleted": false,
    "EjUserId": 400,
    "UserName": "Reichel Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
  "Updated": "2009-03-19T14:58:05.6140553+01:00",
  "UpdatedAssociate": {
    "AssociateId": 437,
    "Name": "Jones, Morar and Pagac",
    "PersonId": 193,
    "Rank": 760,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 796,
    "FullName": "Woodrow Murray",
    "FormalName": "Stark LLC",
    "Deleted": true,
    "EjUserId": 134,
    "UserName": "Champlin Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 100
      }
    }
  }
}
```