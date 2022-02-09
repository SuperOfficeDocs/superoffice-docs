---
title: PATCH RelationDefinition/{id}
id: v1RelationDefinitionEntity_PatchRelationDefinitionEntity
---

# PATCH RelationDefinition/{id}

```http
PATCH /api/v1/RelationDefinition/{id}
```

Update a RelationDefinitionEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IListAgent} service SaveRelationDefinitionEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The RelationDefinitionEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/RelationDefinition/{id}?$select=name,department,category/id
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

A relation definition entity with source and destination tables



RelationDefinitionEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | RelationDefinitionEntity  updated. |
| 404 | RelationDefinitionEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because RelationDefinitionEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReldefId | int32 | Primary key |
| Name | string | Active text |
| Tooltip | string | Tooltip or other description |
| PassiveText | string | Text used in passive direction |
| Deleted | bool | True if deleted |
| Rank | int32 | Rank order |
| Source | string | The source of the relation |
| Destination | string | The destination of the relation |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/RelationDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "ut",
    "value": {
      "value1": {
        "PrimaryKey": 7273,
        "EntityName": "sale",
        "saleId": 7273,
        "contactId": 660,
        "name": "Auer, Purdy and Medhurst"
      },
      "value2": {
        "PrimaryKey": 3155,
        "EntityName": "sale",
        "saleId": 3155,
        "contactId": 4679,
        "name": "Kutch, Wisoky and Ruecker"
      }
    }
  },
  {
    "op": "add",
    "path": "ut",
    "value": {
      "value1": {
        "PrimaryKey": 7273,
        "EntityName": "sale",
        "saleId": 7273,
        "contactId": 660,
        "name": "Auer, Purdy and Medhurst"
      },
      "value2": {
        "PrimaryKey": 3155,
        "EntityName": "sale",
        "saleId": 3155,
        "contactId": 4679,
        "name": "Kutch, Wisoky and Ruecker"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 RelationDefinitionEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 784,
  "Name": "Beahan, Brekke and Corkery",
  "Tooltip": "fugiat",
  "PassiveText": "eum",
  "Deleted": true,
  "Rank": 795,
  "Source": "Both",
  "Destination": "Both",
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
      "FieldLength": 134
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```