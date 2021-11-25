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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "RoleId": 962,
  "Name": "Will, Hamill and Reynolds",
  "Tooltip": "consequatur",
  "RoleType": "Anonymous",
  "Deleted": 943,
  "Rank": 592,
  "Created": "1998-10-25T18:25:50.8618853+01:00",
  "UseCategories": 318,
  "CreatedBy": {
    "AssociateId": 90,
    "Name": "Lindgren Inc and Sons",
    "PersonId": 266,
    "Rank": 664,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 552,
    "FullName": "Keegan Leannon",
    "FormalName": "Yundt, Jast and Wyman",
    "Deleted": true,
    "EjUserId": 892,
    "UserName": "Marquardt-Mante"
  },
  "Updated": "2003-12-02T18:25:50.8618853+01:00",
  "UpdatedBy": {
    "AssociateId": 381,
    "Name": "Barrows, Ankunding and Dibbert",
    "PersonId": 685,
    "Rank": 115,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 985,
    "FullName": "Rowan Sanford",
    "FormalName": "Moen Inc and Sons",
    "Deleted": false,
    "EjUserId": 894,
    "UserName": "Jast, Gleichner and Hyatt"
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
          "Value": "maiores",
          "Description": "Balanced methodical throughput",
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
              "FieldLength": 441
            }
          }
        }
      ],
      [
        {
          "Value": "sit",
          "Description": "Enterprise-wide multimedia array",
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
              "FieldLength": 541
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
  "RoleId": 33,
  "Name": "Runolfsdottir-Jast",
  "Tooltip": "quo",
  "RoleType": "Anonymous",
  "Deleted": 424,
  "Rank": 122,
  "Created": "2017-04-24T18:25:50.864884+02:00",
  "UseCategories": 512,
  "CreatedBy": {
    "AssociateId": 461,
    "Name": "Buckridge LLC",
    "PersonId": 934,
    "Rank": 678,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 609,
    "FullName": "Miss Albin Deckow",
    "FormalName": "Langworth, Kassulke and Frami",
    "Deleted": false,
    "EjUserId": 498,
    "UserName": "Lockman-Larkin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 326
      }
    }
  },
  "Updated": "1997-12-08T18:25:50.864884+01:00",
  "UpdatedBy": {
    "AssociateId": 296,
    "Name": "Reichert Group",
    "PersonId": 172,
    "Rank": 681,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 895,
    "FullName": "Westley Romaguera",
    "FormalName": "Nader Group",
    "Deleted": true,
    "EjUserId": 955,
    "UserName": "Farrell, Shields and Hammes",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 673
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
          "Value": "voluptates",
          "Description": "Organized reciprocal groupware",
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
              "FieldLength": 887
            }
          }
        }
      ],
      [
        {
          "Value": "quos",
          "Description": "Future-proofed neutral matrices",
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
              "FieldLength": 560
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
        "FieldLength": 233
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "integrate holistic partnerships"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 814
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```