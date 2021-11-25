---
title: POST Agents/User/SaveRoleEntity
id: v1UserAgent_SaveRoleEntity
---

# POST Agents/User/SaveRoleEntity

```http
POST /api/v1/Agents/User/SaveRoleEntity
```

Updates the existing RoleEntity or creates a new RoleEntity if the id parameter is empty



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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

Carrier object for RoleEntity.
Services for the RoleEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/User/SaveRoleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "RoleId": 918,
  "Name": "O'Hara LLC",
  "Tooltip": "dolorum",
  "RoleType": "Anonymous",
  "Deleted": 163,
  "Rank": 482,
  "Created": "2012-03-18T18:28:50.4864405+01:00",
  "UseCategories": 893,
  "CreatedBy": {
    "AssociateId": 405,
    "Name": "Farrell-Hettinger",
    "PersonId": 105,
    "Rank": 243,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 227,
    "FullName": "Archibald Sawayn",
    "FormalName": "Paucek, Bogisich and Huel",
    "Deleted": false,
    "EjUserId": 171,
    "UserName": "Grimes Group"
  },
  "Updated": "2007-10-28T18:28:50.4864405+01:00",
  "UpdatedBy": {
    "AssociateId": 394,
    "Name": "Auer-Wisoky",
    "PersonId": 957,
    "Rank": 508,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 747,
    "FullName": "Bridgette Erdman",
    "FormalName": "Howell-Shanahan",
    "Deleted": true,
    "EjUserId": 938,
    "UserName": "Kulas Group"
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
          "Value": "tenetur",
          "Description": "Synergistic multimedia portal",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "facilitate granular e-services"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 839
            }
          }
        }
      ],
      [
        {
          "Value": "dicta",
          "Description": "Extended background secured line",
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
  "RoleId": 986,
  "Name": "Wilkinson, Weimann and Funk",
  "Tooltip": "ab",
  "RoleType": "Anonymous",
  "Deleted": 631,
  "Rank": 276,
  "Created": "2002-04-08T18:28:50.4884136+02:00",
  "UseCategories": 436,
  "CreatedBy": {
    "AssociateId": 942,
    "Name": "Lakin-Fisher",
    "PersonId": 319,
    "Rank": 328,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 993,
    "FullName": "Alfreda Marquardt",
    "FormalName": "Christiansen-Yundt",
    "Deleted": true,
    "EjUserId": 25,
    "UserName": "Corkery, Kuhic and Koch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 433
      }
    }
  },
  "Updated": "2015-09-05T18:28:50.489413+02:00",
  "UpdatedBy": {
    "AssociateId": 912,
    "Name": "Ziemann, Gutkowski and Crooks",
    "PersonId": 805,
    "Rank": 714,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 910,
    "FullName": "Edwin Mohr",
    "FormalName": "Ullrich, Zemlak and Langosh",
    "Deleted": false,
    "EjUserId": 368,
    "UserName": "O'Keefe, Berge and Larson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 947
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
          "Value": "ea",
          "Description": "Balanced fault-tolerant success",
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
              "FieldLength": 291
            }
          }
        }
      ],
      [
        {
          "Value": "eos",
          "Description": "User-centric high-level algorithm",
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
              "FieldLength": 556
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
        "FieldLength": 66
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
      "FieldLength": 648
    }
  }
}
```