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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "RoleId": 929,
  "Name": "Dickinson-Steuber",
  "Tooltip": "nam",
  "RoleType": "Anonymous",
  "Deleted": 64,
  "Rank": 183,
  "Created": "2004-06-29T16:48:30.8869069+02:00",
  "UseCategories": 467,
  "CreatedBy": {
    "AssociateId": 840,
    "Name": "Bednar LLC",
    "PersonId": 577,
    "Rank": 470,
    "Tooltip": "earum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 949,
    "FullName": "Dr. Johnathan Kuvalis",
    "FormalName": "McKenzie, Kohler and Davis",
    "Deleted": true,
    "EjUserId": 881,
    "UserName": "Hand Group"
  },
  "Updated": "2014-10-24T16:48:30.8869069+02:00",
  "UpdatedBy": {
    "AssociateId": 501,
    "Name": "Stehr-Brakus",
    "PersonId": 597,
    "Rank": 571,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 518,
    "FullName": "Okey Williamson",
    "FormalName": "Von Group",
    "Deleted": false,
    "EjUserId": 898,
    "UserName": "Ondricka-Stiedemann"
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
          "Value": "soluta",
          "Description": "Future-proofed bandwidth-monitored architecture",
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
              "FieldLength": 516
            }
          }
        }
      ],
      [
        {
          "Value": "qui",
          "Description": "Configurable 3rd generation methodology",
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
              "FieldLength": 658
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
  "RoleId": 978,
  "Name": "Roob LLC",
  "Tooltip": "perspiciatis",
  "RoleType": "Anonymous",
  "Deleted": 321,
  "Rank": 499,
  "Created": "2020-11-23T16:48:30.8889301+01:00",
  "UseCategories": 806,
  "CreatedBy": {
    "AssociateId": 407,
    "Name": "Gottlieb-Gusikowski",
    "PersonId": 63,
    "Rank": 788,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 202,
    "FullName": "Deshaun Carter",
    "FormalName": "Waelchi-Rath",
    "Deleted": true,
    "EjUserId": 284,
    "UserName": "Hoppe-Wunsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 665
      }
    }
  },
  "Updated": "1994-09-14T16:48:30.8889301+02:00",
  "UpdatedBy": {
    "AssociateId": 263,
    "Name": "Strosin-Lakin",
    "PersonId": 660,
    "Rank": 908,
    "Tooltip": "ratione",
    "Type": "AnonymousAssociate",
    "GroupIdx": 608,
    "FullName": "Edmond Beahan",
    "FormalName": "Considine LLC",
    "Deleted": false,
    "EjUserId": 785,
    "UserName": "Von LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 993
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
          "Description": "Pre-emptive solution-oriented hardware",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "synthesize dynamic content"
              },
              "FieldType": "System.String",
              "FieldLength": 543
            }
          }
        }
      ],
      [
        {
          "Value": "nam",
          "Description": "Virtual dedicated extranet",
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
              "FieldLength": 598
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
        "FieldLength": 749
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
      "FieldLength": 623
    }
  }
}
```