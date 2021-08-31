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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "RoleId": 263,
  "Name": "Hoeger, Volkman and Heathcote",
  "Tooltip": "voluptatem",
  "RoleType": "Anonymous",
  "Deleted": 323,
  "Rank": 849,
  "Created": "2016-08-18T15:05:42.5516354+02:00",
  "UseCategories": 34,
  "CreatedBy": {
    "AssociateId": 750,
    "Name": "Reichel Inc and Sons",
    "PersonId": 541,
    "Rank": 893,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 641,
    "FullName": "Dr. Jaydon Reichel",
    "FormalName": "Hammes, Cremin and Torp",
    "Deleted": true,
    "EjUserId": 848,
    "UserName": "Gusikowski, Auer and Berge"
  },
  "Updated": "2006-05-17T15:05:42.5526352+02:00",
  "UpdatedBy": {
    "AssociateId": 269,
    "Name": "Reilly, Wisoky and Schaefer",
    "PersonId": 258,
    "Rank": 929,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 63,
    "FullName": "Rowan Wisoky",
    "FormalName": "Zulauf LLC",
    "Deleted": true,
    "EjUserId": 624,
    "UserName": "Koss, Keebler and Muller"
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
          "Value": "optio",
          "Description": "Synergized grid-enabled open system",
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
              "FieldLength": 724
            }
          }
        }
      ],
      [
        {
          "Value": "hic",
          "Description": "Diverse well-modulated infrastructure",
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
              "FieldLength": 778
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
  "RoleId": 775,
  "Name": "Langworth-Feil",
  "Tooltip": "iusto",
  "RoleType": "Anonymous",
  "Deleted": 446,
  "Rank": 152,
  "Created": "2017-06-08T15:05:42.5536351+02:00",
  "UseCategories": 937,
  "CreatedBy": {
    "AssociateId": 684,
    "Name": "Emmerich, Feil and Fay",
    "PersonId": 758,
    "Rank": 482,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 485,
    "FullName": "Lyric Wehner",
    "FormalName": "Mertz Inc and Sons",
    "Deleted": true,
    "EjUserId": 472,
    "UserName": "Rohan Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 189
      }
    }
  },
  "Updated": "2001-08-21T15:05:42.5546347+02:00",
  "UpdatedBy": {
    "AssociateId": 414,
    "Name": "Pagac LLC",
    "PersonId": 231,
    "Rank": 551,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 707,
    "FullName": "Richie Powlowski I",
    "FormalName": "Russel LLC",
    "Deleted": true,
    "EjUserId": 657,
    "UserName": "Gusikowski, Gerhold and Spencer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 45
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
          "Value": "debitis",
          "Description": "Stand-alone full-range structure",
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
              "FieldLength": 100
            }
          }
        }
      ],
      [
        {
          "Value": "quaerat",
          "Description": "Balanced context-sensitive neural-net",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "harness integrated applications"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 507
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
        "FieldLength": 156
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
      "FieldLength": 412
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```