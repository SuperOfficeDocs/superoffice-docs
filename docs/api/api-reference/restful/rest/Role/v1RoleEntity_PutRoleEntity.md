---
title: PUT Role/{id}
id: v1RoleEntity_PutRoleEntity
---

# PUT Role/{id}

```http
PUT /api/v1/Role/{id}
```

Updates the existing RoleEntity



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The RoleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Role/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity  

The RoleEntity to be saved. 

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


## Response: object




RoleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | RoleEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Role/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "RoleId": 945,
  "Name": "Metz-Schneider",
  "Tooltip": "consequatur",
  "RoleType": "Anonymous",
  "Deleted": 178,
  "Rank": 757,
  "Created": "2006-12-26T15:05:42.5576352+01:00",
  "UseCategories": 237,
  "CreatedBy": {
    "AssociateId": 73,
    "Name": "Kuhlman, Romaguera and Hintz",
    "PersonId": 611,
    "Rank": 591,
    "Tooltip": "labore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 999,
    "FullName": "Harmon Langosh",
    "FormalName": "Veum, Hermiston and Padberg",
    "Deleted": false,
    "EjUserId": 945,
    "UserName": "Nitzsche LLC"
  },
  "Updated": "2004-03-11T15:05:42.5586353+01:00",
  "UpdatedBy": {
    "AssociateId": 159,
    "Name": "Kirlin, Lang and Nienow",
    "PersonId": 838,
    "Rank": 855,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 136,
    "FullName": "Maddison Huels V",
    "FormalName": "Powlowski LLC",
    "Deleted": true,
    "EjUserId": 724,
    "UserName": "Glover, Denesik and Greenfelder"
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
          "Value": "saepe",
          "Description": "Persevering hybrid alliance",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "strategize sticky applications"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 79
            }
          }
        }
      ],
      [
        {
          "Value": "ea",
          "Description": "Compatible hybrid initiative",
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
              "FieldLength": 60
            }
          }
        }
      ]
    ]
  }
}
```

```http_
HTTP/1.1 200 RoleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 831,
  "Name": "Gorczany LLC",
  "Tooltip": "aspernatur",
  "RoleType": "Anonymous",
  "Deleted": 80,
  "Rank": 691,
  "Created": "2014-08-18T15:05:42.5596348+02:00",
  "UseCategories": 478,
  "CreatedBy": {
    "AssociateId": 296,
    "Name": "Gutmann Group",
    "PersonId": 544,
    "Rank": 449,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 178,
    "FullName": "Madalyn Ernser",
    "FormalName": "Little-Johnson",
    "Deleted": false,
    "EjUserId": 487,
    "UserName": "Herman Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline one-to-one solutions"
        },
        "FieldType": "System.String",
        "FieldLength": 335
      }
    }
  },
  "Updated": "2010-10-30T15:05:42.5606352+02:00",
  "UpdatedBy": {
    "AssociateId": 368,
    "Name": "Schmeler-Windler",
    "PersonId": 238,
    "Rank": 799,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 61,
    "FullName": "Natalia Collier",
    "FormalName": "Heaney, Jaskolski and Larkin",
    "Deleted": true,
    "EjUserId": 952,
    "UserName": "Pagac-Bode",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 372
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
          "Value": "eaque",
          "Description": "Ergonomic modular database",
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
              "FieldLength": 625
            }
          }
        }
      ],
      [
        {
          "Value": "maiores",
          "Description": "Profound heuristic intranet",
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
              "FieldLength": 800
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
        "FieldType": "System.String",
        "FieldLength": 236
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
      "FieldLength": 129
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```