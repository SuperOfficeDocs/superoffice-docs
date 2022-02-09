---
title: GET DashboardTile/{id}
id: v1DashboardTile_GetDashboardTile
---

# GET DashboardTile/{id}

```http
GET /api/v1/DashboardTile/{id}
```

Gets a DashboardTile object.

Calls the Dashboard agent service GetDashboardTile.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the DashboardTile to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/DashboardTile/{id}?$select=name,department,category/id
```


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

Dashboard Tile configuration



DashboardTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | DashboardTile found. |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | The tile id |
| Caption | string | The tile caption |
| Description | string | The tile description |
| ChartName | string | The original chart name |
| ChartId | string | The original chart Id |
| IsDefault | bool | True if this is one of the default tiles |
| AssociateId | int32 | Id of the associate who owns this tile |
| GroupId | int32 | Id of the associates primary group at storage time |
| SelectionId | int32 | The selection that defines the data filter/restrictions |
| Config | string | The tile config |
| Type | string | The tile type, what kind of tile this is |
| EntityType | string | The tile entity type |
| Options | array | The tile options |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/DashboardTile/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 DashboardTile found.
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 460,
  "Caption": "est",
  "Description": "Total analyzing methodology",
  "ChartName": "Lesch-Larson",
  "ChartId": "ipsam",
  "IsDefault": true,
  "AssociateId": 268,
  "GroupId": 623,
  "SelectionId": 355,
  "Config": "aut",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Braun Inc and Sons",
      "Description": "Networked optimizing challenge",
      "Type": "Boolean",
      "ListName": "Donnelly LLC",
      "ListItems": [
        {},
        {}
      ],
      "Value": "sequi",
      "DefaultDataOption": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 35,
      "Visibility": "All",
      "DisplayValue": "placeat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    },
    {
      "VisibleId": 35,
      "Visibility": "All",
      "DisplayValue": "placeat",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 398
        }
      }
    }
  ],
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
      "FieldLength": 999
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```