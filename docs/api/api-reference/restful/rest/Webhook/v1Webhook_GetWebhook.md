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
Accept-Language: en
```

```http_
HTTP/1.1 200 Webhook found.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 840,
  "Name": "Langworth, Dibbert and Wyman",
  "Events": [
    "omnis",
    "laudantium"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "perferendis",
  "State": "Active",
  "Type": "voluptate",
  "Headers": {
    "Headers1": "beatae",
    "Headers2": "temporibus"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2017-04-08T15:05:43.1968986+02:00",
  "RegisteredAssociate": {
    "AssociateId": 178,
    "Name": "Weimann, Bradtke and Davis",
    "PersonId": 591,
    "Rank": 598,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 214,
    "FullName": "Althea Hilpert",
    "FormalName": "Lang Group",
    "Deleted": false,
    "EjUserId": 490,
    "UserName": "Pollich-Goodwin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 17
      }
    }
  },
  "Updated": "2001-11-15T15:05:43.1968986+01:00",
  "UpdatedAssociate": {
    "AssociateId": 306,
    "Name": "Pacocha, Cole and Homenick",
    "PersonId": 529,
    "Rank": 379,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 625,
    "FullName": "Lavada Howe",
    "FormalName": "Wyman-Cartwright",
    "Deleted": true,
    "EjUserId": 925,
    "UserName": "Kuhlman, Weimann and Tremblay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 288
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```