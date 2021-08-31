---
title: PATCH ShipmentMessageBlock/{id}
id: v1ShipmentMessageBlockEntity_PatchShipmentMessageBlockEntity
---

# PATCH ShipmentMessageBlock/{id}

```http
PATCH /api/v1/ShipmentMessageBlock/{id}
```

Update a ShipmentMessageBlockEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IMarketingAgent} service SaveShipmentMessageBlockEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ShipmentMessageBlockEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/ShipmentMessageBlock/{id}?$select=name,department,category/id
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

This entity contains information about design blocks that can be used in a shipment/mailing message



ShipmentMessageBlockEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ShipmentMessageBlockEntity  updated. |
| 404 | ShipmentMessageBlockEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ShipmentMessageBlockEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentMessageBlockId | int32 | Primary key |
| AssociateId | int32 | The associate that owns this block |
| Block | string | The block definition. Normally this will be a json structure |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| UpdatedCount | int32 | Number of updates made to this record |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/ShipmentMessageBlock/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "quia",
    "value": {
      "value1": {
        "PrimaryKey": 1334,
        "EntityName": "sale",
        "saleId": 1334,
        "contactId": 3066,
        "name": "Ankunding, Heathcote and Cremin"
      },
      "value2": {
        "PrimaryKey": 2519,
        "EntityName": "person",
        "personId": 2519,
        "fullName": "Damon McDermott"
      }
    }
  },
  {
    "op": "add",
    "path": "quia",
    "value": {
      "value1": {
        "PrimaryKey": 1334,
        "EntityName": "sale",
        "saleId": 1334,
        "contactId": 3066,
        "name": "Ankunding, Heathcote and Cremin"
      },
      "value2": {
        "PrimaryKey": 2519,
        "EntityName": "person",
        "personId": 2519,
        "fullName": "Damon McDermott"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ShipmentMessageBlockEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ShipmentMessageBlockId": 65,
  "AssociateId": 852,
  "Block": "architecto",
  "Registered": "2003-09-04T15:05:42.7576622+02:00",
  "RegisteredAssociateId": 322,
  "Updated": "2019-01-26T15:05:42.7576622+01:00",
  "UpdatedAssociateId": 534,
  "UpdatedCount": 235,
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
      "FieldLength": 980
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```