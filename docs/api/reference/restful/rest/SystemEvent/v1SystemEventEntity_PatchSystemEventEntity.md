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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "modi",
    "value": {
      "value1": {
        "PrimaryKey": 5775,
        "EntityName": "sale",
        "saleId": 5775,
        "contactId": 3031,
        "name": "Wolf, Kautzer and Jenkins"
      },
      "value2": {
        "PrimaryKey": 8263,
        "EntityName": "sale",
        "saleId": 8263,
        "contactId": 837,
        "name": "Ward-Heidenreich"
      }
    }
  },
  {
    "op": "add",
    "path": "modi",
    "value": {
      "value1": {
        "PrimaryKey": 5775,
        "EntityName": "sale",
        "saleId": 5775,
        "contactId": 3031,
        "name": "Wolf, Kautzer and Jenkins"
      },
      "value2": {
        "PrimaryKey": 8263,
        "EntityName": "sale",
        "saleId": 8263,
        "contactId": 837,
        "name": "Ward-Heidenreich"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SystemEventEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 816,
  "Scope": "Database",
  "Eta": "2015-08-28T18:25:51.1239359+02:00",
  "Eventkey": "quia",
  "Eventmess": "suscipit",
  "ExtraInfo": 570,
  "Owner": 720,
  "UpdatedCount": 824,
  "Registered": "1997-07-20T18:25:51.1239359+02:00",
  "ActivatedBy": {
    "AssociateId": 694,
    "Name": "Waters-Kozey",
    "PersonId": 322,
    "Rank": 389,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 171,
    "FullName": "Maximus Mills",
    "FormalName": "Champlin, Kassulke and Hermiston",
    "Deleted": false,
    "EjUserId": 877,
    "UserName": "Little, Brown and Abernathy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 621
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "visualize impactful e-tailers"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "engage customized communities"
      },
      "FieldType": "System.Int32",
      "FieldLength": 47
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```