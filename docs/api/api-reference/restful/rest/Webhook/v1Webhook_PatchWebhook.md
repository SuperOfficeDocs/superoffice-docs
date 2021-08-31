---
title: PATCH Webhook/{id}
id: v1Webhook_PatchWebhook
---

# PATCH Webhook/{id}

```http
PATCH /api/v1/Webhook/{id}
```

Update a Webhook with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.


## Online Restricted: ## The Webhook agent is not available in Online by default. Access must be requested specifically when app is registered. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IWebhookAgent} service SaveWebhook.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Webhook  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Webhook/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

Webhook definitions. Webhooks broadcast events from NetServer to remote servers.



Webhook entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | Webhook  updated. |
| 404 | Webhook with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because Webhook has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "culpa",
    "value": {
      "value1": {
        "PrimaryKey": 6023,
        "EntityName": "person",
        "personId": 6023,
        "fullName": "Judah Lind"
      },
      "value2": {
        "PrimaryKey": 9459,
        "EntityName": "sale",
        "saleId": 9459,
        "contactId": 6275,
        "name": "Gerhold Inc and Sons"
      }
    }
  },
  {
    "op": "add",
    "path": "culpa",
    "value": {
      "value1": {
        "PrimaryKey": 6023,
        "EntityName": "person",
        "personId": 6023,
        "fullName": "Judah Lind"
      },
      "value2": {
        "PrimaryKey": 9459,
        "EntityName": "sale",
        "saleId": 9459,
        "contactId": 6275,
        "name": "Gerhold Inc and Sons"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 Webhook  updated.
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 592,
  "Name": "Reilly, Quigley and Zemlak",
  "Events": [
    "sapiente",
    "quia"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "quod",
  "State": "Active",
  "Type": "omnis",
  "Headers": {
    "Headers1": "mollitia",
    "Headers2": "consectetur"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2016-04-14T15:05:43.2018986+02:00",
  "RegisteredAssociate": {
    "AssociateId": 307,
    "Name": "Effertz LLC",
    "PersonId": 966,
    "Rank": 132,
    "Tooltip": "deserunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 42,
    "FullName": "Mr. Rex Hickle",
    "FormalName": "Mosciski-Schmitt",
    "Deleted": true,
    "EjUserId": 647,
    "UserName": "Dibbert LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize sexy e-business"
        },
        "FieldType": "System.Int32",
        "FieldLength": 442
      }
    }
  },
  "Updated": "2017-09-14T15:05:43.2018986+02:00",
  "UpdatedAssociate": {
    "AssociateId": 957,
    "Name": "Hand, Beier and Glover",
    "PersonId": 771,
    "Rank": 379,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 891,
    "FullName": "Josephine Kuphal",
    "FormalName": "DuBuque Group",
    "Deleted": false,
    "EjUserId": 833,
    "UserName": "Gibson, Larson and Jaskolski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```