---
title: PATCH ForeignApp/{id}
id: v1ForeignAppEntity_PatchForeignAppEntity
---

# PATCH ForeignApp/{id}

```http
PATCH /api/v1/ForeignApp/{id}
```

Update a ForeignAppEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

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



Calls the {SuperOffice.CRM.Services.IForeignSystemAgent} service SaveForeignAppEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ForeignAppEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/ForeignApp/{id}?$select=name,department,category/id
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




ForeignAppEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ForeignAppEntity  updated. |
| 404 | ForeignAppEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ForeignAppEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy |  | The person that created the foreign application. |
| UpdatedBy |  | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/ForeignApp/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "voluptas",
    "value": {
      "value1": {
        "PrimaryKey": 6352,
        "EntityName": "sale",
        "saleId": 6352,
        "contactId": 7901,
        "name": "Gottlieb, Gleichner and Berge"
      },
      "value2": {
        "PrimaryKey": 8989,
        "EntityName": "person",
        "personId": 8989,
        "fullName": "Kamron Reichel"
      }
    }
  },
  {
    "op": "add",
    "path": "voluptas",
    "value": {
      "value1": {
        "PrimaryKey": 6352,
        "EntityName": "sale",
        "saleId": 6352,
        "contactId": 7901,
        "name": "Gottlieb, Gleichner and Berge"
      },
      "value2": {
        "PrimaryKey": 8989,
        "EntityName": "person",
        "personId": 8989,
        "fullName": "Kamron Reichel"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 ForeignAppEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 397,
  "Name": "Carroll, Nicolas and Kshlerin",
  "CreatedDate": "2000-04-18T18:25:50.5656106+02:00",
  "UpdatedDate": "2021-02-21T18:25:50.5656106+01:00",
  "CreatedBy": {
    "AssociateId": 320,
    "Name": "Rolfson, Kshlerin and Littel",
    "PersonId": 164,
    "Rank": 999,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 424,
    "FullName": "Delilah Spencer",
    "FormalName": "Runte Inc and Sons",
    "Deleted": false,
    "EjUserId": 90,
    "UserName": "Reynolds LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 515
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 179,
    "Name": "Johnson, Champlin and Dach",
    "PersonId": 181,
    "Rank": 682,
    "Tooltip": "excepturi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 881,
    "FullName": "Chaim Jerde Sr.",
    "FormalName": "Kub-Bode",
    "Deleted": false,
    "EjUserId": 75,
    "UserName": "Pouros Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 397
      }
    }
  },
  "Devices": [
    {
      "ForeignDeviceId": 658,
      "Name": "Romaguera Group",
      "CreatedDate": "2010-06-22T18:25:50.5665969+02:00",
      "UpdatedDate": "2000-03-06T18:25:50.5665969+01:00",
      "AssociateFullName": "Dr. Donnell Howe",
      "CreatedBy": "alias",
      "UpdatedBy": "qui",
      "DeviceIdentifier": "voluptas",
      "ForeignAppId": 338,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 676
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "optimize holistic niches"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 555
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```