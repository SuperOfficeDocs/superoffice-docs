---
title: POST Agents/User/CreateDefaultRoleEntity
id: v1UserAgent_CreateDefaultRoleEntity
---

# POST Agents/User/CreateDefaultRoleEntity

```http
POST /api/v1/Agents/User/CreateDefaultRoleEntity
```

Set default values into a new RoleEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






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
POST /api/v1/Agents/User/CreateDefaultRoleEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 14,
  "Name": "Effertz, Roberts and Lynch",
  "Tooltip": "in",
  "RoleType": "Anonymous",
  "Deleted": 177,
  "Rank": 810,
  "Created": "2017-06-22T18:28:50.4854401+02:00",
  "UseCategories": 211,
  "CreatedBy": {
    "AssociateId": 367,
    "Name": "Oberbrunner Inc and Sons",
    "PersonId": 670,
    "Rank": 528,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 879,
    "FullName": "Lea Bartell",
    "FormalName": "DuBuque-Mosciski",
    "Deleted": true,
    "EjUserId": 440,
    "UserName": "Purdy-Wiegand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 944
      }
    }
  },
  "Updated": "2014-12-14T18:28:50.4854401+01:00",
  "UpdatedBy": {
    "AssociateId": 1001,
    "Name": "Lehner-Prosacco",
    "PersonId": 224,
    "Rank": 466,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 898,
    "FullName": "Odell Weissnat DVM",
    "FormalName": "O'Keefe-Trantow",
    "Deleted": true,
    "EjUserId": 375,
    "UserName": "Ratke-Crona",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 738
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
          "Value": "blanditiis",
          "Description": "Exclusive static utilisation",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "synergize back-end web services"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 21
            }
          }
        }
      ],
      [
        {
          "Value": "enim",
          "Description": "Operative dynamic Graphical User Interface",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "empower extensible web-readiness"
              },
              "FieldType": "System.Int32",
              "FieldLength": 332
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
        "FieldLength": 754
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
      "FieldLength": 21
    }
  }
}
```