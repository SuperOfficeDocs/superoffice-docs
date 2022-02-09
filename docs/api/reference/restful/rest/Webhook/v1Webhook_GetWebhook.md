---
title: GET Webhook/{id}
id: v1Webhook_GetWebhook
---

# GET Webhook/{id}

```http
GET /api/v1/Webhook/{id}
```

Gets a Webhook object.

Calls the Webhook agent service GetWebhook.


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Webhook to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/Webhook/{id}?$select=name,department,category/id
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



Webhook entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | Webhook found. |
| 404 | Not Found. |

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
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 Webhook found.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 605,
  "Name": "King, Rogahn and Schmitt",
  "Events": [
    "et",
    "molestias"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "dolorem",
  "State": "Active",
  "Type": "similique",
  "Headers": {
    "Headers1": "reiciendis",
    "Headers2": "doloremque"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "1998-10-27T18:25:51.5631208+01:00",
  "RegisteredAssociate": {
    "AssociateId": 178,
    "Name": "Boehm-Schulist",
    "PersonId": 140,
    "Rank": 603,
    "Tooltip": "tempora",
    "Type": "AnonymousAssociate",
    "GroupIdx": 436,
    "FullName": "Theresa Wiza",
    "FormalName": "Cassin-Smith",
    "Deleted": true,
    "EjUserId": 658,
    "UserName": "Bergstrom LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 963
      }
    }
  },
  "Updated": "2019-11-13T18:25:51.5631208+01:00",
  "UpdatedAssociate": {
    "AssociateId": 779,
    "Name": "Boyer, Sipes and Dach",
    "PersonId": 652,
    "Rank": 316,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 522,
    "FullName": "Elyse Corkery",
    "FormalName": "Jakubowski, Greenholt and Bogan",
    "Deleted": false,
    "EjUserId": 531,
    "UserName": "Schroeder, Ebert and Renner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 966
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```