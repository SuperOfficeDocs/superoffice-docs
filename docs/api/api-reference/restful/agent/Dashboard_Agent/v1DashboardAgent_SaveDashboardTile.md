---
title: SaveDashboardTile
id: v1DashboardAgent_SaveDashboardTile
---

# SaveDashboardTile

```http
POST /api/v1/Agents/Dashboard/SaveDashboardTile
```

Updates the existing DashboardTile or creates a new DashboardTile if the id parameter is empty








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



Carrier object for DashboardTile.
Services for the DashboardTile Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDashboardAgent">Dashboard Agent</see>.

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

## Sample Request

```http!
POST /api/v1/Agents/Dashboard/SaveDashboardTile
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 267,
  "Caption": "rerum",
  "Description": "Optional optimal application",
  "ChartName": "Hintz-Hintz",
  "ChartId": "iste",
  "IsDefault": false,
  "AssociateId": 280,
  "GroupId": 67,
  "SelectionId": 151,
  "Config": "sunt",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Collier LLC",
      "Description": "Realigned empowering help-desk",
      "Type": "Boolean",
      "ListName": "Casper Inc and Sons",
      "ListItems": [
        {},
        {}
      ],
      "Value": "sint",
      "DefaultDataOption": true
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 428,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 428,
      "Visibility": "All",
      "DisplayValue": "et"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 43,
  "Caption": "et",
  "Description": "Balanced zero tolerance standardization",
  "ChartName": "Cummings, Hodkiewicz and Price",
  "ChartId": "placeat",
  "IsDefault": false,
  "AssociateId": 51,
  "GroupId": 880,
  "SelectionId": 208,
  "Config": "aliquam",
  "Type": "Bignum",
  "EntityType": "Activity",
  "Options": [
    {
      "Name": "Schaefer Group",
      "Description": "User-friendly optimal internet solution",
      "Type": "Boolean",
      "ListName": "Miller-Klein",
      "ListItems": [
        {},
        {}
      ],
      "Value": "ipsum",
      "DefaultDataOption": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    }
  ],
  "VisibleFor": [
    {
      "VisibleId": 895,
      "Visibility": "All",
      "DisplayValue": "dicta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate world-class niches"
          },
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    },
    {
      "VisibleId": 895,
      "Visibility": "All",
      "DisplayValue": "dicta",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "incubate world-class niches"
          },
          "FieldType": "System.String",
          "FieldLength": 64
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
      "FieldType": "System.String",
      "FieldLength": 338
    }
  }
}
```