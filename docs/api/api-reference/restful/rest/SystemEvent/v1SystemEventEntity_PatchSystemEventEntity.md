---
title: PATCH SystemEvent/{id}
id: v1SystemEventEntity_PatchSystemEventEntity
---

# PATCH SystemEvent/{id}

```http
PATCH /api/v1/SystemEvent/{id}
```

Update a SystemEventEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IConfigurationAgent} service SaveSystemEventEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SystemEventEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/SystemEvent/{id}?$select=name,department,category/id
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

Entity for system events



SystemEventEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SystemEventEntity  updated. |
| 404 | SystemEventEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because SystemEventEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SystemEventId | int32 | Primary key |
| Scope | string | 1 = system-wide, 2= database, 3 = group, 4 = user |
| Eta | date-time | Estimated Time of Arrival, i.e., when will this event finish? |
| Eventkey | string | Event key, predefined in code |
| Eventmess | string | Message to be shown, entered by administrator |
| ExtraInfo | int32 | Extra information (area id for prototype rebuild, etc) |
| Owner | int32 | 0, 0, group_id, assoc id (see over) |
| UpdatedCount | int32 | Number of updates made to this record |
| Registered | date-time | Registered when  in UTC. |
| ActivatedBy |  | The associate that first created the SystemEvent. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/SystemEvent/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "iste",
    "value": {
      "value1": {
        "PrimaryKey": 4372,
        "EntityName": "sale",
        "saleId": 4372,
        "contactId": 2913,
        "name": "Gerlach Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 7114,
        "EntityName": "sale",
        "saleId": 7114,
        "contactId": 3046,
        "name": "Bartell, Runolfsdottir and Kihn"
      }
    }
  },
  {
    "op": "add",
    "path": "iste",
    "value": {
      "value1": {
        "PrimaryKey": 4372,
        "EntityName": "sale",
        "saleId": 4372,
        "contactId": 2913,
        "name": "Gerlach Inc and Sons"
      },
      "value2": {
        "PrimaryKey": 7114,
        "EntityName": "sale",
        "saleId": 7114,
        "contactId": 3046,
        "name": "Bartell, Runolfsdottir and Kihn"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SystemEventEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 482,
  "Scope": "Database",
  "Eta": "2007-03-11T09:40:59.7670648+01:00",
  "Eventkey": "eum",
  "Eventmess": "non",
  "ExtraInfo": 177,
  "Owner": 432,
  "UpdatedCount": 299,
  "Registered": "2007-07-18T09:40:59.7670648+02:00",
  "ActivatedBy": {
    "AssociateId": 975,
    "Name": "Grimes LLC",
    "PersonId": 752,
    "Rank": 934,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 61,
    "FullName": "Roslyn Graham",
    "FormalName": "Krajcik, Johnson and Harvey",
    "Deleted": false,
    "EjUserId": 950,
    "UserName": "Zulauf-Satterfield",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 133
      }
    }
  },
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
      "FieldLength": 523
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```