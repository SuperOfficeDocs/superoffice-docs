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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "RoleId": 205,
  "Name": "Jakubowski, Herman and White",
  "Tooltip": "voluptas",
  "RoleType": "Anonymous",
  "Deleted": 625,
  "Rank": 925,
  "Created": "2010-02-23T18:25:50.8678835+01:00",
  "UseCategories": 922,
  "CreatedBy": {
    "AssociateId": 447,
    "Name": "Smith LLC",
    "PersonId": 967,
    "Rank": 671,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 660,
    "FullName": "Abigayle Ullrich",
    "FormalName": "Lockman LLC",
    "Deleted": true,
    "EjUserId": 709,
    "UserName": "Welch-Dach"
  },
  "Updated": "1998-04-01T18:25:50.8678835+02:00",
  "UpdatedBy": {
    "AssociateId": 117,
    "Name": "Stoltenberg, Trantow and Boehm",
    "PersonId": 70,
    "Rank": 221,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 65,
    "FullName": "Lorna Kling II",
    "FormalName": "Zboncak, Brown and Runolfsdottir",
    "Deleted": true,
    "EjUserId": 73,
    "UserName": "Schultz-Jacobi"
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
          "Value": "facilis",
          "Description": "Virtual grid-enabled interface",
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
              "FieldLength": 945
            }
          }
        }
      ],
      [
        {
          "Value": "qui",
          "Description": "Centralized maximized definition",
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
              "FieldLength": 684
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
  "RoleId": 89,
  "Name": "Heidenreich LLC",
  "Tooltip": "a",
  "RoleType": "Anonymous",
  "Deleted": 587,
  "Rank": 370,
  "Created": "2005-12-31T18:25:50.8698837+01:00",
  "UseCategories": 232,
  "CreatedBy": {
    "AssociateId": 637,
    "Name": "Ullrich-Champlin",
    "PersonId": 97,
    "Rank": 905,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 267,
    "FullName": "Jocelyn Wilderman",
    "FormalName": "Smith Group",
    "Deleted": true,
    "EjUserId": 690,
    "UserName": "Schimmel-Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 225
      }
    }
  },
  "Updated": "2021-06-22T18:25:50.8708834+02:00",
  "UpdatedBy": {
    "AssociateId": 869,
    "Name": "Kutch-Treutel",
    "PersonId": 293,
    "Rank": 251,
    "Tooltip": "vitae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 458,
    "FullName": "Raymond McLaughlin",
    "FormalName": "Bartell Group",
    "Deleted": true,
    "EjUserId": 226,
    "UserName": "Shanahan-Huels",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 156
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
          "Value": "voluptatem",
          "Description": "Seamless optimal groupware",
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
              "FieldLength": 226
            }
          }
        }
      ],
      [
        {
          "Value": "voluptatem",
          "Description": "Virtual fresh-thinking paradigm",
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
              "FieldLength": 98
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
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 387
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```