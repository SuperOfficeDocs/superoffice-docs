---
title: PATCH CRMScript/{id}
id: v1CRMScriptEntity_PatchCRMScriptEntity
---

# PATCH CRMScript/{id}

```http
PATCH /api/v1/CRMScript/{id}
```

Update a CRMScriptEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.


## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.ICRMScriptAgent} service SaveCRMScriptEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CRMScriptEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/CRMScript/{id}?$select=name,department,category/id
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

CRM Scripts - stored in the ejScript table, including source code.



CRMScriptEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | CRMScriptEntity  updated. |
| 404 | CRMScriptEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because CRMScriptEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjscriptId | int32 | Primary key |
| UniqueIdentifier | string | Global unique identifier, accross customers/tenants |
| Name | string | A description of this script |
| Description | string | Optional description of what this script is used for. |
| IncludeId | string | A unique name used for including this script in another |
| HierarchyId | int32 | The script is inside this hierarchy folder |
| Source | string | The script |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/CRMScript/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "accusantium",
    "value": {
      "value1": {
        "PrimaryKey": 5037,
        "EntityName": "sale",
        "saleId": 5037,
        "contactId": 2424,
        "name": "Wunsch-Goldner"
      },
      "value2": {
        "PrimaryKey": 4755,
        "EntityName": "person",
        "personId": 4755,
        "fullName": "Moses Mante V"
      }
    }
  },
  {
    "op": "add",
    "path": "accusantium",
    "value": {
      "value1": {
        "PrimaryKey": 5037,
        "EntityName": "sale",
        "saleId": 5037,
        "contactId": 2424,
        "name": "Wunsch-Goldner"
      },
      "value2": {
        "PrimaryKey": 4755,
        "EntityName": "person",
        "personId": 4755,
        "fullName": "Moses Mante V"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 CRMScriptEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 392,
  "UniqueIdentifier": "qui",
  "Name": "Ruecker-Cummerata",
  "Description": "User-centric homogeneous frame",
  "IncludeId": "impedit",
  "HierarchyId": 528,
  "Source": "voluptas",
  "Registered": "2005-11-09T09:40:59.0598545+01:00",
  "RegisteredAssociateId": 200,
  "Updated": "2006-09-16T09:40:59.0598545+02:00",
  "UpdatedAssociateId": 185,
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
      "FieldLength": 764
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```