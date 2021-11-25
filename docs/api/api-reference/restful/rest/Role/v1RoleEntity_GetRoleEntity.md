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
Accept-Language: *
```

```http_
HTTP/1.1 200 RoleEntity found.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 308,
  "Name": "Cronin LLC",
  "Tooltip": "sunt",
  "RoleType": "Anonymous",
  "Deleted": 82,
  "Rank": 27,
  "Created": "1998-04-27T18:25:50.8668838+02:00",
  "UseCategories": 67,
  "CreatedBy": {
    "AssociateId": 116,
    "Name": "Turcotte, Beer and Pagac",
    "PersonId": 472,
    "Rank": 592,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 42,
    "FullName": "Ryder Bogisich",
    "FormalName": "Roberts Inc and Sons",
    "Deleted": false,
    "EjUserId": 172,
    "UserName": "Hettinger-Deckow",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness back-end web services"
        },
        "FieldType": "System.String",
        "FieldLength": 431
      }
    }
  },
  "Updated": "1997-06-03T18:25:50.8668838+02:00",
  "UpdatedBy": {
    "AssociateId": 652,
    "Name": "Cummings-Kreiger",
    "PersonId": 39,
    "Rank": 666,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 905,
    "FullName": "Estel McKenzie",
    "FormalName": "Gislason-Grant",
    "Deleted": true,
    "EjUserId": 481,
    "UserName": "Heidenreich-Hodkiewicz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 702
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
          "Value": "ex",
          "Description": "Self-enabling non-volatile capability",
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
              "FieldLength": 644
            }
          }
        }
      ],
      [
        {
          "Value": "vel",
          "Description": "Balanced homogeneous superstructure",
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
              "FieldLength": 595
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
        "FieldLength": 231
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "optimize sexy infrastructures"
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
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```