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
    "path": "rerum",
    "value": {
      "value1": {
        "PrimaryKey": 4370,
        "EntityName": "sale",
        "saleId": 4370,
        "contactId": 8049,
        "name": "Bins LLC"
      },
      "value2": {
        "PrimaryKey": 1922,
        "EntityName": "person",
        "personId": 1922,
        "fullName": "Owen Shields"
      }
    }
  },
  {
    "op": "add",
    "path": "rerum",
    "value": {
      "value1": {
        "PrimaryKey": 4370,
        "EntityName": "sale",
        "saleId": 4370,
        "contactId": 8049,
        "name": "Bins LLC"
      },
      "value2": {
        "PrimaryKey": 1922,
        "EntityName": "person",
        "personId": 1922,
        "fullName": "Owen Shields"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 RoleEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 771,
  "Name": "McGlynn, Langosh and Christiansen",
  "Tooltip": "suscipit",
  "RoleType": "Anonymous",
  "Deleted": 216,
  "Rank": 875,
  "Created": "2010-12-27T15:05:42.5636352+01:00",
  "UseCategories": 467,
  "CreatedBy": {
    "AssociateId": 712,
    "Name": "McLaughlin-Kuhlman",
    "PersonId": 652,
    "Rank": 426,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 628,
    "FullName": "Dr. Melba Hansen",
    "FormalName": "Stehr-Farrell",
    "Deleted": false,
    "EjUserId": 970,
    "UserName": "Fadel-Turner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  },
  "Updated": "2006-11-02T15:05:42.5636352+01:00",
  "UpdatedBy": {
    "AssociateId": 115,
    "Name": "Watsica-Marvin",
    "PersonId": 686,
    "Rank": 955,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 419,
    "FullName": "Billie Fisher",
    "FormalName": "Collier Inc and Sons",
    "Deleted": true,
    "EjUserId": 670,
    "UserName": "Schneider, Schmidt and Zemlak",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 906
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
          "Value": "et",
          "Description": "Self-enabling context-sensitive challenge",
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
              "FieldLength": 698
            }
          }
        }
      ],
      [
        {
          "Value": "iure",
          "Description": "Up-sized homogeneous toolset",
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
              "FieldLength": 302
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
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 755
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
        "Reason": "exploit user-centric markets"
      },
      "FieldType": "System.String",
      "FieldLength": 72
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```