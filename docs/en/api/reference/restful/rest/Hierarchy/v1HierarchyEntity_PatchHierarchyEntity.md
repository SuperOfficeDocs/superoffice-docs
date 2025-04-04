---
title: PATCH Hierarchy/{id}
uid: v1HierarchyEntity_PatchHierarchyEntity
generated: true
---

# PATCH Hierarchy/{id}

```http
PATCH /api/v1/Hierarchy/{id}
```

Update a HierarchyEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


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



Calls the {SuperOffice.CRM.Services.IListAgent} service SaveHierarchyEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The HierarchyEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Hierarchy/{id}?$select=name,department,category/id
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

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

HierarchyEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | HierarchyEntity  updated. |
| 404 | HierarchyEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because HierarchyEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: HierarchyEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| HierarchyId | int32 | The primary key (auto-incremented) |
| Domain | string | Domain seperating the different hierarchy |
| Name | string | Name of this hierarchy folder. |
| Fullname | string | The full name of this category, i.e. Foo/bar/test. |
| ParentId | int32 | Parent table |
| Children | array | Sub-items, if any. |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "reprehenderit",
    "value": {}
  },
  {
    "op": "add",
    "path": "reprehenderit",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 HierarchyEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 658,
  "Domain": "Dashboards",
  "Name": "Luettgen, Sipes and Wiza",
  "Fullname": "quam",
  "ParentId": 283,
  "Children": [
    {
      "HierarchyId": 478,
      "Domain": "Dashboards",
      "Name": "Lakin Group",
      "Fullname": "non",
      "ParentId": 7,
      "Children": [
        {},
        {}
      ],
      "Registered": "1999-10-09T13:14:08.7741411+02:00",
      "RegisteredAssociateId": 194,
      "Updated": "1998-11-24T13:14:08.7741411+01:00",
      "UpdatedAssociateId": 821,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "Registered": "2020-12-09T13:14:08.7741411+01:00",
  "RegisteredAssociateId": 69,
  "Updated": "2024-10-16T13:14:08.7741411+02:00",
  "UpdatedAssociateId": 223,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 959
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```