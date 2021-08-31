---
title: CreateDefaultRoleEntity
id: v1UserAgent_CreateDefaultRoleEntity
---

# CreateDefaultRoleEntity

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
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 497,
  "Name": "Bauch-Cole",
  "Tooltip": "sequi",
  "RoleType": "Anonymous",
  "Deleted": 166,
  "Rank": 751,
  "Created": "2021-08-08T14:58:05.5390542+02:00",
  "UseCategories": 179,
  "CreatedBy": {
    "AssociateId": 719,
    "Name": "Rice-Langworth",
    "PersonId": 113,
    "Rank": 557,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 482,
    "FullName": "Reinhold Stanton",
    "FormalName": "Cummerata-Kling",
    "Deleted": true,
    "EjUserId": 627,
    "UserName": "Gerhold-Bayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 447
      }
    }
  },
  "Updated": "1998-07-07T14:58:05.5390542+02:00",
  "UpdatedBy": {
    "AssociateId": 596,
    "Name": "Swaniawski-Fisher",
    "PersonId": 632,
    "Rank": 827,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 911,
    "FullName": "Carmella Kuhn",
    "FormalName": "Lockman LLC",
    "Deleted": true,
    "EjUserId": 473,
    "UserName": "Mante, Dickinson and Mitchell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 540
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
          "Value": "maxime",
          "Description": "Customer-focused intangible application",
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
              "FieldLength": 631
            }
          }
        }
      ],
      [
        {
          "Value": "pariatur",
          "Description": "Triple-buffered transitional paradigm",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "enable extensible models"
              },
              "FieldType": "System.String",
              "FieldLength": 44
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
        "FieldLength": 655
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
      "FieldLength": 718
    }
  }
}
```