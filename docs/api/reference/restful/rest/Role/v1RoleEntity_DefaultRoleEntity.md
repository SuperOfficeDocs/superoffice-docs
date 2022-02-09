---
title: GET Role/default
id: v1RoleEntity_DefaultRoleEntity
---

# GET Role/default

```http
GET /api/v1/Role/default
```

Set default values into a new RoleEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps. Calls the User agent service CreateDefaultRoleEntity.






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
GET /api/v1/Role/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 255,
  "Name": "Koepp-Greenholt",
  "Tooltip": "aspernatur",
  "RoleType": "Anonymous",
  "Deleted": 294,
  "Rank": 796,
  "Created": "2019-03-11T18:25:50.8598852+01:00",
  "UseCategories": 312,
  "CreatedBy": {
    "AssociateId": 73,
    "Name": "Rogahn LLC",
    "PersonId": 344,
    "Rank": 212,
    "Tooltip": "sequi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 656,
    "FullName": "Lester O'Connell",
    "FormalName": "Schuster-Johnston",
    "Deleted": true,
    "EjUserId": 190,
    "UserName": "Pacocha-Corwin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 55
      }
    }
  },
  "Updated": "2018-01-24T18:25:50.8598852+01:00",
  "UpdatedBy": {
    "AssociateId": 551,
    "Name": "Hahn, Braun and Lang",
    "PersonId": 747,
    "Rank": 422,
    "Tooltip": "labore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 378,
    "FullName": "Ricardo Metz DVM",
    "FormalName": "Schultz Group",
    "Deleted": false,
    "EjUserId": 967,
    "UserName": "Smith, Boehm and Padberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "aggregate killer initiatives"
        },
        "FieldType": "System.String",
        "FieldLength": 303
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
          "Value": "iure",
          "Description": "Diverse multi-state concept",
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
              "FieldLength": 581
            }
          }
        }
      ],
      [
        {
          "Value": "quod",
          "Description": "Automated bifurcated frame",
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
              "FieldLength": 755
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
        "FieldLength": 887
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
      "FieldLength": 912
    }
  }
}
```