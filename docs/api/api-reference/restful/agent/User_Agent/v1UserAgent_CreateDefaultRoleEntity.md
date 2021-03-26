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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 602,
  "Name": "Spencer-Rippin",
  "Tooltip": "et",
  "RoleType": "Anonymous",
  "Deleted": 267,
  "Rank": 159,
  "Created": "1996-05-21T16:48:30.884935+02:00",
  "UseCategories": 253,
  "CreatedBy": {
    "AssociateId": 12,
    "Name": "Kuhn Group",
    "PersonId": 468,
    "Rank": 481,
    "Tooltip": "a",
    "Type": "AnonymousAssociate",
    "GroupIdx": 854,
    "FullName": "Clare Grady",
    "FormalName": "Keeling-Parisian",
    "Deleted": false,
    "EjUserId": 399,
    "UserName": "Schoen-Homenick",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 234
      }
    }
  },
  "Updated": "2013-08-10T16:48:30.884935+02:00",
  "UpdatedBy": {
    "AssociateId": 809,
    "Name": "Bradtke-Batz",
    "PersonId": 700,
    "Rank": 298,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 727,
    "FullName": "Domingo Adams",
    "FormalName": "Sanford, Koss and Lesch",
    "Deleted": false,
    "EjUserId": 757,
    "UserName": "Luettgen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate user-centric infomediaries"
        },
        "FieldType": "System.Int32",
        "FieldLength": 870
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
          "Value": "accusamus",
          "Description": "Reverse-engineered methodical collaboration",
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
              "FieldLength": 550
            }
          }
        }
      ],
      [
        {
          "Value": "a",
          "Description": "Re-engineered next generation access",
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
              "FieldLength": 983
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
        "FieldLength": 722
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
      "FieldLength": 613
    }
  }
}
```