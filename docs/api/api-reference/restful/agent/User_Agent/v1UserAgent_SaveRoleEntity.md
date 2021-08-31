---
title: SaveRoleEntity
id: v1UserAgent_SaveRoleEntity
---

# SaveRoleEntity

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
  "RoleId": 177,
  "Name": "Erdman Group",
  "Tooltip": "dicta",
  "RoleType": "Anonymous",
  "Deleted": 62,
  "Rank": 216,
  "Created": "2001-12-31T14:58:05.5400545+01:00",
  "UseCategories": 666,
  "CreatedBy": {
    "AssociateId": 623,
    "Name": "Ondricka, Kreiger and Simonis",
    "PersonId": 273,
    "Rank": 722,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 35,
    "FullName": "Jeff Fadel",
    "FormalName": "Dickinson-Moore",
    "Deleted": false,
    "EjUserId": 319,
    "UserName": "Casper-Rosenbaum"
  },
  "Updated": "2016-07-04T14:58:05.5400545+02:00",
  "UpdatedBy": {
    "AssociateId": 729,
    "Name": "Lueilwitz, Jast and Pfeffer",
    "PersonId": 36,
    "Rank": 909,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 380,
    "FullName": "Tess Eichmann Sr.",
    "FormalName": "Rodriguez LLC",
    "Deleted": false,
    "EjUserId": 689,
    "UserName": "Conroy LLC"
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
          "Value": "dolorum",
          "Description": "Synergized tertiary methodology",
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
              "FieldLength": 673
            }
          }
        }
      ],
      [
        {
          "Value": "est",
          "Description": "Extended systemic algorithm",
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
              "FieldLength": 111
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
  "RoleId": 900,
  "Name": "Hickle, Boehm and Gleason",
  "Tooltip": "quis",
  "RoleType": "Anonymous",
  "Deleted": 89,
  "Rank": 709,
  "Created": "2000-06-04T14:58:05.5420582+02:00",
  "UseCategories": 271,
  "CreatedBy": {
    "AssociateId": 499,
    "Name": "Hilpert, Jacobi and Toy",
    "PersonId": 844,
    "Rank": 320,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 295,
    "FullName": "Dr. Rowland Murphy",
    "FormalName": "Kuhn, O'Conner and Kuphal",
    "Deleted": false,
    "EjUserId": 151,
    "UserName": "Volkman LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 997
      }
    }
  },
  "Updated": "2019-02-25T14:58:05.5430542+01:00",
  "UpdatedBy": {
    "AssociateId": 908,
    "Name": "Kautzer, Kerluke and Strosin",
    "PersonId": 848,
    "Rank": 772,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 197,
    "FullName": "Dr. Golden Pfeffer",
    "FormalName": "Herman-Braun",
    "Deleted": true,
    "EjUserId": 40,
    "UserName": "Wiegand-Kerluke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 316
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
          "Value": "sapiente",
          "Description": "Networked zero defect emulation",
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
              "FieldLength": 576
            }
          }
        }
      ],
      [
        {
          "Value": "consequatur",
          "Description": "Synchronised grid-enabled knowledge user",
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
              "FieldLength": 227
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
        "FieldLength": 147
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
      "FieldLength": 220
    }
  }
}
```