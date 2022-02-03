---
title: PATCH Role/{id}
id: v1RoleEntity_PatchRoleEntity
---

# PATCH Role/{id}

```http
PATCH /api/v1/Role/{id}
```

Update a RoleEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IUserAgent} service SaveRoleEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The RoleEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Role/{id}?$select=name,department,category/id
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




RoleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | RoleEntity  updated. |
| 404 | RoleEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because RoleEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RoleId | int32 | Primary key |
| Name | string | Visible role name |
| Tooltip | string | Description of the role. |
| RoleType | string | The role type. Note that changing this field has no effect, so treat this as a read-only field. |
| Deleted | int32 | 1 if role has been deleted (we do not actually delete) |
| Rank | int32 | Sorting rank of this role in lists |
| Created | date-time | Registered when  in UTC. |
| UseCategories | int32 | Apply role category membership to users |
| CreatedBy |  | Created by user |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedBy |  | Last updated by user |
| DataRights |  | Data rights matrix - defines role's access to data owned by current user, users in same group, and other users. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Role/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "consequatur",
    "value": {
      "value1": {
        "PrimaryKey": 3433,
        "EntityName": "sale",
        "saleId": 3433,
        "contactId": 792,
        "name": "Koelpin Group"
      },
      "value2": {
        "PrimaryKey": 5119,
        "EntityName": "person",
        "personId": 5119,
        "fullName": "Dr. Kavon King"
      }
    }
  },
  {
    "op": "add",
    "path": "consequatur",
    "value": {
      "value1": {
        "PrimaryKey": 3433,
        "EntityName": "sale",
        "saleId": 3433,
        "contactId": 792,
        "name": "Koelpin Group"
      },
      "value2": {
        "PrimaryKey": 5119,
        "EntityName": "person",
        "personId": 5119,
        "fullName": "Dr. Kavon King"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 RoleEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 384,
  "Name": "Pfannerstill LLC",
  "Tooltip": "libero",
  "RoleType": "Anonymous",
  "Deleted": 687,
  "Rank": 164,
  "Created": "2003-04-06T18:25:50.8728837+02:00",
  "UseCategories": 663,
  "CreatedBy": {
    "AssociateId": 436,
    "Name": "Haag Group",
    "PersonId": 684,
    "Rank": 669,
    "Tooltip": "cupiditate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 886,
    "FullName": "Mrs. Dianna Wisoky",
    "FormalName": "Kuhn-Barton",
    "Deleted": false,
    "EjUserId": 680,
    "UserName": "Funk, Wilkinson and Lesch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 434
      }
    }
  },
  "Updated": "2013-06-30T18:25:50.8728837+02:00",
  "UpdatedBy": {
    "AssociateId": 921,
    "Name": "Fritsch LLC",
    "PersonId": 204,
    "Rank": 441,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 339,
    "FullName": "Eusebio Stiedemann",
    "FormalName": "Sporer-Bauch",
    "Deleted": true,
    "EjUserId": 854,
    "UserName": "Jewess-Herman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 485
      }
    }
  },
  "DataRights": {
    "ColumnsInfo": [
      {},
      {}
    ],
    "RowsInfo": [
      {},
      {}
    ],
    "Rights": [
      [
        {
          "Value": "voluptate",
          "Description": "Multi-layered mobile time-frame",
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
              "FieldLength": 107
            }
          }
        }
      ],
      [
        {
          "Value": "excepturi",
          "Description": "Customer-focused solution-oriented extranet",
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
              "FieldLength": 942
            }
          }
        }
      ]
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "target value-added initiatives"
        },
        "FieldType": "System.Int32",
        "FieldLength": 17
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
      "FieldType": "System.Int32",
      "FieldLength": 322
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```