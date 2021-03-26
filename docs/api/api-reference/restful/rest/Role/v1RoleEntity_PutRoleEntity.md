---
title: PUT Role/{id}
id: v1RoleEntity_PutRoleEntity
---

# PUT Role/{id}

```http
PUT /api/v1/Role/{id}
```

Updates the existing RoleEntity



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The RoleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Role/{id}?$select=name,department,category/id
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




RoleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | RoleEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Role/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "RoleId": 825,
  "Name": "Bauch, Berge and Heathcote",
  "Tooltip": "cumque",
  "RoleType": "Anonymous",
  "Deleted": 198,
  "Rank": 413,
  "Created": "2004-09-23T09:40:59.5106627+02:00",
  "UseCategories": 421,
  "CreatedBy": {
    "AssociateId": 372,
    "Name": "Reinger-Rogahn",
    "PersonId": 616,
    "Rank": 225,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 353,
    "FullName": "Harmon Moore",
    "FormalName": "Borer Inc and Sons",
    "Deleted": false,
    "EjUserId": 92,
    "UserName": "Cruickshank-Shanahan"
  },
  "Updated": "2010-04-08T09:40:59.5106627+02:00",
  "UpdatedBy": {
    "AssociateId": 98,
    "Name": "Gusikowski, Bogan and Labadie",
    "PersonId": 392,
    "Rank": 716,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 187,
    "FullName": "Ms. Jacques Murray",
    "FormalName": "Dibbert-Willms",
    "Deleted": true,
    "EjUserId": 342,
    "UserName": "Koss Inc and Sons"
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
          "Value": "ducimus",
          "Description": "Ergonomic asynchronous hardware",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "integrate magnetic e-markets"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 448
            }
          }
        }
      ],
      [
        {
          "Value": "porro",
          "Description": "Persistent maximized policy",
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
              "FieldLength": 634
            }
          }
        }
      ]
    ]
  }
}
```

```http_
HTTP/1.1 200 RoleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "RoleId": 741,
  "Name": "Considine Group",
  "Tooltip": "deleniti",
  "RoleType": "Anonymous",
  "Deleted": 186,
  "Rank": 288,
  "Created": "2005-09-26T09:40:59.5136654+02:00",
  "UseCategories": 368,
  "CreatedBy": {
    "AssociateId": 402,
    "Name": "West-Schuppe",
    "PersonId": 914,
    "Rank": 715,
    "Tooltip": "ex",
    "Type": "AnonymousAssociate",
    "GroupIdx": 326,
    "FullName": "Cleve Lind",
    "FormalName": "Thompson, Morar and Ullrich",
    "Deleted": false,
    "EjUserId": 645,
    "UserName": "Mohr-Kovacek",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 789
      }
    }
  },
  "Updated": "1996-11-22T09:40:59.5136654+01:00",
  "UpdatedBy": {
    "AssociateId": 849,
    "Name": "Buckridge-Schmitt",
    "PersonId": 87,
    "Rank": 161,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 206,
    "FullName": "Ms. Aubree Walter",
    "FormalName": "Kovacek-Sporer",
    "Deleted": false,
    "EjUserId": 840,
    "UserName": "Waters-Rodriguez",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 644
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
          "Description": "Up-sized mission-critical success",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "revolutionize collaborative metrics"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 38
            }
          }
        }
      ],
      [
        {
          "Value": "tempora",
          "Description": "Re-engineered fresh-thinking software",
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
              "FieldLength": 906
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
        "FieldLength": 959
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
      "FieldLength": 249
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```