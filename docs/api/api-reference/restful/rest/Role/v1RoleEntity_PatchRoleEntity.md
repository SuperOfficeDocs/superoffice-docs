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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "a",
    "value": {
      "value1": {
        "PrimaryKey": 4175,
        "EntityName": "person",
        "personId": 4175,
        "fullName": "Willow Padberg"
      },
      "value2": {
        "PrimaryKey": 5363,
        "EntityName": "sale",
        "saleId": 5363,
        "contactId": 3245,
        "name": "Schmitt, Lemke and Purdy"
      }
    }
  },
  {
    "op": "add",
    "path": "a",
    "value": {
      "value1": {
        "PrimaryKey": 4175,
        "EntityName": "person",
        "personId": 4175,
        "fullName": "Willow Padberg"
      },
      "value2": {
        "PrimaryKey": 5363,
        "EntityName": "sale",
        "saleId": 5363,
        "contactId": 3245,
        "name": "Schmitt, Lemke and Purdy"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 RoleEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 286,
  "Name": "Runolfsson, Koepp and Zieme",
  "Tooltip": "eveniet",
  "RoleType": "Anonymous",
  "Deleted": 839,
  "Rank": 357,
  "Created": "2014-05-23T09:40:59.5166627+02:00",
  "UseCategories": 771,
  "CreatedBy": {
    "AssociateId": 112,
    "Name": "Schuster LLC",
    "PersonId": 488,
    "Rank": 336,
    "Tooltip": "minus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 111,
    "FullName": "Baby Murray",
    "FormalName": "Mitchell, Davis and Brekke",
    "Deleted": true,
    "EjUserId": 692,
    "UserName": "Tromp Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 806
      }
    }
  },
  "Updated": "1999-08-12T09:40:59.5166627+02:00",
  "UpdatedBy": {
    "AssociateId": 713,
    "Name": "Nikolaus Group",
    "PersonId": 331,
    "Rank": 179,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 369,
    "FullName": "Dr. Ubaldo Beatty",
    "FormalName": "Rowe, Dare and Dickinson",
    "Deleted": false,
    "EjUserId": 836,
    "UserName": "Wolff Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 46
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
          "Value": "eum",
          "Description": "Fundamental cohesive implementation",
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
              "FieldLength": 330
            }
          }
        }
      ],
      [
        {
          "Value": "et",
          "Description": "Progressive disintermediate capacity",
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
              "FieldLength": 186
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
        "FieldLength": 528
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
      "FieldLength": 171
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```