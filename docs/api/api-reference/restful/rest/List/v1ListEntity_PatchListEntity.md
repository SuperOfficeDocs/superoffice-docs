---
title: PATCH List/{id}
id: v1ListEntity_PatchListEntity
---

# PATCH List/{id}

```http
PATCH /api/v1/List/{id}
```

Update a ListEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IListAgent} service SaveListEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ListEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/List/{id}?$select=name,department,category/id
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

The list entity contains information about a specific list



ListEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ListEntity  updated. |
| 404 | ListEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ListEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list |
| Name | string | The name of the list |
| Tooltip | string | The tooltip of the list |
| Deleted | bool | True if the list item is marked as deleted |
| Rank | int32 | The rank of the list |
| IsCustomList | bool | Indicates if this is a custom list or a standard list |
| IsMDOList | bool | Indicates if this is a MDO list |
| UseGroupsAndHeadings | bool | Indicates if this list should use groups and headings |
| ListType | string | The type of this list, often indicated by the database name, but not necessarily |
| InUseByUserDefinedFields | bool | True if this in use by one or more udfields |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/List/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "autem",
    "value": {
      "value1": {
        "PrimaryKey": 1419,
        "EntityName": "person",
        "personId": 1419,
        "fullName": "Delbert Senger"
      },
      "value2": {
        "PrimaryKey": 8597,
        "EntityName": "person",
        "personId": 8597,
        "fullName": "Dewayne Kunze"
      }
    }
  },
  {
    "op": "add",
    "path": "autem",
    "value": {
      "value1": {
        "PrimaryKey": 1419,
        "EntityName": "person",
        "personId": 1419,
        "fullName": "Delbert Senger"
      },
      "value2": {
        "PrimaryKey": 8597,
        "EntityName": "person",
        "personId": 8597,
        "fullName": "Dewayne Kunze"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ListEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Id": 313,
  "Name": "Hills, Mills and Jakubowski",
  "Tooltip": "est",
  "Deleted": true,
  "Rank": 427,
  "IsCustomList": true,
  "IsMDOList": true,
  "UseGroupsAndHeadings": false,
  "ListType": "quisquam",
  "InUseByUserDefinedFields": false,
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
      "FieldLength": 296
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```