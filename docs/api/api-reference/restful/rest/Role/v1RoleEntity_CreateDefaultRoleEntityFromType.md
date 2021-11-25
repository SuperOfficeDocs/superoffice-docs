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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 925,
  "Name": "King-Heller",
  "Tooltip": "iste",
  "RoleType": "Anonymous",
  "Deleted": 99,
  "Rank": 852,
  "Created": "2007-05-16T18:25:50.8818867+02:00",
  "UseCategories": 507,
  "CreatedBy": {
    "AssociateId": 559,
    "Name": "Green-Medhurst",
    "PersonId": 116,
    "Rank": 195,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 643,
    "FullName": "Bertrand Gislason",
    "FormalName": "Hyatt-Jacobson",
    "Deleted": false,
    "EjUserId": 482,
    "UserName": "Armstrong-Gleason",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 872
      }
    }
  },
  "Updated": "2005-02-07T18:25:50.8818867+01:00",
  "UpdatedBy": {
    "AssociateId": 293,
    "Name": "Kuvalis, Kling and Kuvalis",
    "PersonId": 410,
    "Rank": 391,
    "Tooltip": "ea",
    "Type": "AnonymousAssociate",
    "GroupIdx": 445,
    "FullName": "Christa Muller",
    "FormalName": "Yost-Lesch",
    "Deleted": true,
    "EjUserId": 293,
    "UserName": "Denesik-West",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "strategize extensible content"
        },
        "FieldType": "System.String",
        "FieldLength": 240
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
          "Value": "perspiciatis",
          "Description": "Customer-focused object-oriented installation",
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
              "FieldLength": 225
            }
          }
        }
      ],
      [
        {
          "Value": "quia",
          "Description": "Adaptive uniform time-frame",
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
              "FieldLength": 733
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
        "FieldLength": 431
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
      "FieldLength": 971
    }
  }
}
```