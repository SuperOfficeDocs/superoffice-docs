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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "est",
    "value": {
      "value1": {
        "PrimaryKey": 9204,
        "EntityName": "sale",
        "saleId": 9204,
        "contactId": 3912,
        "name": "Donnelly Group"
      },
      "value2": {
        "PrimaryKey": 2118,
        "EntityName": "sale",
        "saleId": 2118,
        "contactId": 5317,
        "name": "Littel-Thompson"
      }
    }
  },
  {
    "op": "add",
    "path": "est",
    "value": {
      "value1": {
        "PrimaryKey": 9204,
        "EntityName": "sale",
        "saleId": 9204,
        "contactId": 3912,
        "name": "Donnelly Group"
      },
      "value2": {
        "PrimaryKey": 2118,
        "EntityName": "sale",
        "saleId": 2118,
        "contactId": 5317,
        "name": "Littel-Thompson"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 SystemEventEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "SystemEventId": 28,
  "Scope": "Database",
  "Eta": "2002-03-02T15:05:42.8036632+01:00",
  "Eventkey": "cumque",
  "Eventmess": "non",
  "ExtraInfo": 578,
  "Owner": 452,
  "UpdatedCount": 399,
  "Registered": "2015-05-06T15:05:42.8036632+02:00",
  "ActivatedBy": {
    "AssociateId": 689,
    "Name": "Thiel Inc and Sons",
    "PersonId": 672,
    "Rank": 634,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 688,
    "FullName": "Yasmin Spinka",
    "FormalName": "Bartell, Bergstrom and Osinski",
    "Deleted": true,
    "EjUserId": 270,
    "UserName": "Feest, Abbott and Padberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 264
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
        "Reason": "integrate dynamic infrastructures"
      },
      "FieldType": "System.Int32",
      "FieldLength": 560
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```