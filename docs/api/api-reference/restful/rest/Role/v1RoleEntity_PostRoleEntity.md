---
title: POST Role
id: v1RoleEntity_PostRoleEntity
---

# POST Role

```http
POST /api/v1/Role
```

Creates a new RoleEntity

Calls the User agent service SaveRoleEntity.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Role?$select=name,department,category/id
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

## Request Body: newEntity  

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
| 200 | OK |

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
POST /api/v1/Role
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "RoleId": 631,
  "Name": "Considine Inc and Sons",
  "Tooltip": "aut",
  "RoleType": "Anonymous",
  "Deleted": 167,
  "Rank": 80,
  "Created": "2003-11-27T09:40:59.5046627+01:00",
  "UseCategories": 685,
  "CreatedBy": {
    "AssociateId": 353,
    "Name": "Halvorson Group",
    "PersonId": 679,
    "Rank": 956,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 629,
    "FullName": "Colten Lindgren",
    "FormalName": "Howell Group",
    "Deleted": false,
    "EjUserId": 12,
    "UserName": "Stiedemann, Stroman and Farrell"
  },
  "Updated": "1995-03-14T09:40:59.5046627+01:00",
  "UpdatedBy": {
    "AssociateId": 945,
    "Name": "Johnson, Lowe and Roberts",
    "PersonId": 189,
    "Rank": 827,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 181,
    "FullName": "Mable Ferry",
    "FormalName": "Upton Group",
    "Deleted": true,
    "EjUserId": 635,
    "UserName": "Grant-Bernier"
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
          "Value": "animi",
          "Description": "Balanced holistic complexity",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "leverage integrated schemas"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 6
            }
          }
        }
      ],
      [
        {
          "Value": "ea",
          "Description": "Persistent cohesive portal",
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
              "FieldLength": 741
            }
          }
        }
      ]
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 852,
  "Name": "Runolfsson Group",
  "Tooltip": "libero",
  "RoleType": "Anonymous",
  "Deleted": 408,
  "Rank": 216,
  "Created": "2002-11-01T09:40:59.5066629+01:00",
  "UseCategories": 777,
  "CreatedBy": {
    "AssociateId": 437,
    "Name": "Feest, Spencer and Waelchi",
    "PersonId": 574,
    "Rank": 462,
    "Tooltip": "inventore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 352,
    "FullName": "Delilah Rodriguez",
    "FormalName": "Murphy-Bartell",
    "Deleted": true,
    "EjUserId": 8,
    "UserName": "Lind-Boyle",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 469
      }
    }
  },
  "Updated": "2007-11-04T09:40:59.5076626+01:00",
  "UpdatedBy": {
    "AssociateId": 293,
    "Name": "Kohler-Veum",
    "PersonId": 22,
    "Rank": 267,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 368,
    "FullName": "Yvonne DuBuque",
    "FormalName": "Roberts Inc and Sons",
    "Deleted": true,
    "EjUserId": 502,
    "UserName": "Larson Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 357
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
          "Value": "aliquam",
          "Description": "Enterprise-wide encompassing encryption",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "leverage next-generation interfaces"
              },
              "FieldType": "System.String",
              "FieldLength": 331
            }
          }
        }
      ],
      [
        {
          "Value": "porro",
          "Description": "Multi-channelled executive data-warehouse",
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
              "FieldLength": 886
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
        "FieldLength": 949
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
      "FieldLength": 814
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```