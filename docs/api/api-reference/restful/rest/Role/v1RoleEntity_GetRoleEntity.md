---
title: GET Role/{id}
id: v1RoleEntity_GetRoleEntity
---

# GET Role/{id}

```http
GET /api/v1/Role/{id}
```

Gets a RoleEntity object.

Calls the User agent service GetRoleEntity.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the RoleEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/Role/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object




RoleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | RoleEntity found. |
| 404 | Not Found. |

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
GET /api/v1/Role/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 RoleEntity found.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 523,
  "Name": "Lind Group",
  "Tooltip": "qui",
  "RoleType": "Anonymous",
  "Deleted": 281,
  "Rank": 486,
  "Created": "2002-09-30T09:40:59.5086627+02:00",
  "UseCategories": 60,
  "CreatedBy": {
    "AssociateId": 309,
    "Name": "Kovacek Inc and Sons",
    "PersonId": 70,
    "Rank": 674,
    "Tooltip": "blanditiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 269,
    "FullName": "Kane Kirlin DDS",
    "FormalName": "Smith Group",
    "Deleted": false,
    "EjUserId": 288,
    "UserName": "Grimes-Farrell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 903
      }
    }
  },
  "Updated": "2005-01-18T09:40:59.5096626+01:00",
  "UpdatedBy": {
    "AssociateId": 703,
    "Name": "Volkman-Goldner",
    "PersonId": 557,
    "Rank": 439,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 367,
    "FullName": "Dr. Ray Fisher",
    "FormalName": "Hirthe Inc and Sons",
    "Deleted": true,
    "EjUserId": 500,
    "UserName": "Williamson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 199
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
          "Value": "omnis",
          "Description": "Centralized leading edge parallelism",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "optimize sticky markets"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 105
            }
          }
        }
      ],
      [
        {
          "Value": "unde",
          "Description": "Fully-configurable holistic methodology",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "exploit front-end technologies"
              },
              "FieldType": "System.String",
              "FieldLength": 816
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
        "FieldLength": 930
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
      "FieldLength": 148
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```