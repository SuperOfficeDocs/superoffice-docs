---
title: PATCH Dash/{id}
id: v1Dash_PatchDash
---

# PATCH Dash/{id}

```http
PATCH /api/v1/Dash/{id}
```

Update a Dash with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IDashAgent} service SaveDash.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dash  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Dash/{id}?$select=name,department,category/id
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

Dashboard configuration



Dash entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | Dash  updated. |
| 404 | Dash with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because Dash has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | Primary key |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme |  | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Dash/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "inventore",
    "value": {
      "value1": {
        "PrimaryKey": 4148,
        "EntityName": "sale",
        "saleId": 4148,
        "contactId": 363,
        "name": "Hyatt-Murray"
      },
      "value2": {
        "PrimaryKey": 3114,
        "EntityName": "sale",
        "saleId": 3114,
        "contactId": 6986,
        "name": "Paucek LLC"
      }
    }
  },
  {
    "op": "add",
    "path": "inventore",
    "value": {
      "value1": {
        "PrimaryKey": 4148,
        "EntityName": "sale",
        "saleId": 4148,
        "contactId": 363,
        "name": "Hyatt-Murray"
      },
      "value2": {
        "PrimaryKey": 3114,
        "EntityName": "sale",
        "saleId": 3114,
        "contactId": 6986,
        "name": "Paucek LLC"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 Dash  updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 53,
  "Name": "Thompson Inc and Sons",
  "Description": "Distributed 6th generation throughput",
  "AssociateId": 131,
  "Columns": 713,
  "Theme": {
    "DashboardThemeId": 170,
    "Name": "Herzog-Herzog",
    "Config": "in",
    "Rank": 13,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 915
      }
    }
  },
  "VisibleForAll": 464,
  "VisibleForAssociates": [
    963,
    144
  ],
  "VisibleForGroups": [
    627,
    216
  ],
  "PinForAll": 885,
  "PinForAssociates": [
    705,
    745
  ],
  "PinForGroups": [
    802,
    259
  ],
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
      "FieldLength": 413
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```