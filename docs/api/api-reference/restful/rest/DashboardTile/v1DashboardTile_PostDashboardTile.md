---
title: POST DashboardTile
id: v1DashboardTile_PostDashboardTile
---

# POST DashboardTile

```http
POST /api/v1/DashboardTile
```

Creates a new DashboardTile

Calls the Dashboard agent service SaveDashboardTile.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/DashboardTile?$select=name,department,category/id
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

## Request Body: newEntity  

The DashboardTile to be saved. 

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


## Response: object

Dashboard Tile configuration



DashboardTile entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/DashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 350,
  "Caption": "sint",
  "Description": "Operative maximized contingency",
  "ChartName": "Jenkins Group",
  "ChartId": "maiores",
  "IsDefault": false,
  "AssociateId": 485,
  "GroupId": 922,
  "SelectionId": 682,
  "Config": "consequatur",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Torphy, Feil and Hirthe",
      "Description": "Fully-configurable intangible budgetary management",
      "Type": "Boolean",
      "ListName": "Barrows-Johnson",
      "ListItems": [
        {},
        {}
      ],
      "Value": "rerum",
      "DefaultDataOption": false
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 808,
      "Visibility": "All",
      "DisplayValue": "error"
    },
    {
      "VisibleId": 808,
      "Visibility": "All",
      "DisplayValue": "error"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 252,
  "Caption": "molestiae",
  "Description": "De-engineered 6th generation algorithm",
  "ChartName": "Graham Inc and Sons",
  "ChartId": "facere",
  "IsDefault": true,
  "AssociateId": 366,
  "GroupId": 410,
  "SelectionId": 744,
  "Config": "ratione",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Pacocha LLC",
      "Description": "Face to face intangible process improvement",
      "Type": "Boolean",
      "ListName": "Pouros, Simonis and Armstrong",
      "ListItems": [
        {},
        {}
      ],
      "Value": "nihil",
      "DefaultDataOption": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 379
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 530,
      "Visibility": "All",
      "DisplayValue": "harum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 161
        }
      }
    },
    {
      "VisibleId": 530,
      "Visibility": "All",
      "DisplayValue": "harum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 161
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "streamline rich web services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 177
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```