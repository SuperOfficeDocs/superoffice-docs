---
title: GET Role/{type}/Default
id: v1RoleEntity_CreateDefaultRoleEntityFromType
---

# GET Role/{type}/Default

```http
GET /api/v1/Role/{type}/Default
```

Create a new role entity of the specified role type.

The role type cannot be changed after the entity is created.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| type | Enum: Employee, ExternalUser, Anonymous, System | Type of role (Employee/External/Anonymous/System) **Required** |



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
GET /api/v1/Role/{type}/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 221,
  "Name": "Hudson-Will",
  "Tooltip": "totam",
  "RoleType": "Anonymous",
  "Deleted": 681,
  "Rank": 971,
  "Created": "2009-10-30T15:05:42.5726352+01:00",
  "UseCategories": 43,
  "CreatedBy": {
    "AssociateId": 52,
    "Name": "Haley, Schulist and Pfeffer",
    "PersonId": 782,
    "Rank": 572,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 218,
    "FullName": "Neal Bogisich",
    "FormalName": "Smitham, Hills and Pagac",
    "Deleted": true,
    "EjUserId": 643,
    "UserName": "Bartell, Altenwerth and Crooks",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 659
      }
    }
  },
  "Updated": "2012-04-09T15:05:42.5726352+02:00",
  "UpdatedBy": {
    "AssociateId": 392,
    "Name": "McGlynn-Lehner",
    "PersonId": 117,
    "Rank": 606,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 779,
    "FullName": "Mya Marvin",
    "FormalName": "Metz-Abernathy",
    "Deleted": true,
    "EjUserId": 645,
    "UserName": "Bradtke, Murphy and Abbott",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 158
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
          "Value": "impedit",
          "Description": "Decentralized explicit website",
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
              "FieldLength": 631
            }
          }
        }
      ],
      [
        {
          "Value": "harum",
          "Description": "Multi-tiered object-oriented support",
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
              "FieldLength": 414
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
          "Reason": "facilitate proactive web services"
        },
        "FieldType": "System.String",
        "FieldLength": 715
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
      "FieldLength": 585
    }
  }
}
```