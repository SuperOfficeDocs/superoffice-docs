---
title: CreateDefaultRoleEntityFromType
id: v1UserAgent_CreateDefaultRoleEntityFromType
---

# CreateDefaultRoleEntityFromType

```http
POST /api/v1/Agents/User/CreateDefaultRoleEntityFromType
```

Create a new role entity of the specified role type.

The role type cannot be changed after the entity is created.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultRoleEntityFromType?$select=name,department,category/id
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

## Request Body: request  

Type 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Type | string |  |


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
POST /api/v1/Agents/User/CreateDefaultRoleEntityFromType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Type": "Anonymous"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RoleId": 18,
  "Name": "Dickinson Inc and Sons",
  "Tooltip": "accusamus",
  "RoleType": "Anonymous",
  "Deleted": 321,
  "Rank": 907,
  "Created": "2014-04-30T14:58:05.5760275+02:00",
  "UseCategories": 382,
  "CreatedBy": {
    "AssociateId": 849,
    "Name": "Littel Group",
    "PersonId": 188,
    "Rank": 691,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 516,
    "FullName": "Lempi Wiegand",
    "FormalName": "Kihn Inc and Sons",
    "Deleted": true,
    "EjUserId": 68,
    "UserName": "Gorczany Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 107
      }
    }
  },
  "Updated": "2019-03-13T14:58:05.5760275+01:00",
  "UpdatedBy": {
    "AssociateId": 469,
    "Name": "Greenholt Group",
    "PersonId": 539,
    "Rank": 358,
    "Tooltip": "impedit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 618,
    "FullName": "Jerrell Gutkowski",
    "FormalName": "Hagenes-Kertzmann",
    "Deleted": true,
    "EjUserId": 666,
    "UserName": "Murray-Fisher",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "scale turn-key ROI"
        },
        "FieldType": "System.String",
        "FieldLength": 992
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
          "Value": "possimus",
          "Description": "Organized logistical moderator",
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
              "FieldLength": 979
            }
          }
        }
      ],
      [
        {
          "Value": "nam",
          "Description": "Ergonomic directional service-desk",
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
              "FieldLength": 626
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
          "Reason": "facilitate web-enabled applications"
        },
        "FieldType": "System.String",
        "FieldLength": 174
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
      "FieldLength": 394
    }
  }
}
```